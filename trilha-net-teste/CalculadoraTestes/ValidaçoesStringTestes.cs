using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidaçoesStringTestes
    {
        private ValidaçõesString _validacoes;

        public ValidaçoesStringTestes()
        {
            _validacoes = new ValidaçõesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Ola";
            //Act
            int resultado = ValidaçõesString.ContarCaracteres(texto);
            //Assert
            Assert.Equal(3, resultado);       
        }
    }
}