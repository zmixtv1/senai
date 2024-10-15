namespace atividade_imc_mstest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        Assert.AreEqual(imc_previsto, i.imc);
    }

    [DataTestMethod]
    [DataRow(50, 1.75, "Abaixo do peso")]
    [DataRow(65, 1.75, "Peso normal")]    
    [DataRow(80, 1.75, "Sobrepeso")]      
    [DataRow(95, 1.75, "Obesidade Grau I")]
    [DataRow(110, 1.75, "Obesidade Grau II")] 
    [DataRow(130, 1.75, "Obesidade Grau III")] 
    public void Teste_Categoria_IMC(double peso, double altura, string categoriaEsperada)
    {
        IMC i = new IMC();
        i.peso = peso;
        i.altura = altura;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.AreEqual(categoriaEsperada, i.categoria);
    }
}
