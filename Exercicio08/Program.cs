//Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de subtração 
//e imprimir o total

double a, b, subtracao;

Console.WriteLine("Digite o valor A: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor B: ");
b = double.Parse(Console.ReadLine());
subtracao = a - b;
if (subtracao < 0)
{
    Console.WriteLine($"O valor da subtração é de: {subtracao}");
    Console.WriteLine("VALOR NEGATIVO");
}
else if (subtracao > 0)
{
    Console.WriteLine($"O valor da subtração é de: {subtracao}");
    Console.WriteLine("VALOR POSITIVO");
}
else
{
    Console.WriteLine($"O valor da subtração é de: {subtracao}");
    Console.WriteLine("O VALOR É ZERO");
}


