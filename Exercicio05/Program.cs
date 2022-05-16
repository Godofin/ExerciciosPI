//Desenvolva um algoritmo para converter a temperatura em graus Fahrenheit para Celsius,
//a fórmula é C = (F -32) * 5 / 9;


double celsius, fahrenheit;

Console.WriteLine("Adicione a temperatura em Fahrenheit: ");
fahrenheit = double.Parse(Console.ReadLine());

celsius = ((fahrenheit - 32) * 5) / 9;
Console.WriteLine($"O valor de {fahrenheit}°F é igual a {celsius}°C");
