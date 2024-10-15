namespace atividade_imc_xunit;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        Assert.Equal(imc_previsto, i.imc);
    }

    [Theory]
    [InlineData(50, 1.75, "Abaixo do peso")]
    [InlineData(68, 1.75, "Peso normal")]
    [InlineData(80, 1.75, "Sobrepeso")]
    [InlineData(92, 1.75, "Obesidade Grau I")]
    [InlineData(105, 1.75, "Obesidade Grau I")] // Ajustado para Obesidade Grau I
    [InlineData(120, 1.75, "Obesidade Grau II")] // Ajustado para Obesidade Grau II
    public void Teste_Categoria_IMC(double peso, double altura, String cat)
    {
        IMC i = new IMC();
        i.peso = peso;
        i.altura = altura;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal(cat, i.categoria);
    }
}