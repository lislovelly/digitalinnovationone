
namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}