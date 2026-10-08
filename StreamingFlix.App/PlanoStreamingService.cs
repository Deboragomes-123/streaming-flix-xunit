namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas == 1) return "BÁSICO";
        if (telasSimultaneas == 2) return "PADRÃO";
        return "PREMIUM";
    }

    public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        if (mesesContratados >= 12) return valorBase - (valorBase * 20 / 100);
        if (mesesContratados >= 6) return valorBase - (valorBase * 10 / 100);
        return valorBase;
    }

    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        return idade >= 18 && !controleParentalAtivo;
    }
}
