
using Calculadora.Services;

CalculadoraImp c = new();

int n1 = 10;
int n2 = 5;

Console.WriteLine($"{n1} + {n2} = {CalculadoraImp.Somar(n1, n2)}");

