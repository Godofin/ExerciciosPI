//Desenvolver um algoritmo que leia a altura de um homem e calcule o seu peso ideal, utilize a 
//seguinte fórmula: PESO IDEAL = (72.7 * H) – 58, onde H = altura.

double h, pesoIdeal;

Console.WriteLine("Digite o valor de sua altura sem vírgula/ponto: ");
h = double.Parse(Console.ReadLine()) / 100;
Console.WriteLine(h);

pesoIdeal = (72.7 * h) - 58;

Console.WriteLine($"O seu peso ideal é de {pesoIdeal}");
