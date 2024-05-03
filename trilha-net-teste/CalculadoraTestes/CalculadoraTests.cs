using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{   

    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int n1 = 10;
        int n2 = 5;

        //Act
        int resultado = CalculadoraImp.Somar(n1, n2);

        //Assert
        Assert.Equal(15, resultado);       
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int n1 = 10;
        int n2 = 10;

        //Act
        int resultado = CalculadoraImp.Somar(n1, n2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = CalculadoraImp.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6})]
    [InlineData(new int[] {8, 10})]
    public void DeveVerificarSeNumerosEhParERetornarVerdadeiro(int[] numero)
    {
        Assert.All(numero, num => Assert.True(CalculadoraImp.EhPar(num)));
    }
 
//     [Theory]
//     [InlineData(2)]
//     [InlineData(4)]
//     [InlineData(6)]
//     [InlineData(8)]
//     [InlineData(10)]
//     public void DeveVerificarSeNumerosEhParERetornarVerdadeiro(int numero)
//     {
//         //Arrange

//         //Act
//         bool resultado = _calc.EhPar(numero);

//         //Assert
//         Assert.True(resultado);
//     }
}
    



