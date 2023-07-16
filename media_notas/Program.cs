using media_notas;

while (true)
{
    //instanciar aluno
    Console.WriteLine("Informe o nome do aluno:");
    string? nome = Console.ReadLine();
    Aluno aluno = new Aluno(nome);

    //adicionar notas
    Console.WriteLine("Qual foi a nota do primeiro semestre do aluno " + aluno.Nome + "?");
    double p1;
    while (!double.TryParse(Console.ReadLine(), out p1))
    {
        Console.Write("Digite uma nota válida: ");
    }
    aluno.AddNota(p1);

    Console.WriteLine("Qual foi a nota do segundo semestre do aluno " + aluno.Nome + "?");
    double p2;
    while (!double.TryParse(Console.ReadLine(), out p2))
    {
        Console.Write("Digite uma nota válida: ");
    }
    aluno.AddNota(p2);

    //mostrar dados do aluno
    Console.WriteLine("Seu nome é: " + aluno.Nome);
    Console.WriteLine("Sua média é: " + aluno.Media);
    Console.WriteLine("O aluno foi: " + aluno.Status);

    //finalizar programa ou repetir
    if (ConsoleUtil.finalizar() == ConsoleKey.S)
        return;
    Console.WriteLine();
}