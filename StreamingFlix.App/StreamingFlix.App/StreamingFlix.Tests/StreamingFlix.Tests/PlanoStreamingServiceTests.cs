using StreamingFlix.App;
using Xunit;

namespace StreamingFlix.Tests;

public class PlanoStreamingServiceTests
{
    private readonly PlanoStreamingService _service = new PlanoStreamingService();

    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void ObterClassificacaoPorQualidade_DeveRetornarClassificacaoCorreta(int telas, string esperado)
    {
        string resultado = _service.ObterClassificacaoPorQualidade(telas);
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(50, 1, 50)]
    [InlineData(50, 6, 45)]
    [InlineData(50, 12, 40)]
    public void CalcularMensalidadeComDesconto_DeveAplicarDescontoCorreto(int valorBase, int meses, int esperado)
    {
        int resultado = _service.CalcularMensalidadeComDesconto(valorBase, meses);
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]
    [InlineData(20, true, false)]
    [InlineData(16, false, false)]
    public void PodeAcessarConteudoAdulto_DeveValidarPermissaoCorretamente(int idade, bool controleParental, bool esperado)
    {
        bool resultado = _service.PodeAcessarConteudoAdulto(idade, controleParental);
        Assert.Equal(esperado, resultado);
    }
}
