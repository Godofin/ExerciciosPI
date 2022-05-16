//Desenvolva um algoritmo para converter a temperatura em graus Celsius para Fahrenheit,
//a fórmula é F = (9 * C + 160) / 5

double celsius, fahrenheit;

Console.WriteLine("Adicione a temperatura em Celsius: ");
celsius = double.Parse(Console.ReadLine());

fahrenheit = ((9 * celsius) + 160) / 5;

Console.WriteLine($"O valor de {celsius}°C é igual a {fahrenheit}°F");
