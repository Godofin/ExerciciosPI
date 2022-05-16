//Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de divisão e 
//modularização, ou seja, imprimir apenas o resto da divisão;

double a, b, divisao, resto;

Console.WriteLine("Insira o valor de A: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor de B: ");
b = double.Parse(Console.ReadLine());

resto = a % b;

if (a == 0 || b == 0)
{
    Console.WriteLine("Não existe divisão por zero, favor tentar novamente");
}
else
{
    Console.WriteLine($"O resultado do resto da divisão é de: {resto}");
}
