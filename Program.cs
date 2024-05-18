using System;

// Jogador de Futebol
struct JogadorFutebol
{
    public string Nome;
    public string Clube;
    public int CartoesAmarelos;
    public int CartoesVermelhos;

    public void RegistrarCartaoAmarelo()
    {
        CartoesAmarelos++;
    }

    public void RegistrarCartaoVermelho()
    {
        CartoesVermelhos++;
    }

    public bool VerificarVinculoClube()
    {
        return !string.IsNullOrEmpty(Clube);
    }

    public void Imprimir()
    {
        Console.WriteLine($"Jogador: {Nome}\nClube: {Clube}\nCartões Amarelos: {CartoesAmarelos}\nCartões Vermelhos: {CartoesVermelhos}\n");
    }
}

// Equipe de E-sports
struct EquipeEsports
{
    public string Nome;
    public DateTime DataEstreia;
    public int CampeonatosVencidos;
    public decimal ValorTotalPremiacoes;

    public void RegistrarCampeonatoVencido(decimal valorPremio)
    {
        CampeonatosVencidos++;
        AtualizarValorTotalPremiacoes(valorPremio);
    }

    public void AtualizarValorTotalPremiacoes(decimal valor)
    {
        ValorTotalPremiacoes += valor;
    }

    public bool VerificarAnoEstreia()
    {
        return DataEstreia.Year == DateTime.Now.Year;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Equipe: {Nome}\nData de Estreia: {DataEstreia}\nCampeonatos Vencidos: {CampeonatosVencidos}\nValor Total de Premiações: {ValorTotalPremiacoes:C}\n");
    }
}
// Produto
struct Produto
{
    public string Nome;
    public decimal Preco;
    public int QuantidadeEstoque;

    public void AplicarCupomDescontoValor(decimal valorDesconto)
    {
        Preco -= valorDesconto;
    }

    public void AplicarCupomDescontoPorcentagem(decimal percentualDesconto)
    {
        Preco *= (1 - percentualDesconto / 100);
    }

    public int VerificarQuantidadeEmEstoque()
    {
        return QuantidadeEstoque;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: {Preco:C}\nQuantidade em Estoque: {QuantidadeEstoque}\n");
    }
}

// Professor
struct Professor
{
    public string Nome;
    public decimal Salario;
    public int CargaHoraria;

    public void ReajusteSalarialEmValor(decimal valorReajuste)
    {
        Salario += valorReajuste;
    }

    public void ReajusteSalarialEmPorcentagem(decimal percentualReajuste)
    {
        Salario *= (1 + percentualReajuste / 100);
    }

    public void DescontoSalarialPorFaltaEmValor(decimal valorDesconto)
    {
        Salario -= valorDesconto;
    }

    public void DescontoSalarialPorFaltaEmPorcentagem(decimal percentualDesconto)
    {
        Salario *= (1 - percentualDesconto / 100);
    }

    public void AumentarCargaHorariaDeTrabalho(int novaCargaHoraria)
    {
        CargaHoraria = novaCargaHoraria;
        // Exemplo de reajuste salarial (aumento de 10%)
        ReajusteSalarialEmPorcentagem(10);
    }

    public void Imprimir()
    {
        Console.WriteLine($"Professor: {Nome}\nSalário: {Salario:C}\nCarga Horária: {CargaHoraria} horas\n");
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso
        JogadorFutebol jogador = new JogadorFutebol { Nome = "Cristiano Ronaldo", Clube = "Juventus" };
        jogador.RegistrarCartaoAmarelo();
        jogador.RegistrarCartaoVermelho();
        jogador.Imprimir();

        EquipeEsports equipe = new EquipeEsports { Nome = "Team X", DataEstreia = new DateTime(2020, 1, 1) };
        equipe.RegistrarCampeonatoVencido(5000);
        equipe.Imprimir();

        Produto produto = new Produto { Nome = "Mouse Gamer", Preco = 150, QuantidadeEstoque = 50 };
        produto.AplicarCupomDescontoValor(20);
        produto.Imprimir();

        Professor professor = new Professor { Nome = "Ana Silva", Salario = 4000, CargaHoraria = 40 };
        professor.AumentarCargaHorariaDeTrabalho(50);
        professor.Imprimir();
    }
}