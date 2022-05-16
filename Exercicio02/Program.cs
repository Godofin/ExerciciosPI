//Desenvolva um algoritmo que leia a cotação do euro converta para o Real e imprima o resultado;

Console.WriteLine("Digite o valor em Euro");
double euro, real = 5.29, cotacaoEuroReal;

euro = double.Parse(Console.ReadLine());

cotacaoEuroReal = euro * real;

Console.WriteLine($"O valor da cotação no momento é de: {cotacaoEuroReal}");