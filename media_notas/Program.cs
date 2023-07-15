using media_notas;

Console.WriteLine("Bem vindo ao teste 02, para iniciarmos, qual é o seu nome?");
string? nome = Console.ReadLine();
Aluno aluno = new Aluno(nome);
for (int i = 0; true; i++)
{
    Console.WriteLine(aluno.Nome + " por favor, nos informe qual foi a sua nota na prova?");
    double nota;
    while (!double.TryParse(Console.ReadLine(), out nota))
    {
        Console.Write("Digite uma nota válida: ");
    }
    aluno.AddNota(nota);
    Console.WriteLine("Seu nome é: " + nome);
    Console.WriteLine("Quantidade de provas: " + aluno.Notas.Count);
    Console.WriteLine("Sua média é: " + Queryable.Average(aluno.Notas.AsQueryable()));
    if (ConsoleUtil.finalizar() == ConsoleKey.S)
        return;
    Console.WriteLine();
}