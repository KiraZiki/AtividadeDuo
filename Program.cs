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
