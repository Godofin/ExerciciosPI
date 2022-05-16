//Desenvolva um algoritmo de comissão de vendas, um vendedor de carro vendeu 500 mil no mês de Maio,
//sabendo que a comissão dele é de 5% ao mês, qual será o valor que este vendedor receberá de
//comissão, calcule e imprima

double comissao, valorVenda, porcentagem;

Console.WriteLine("Digite o valor vendido no mês: ");
valorVenda = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da comissão em porcentagem");
porcentagem = double.Parse(Console.ReadLine());

porcentagem /= 100;

comissao = valorVenda * porcentagem;

Console.WriteLine($"O valor da comissão foi de: {comissao}");