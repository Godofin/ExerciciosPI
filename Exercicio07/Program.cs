/*Desenvolver um algoritmo que leia quatro notas de um aluno, calcular a média e imprimir. 
[OPCIONAL]: A pontuação deste exercício será maior para quem imprimir se o aluno for 
APROVADO ou REPROVADO;
[CRITÉRIO APROVAÇÃO]: Média > 7*/

double[] notas = new double[4];

Console.WriteLine("Digite 4 notas (pressione Enter para cada número");

for (int i = 0; i < 4; i++)
{
    notas[i] = double.Parse(Console.ReadLine());
}

double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

if (media > 7)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
}

//Console.WriteLine($"A média é de: {media}");