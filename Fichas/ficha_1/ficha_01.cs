using System;
using System.IO;

const string ficheironotas = "notas.txt";
int opcoes;
string nota;
do
{
Console.WriteLine("Digite a sua opção:");
Console.WriteLine("1 - Digitar nota");
Console.WriteLine("2 - Consultar notas");
Console.WriteLine("3 - Apagar nota");
Console.WriteLine("4 - Criar cópia de segurança");
Console.WriteLine("0 - Sair");

opcoes = int.Parse(Console.ReadLine());

switch (opcoes)
{
    case 1:
        Console.WriteLine("Digite a sua nota:");
        nota = Console.ReadLine();
        CarregarNotas();
        break;
    case 2:
        Console.WriteLine("Suas notas são:");
        Console.WriteLine(nota);
        break;
    case 3:
        string nota_apagar;
        Console.WriteLine("Digite a nota que deseja apagar:");
        nota_apagar = Console.ReadLine();
        EliminarNotas();
        Console.WriteLine("Nota apagada.");
        break;
    case 4:
        if (File.Exists(ficheironotas))
        {
            File.Copy(ficheironotas, "notas_backup.txt");
            Console.WriteLine("Cópia de segurança criada.");
        }
        else
        {
            Console.WriteLine("Ainda não existem notas para guardar.");
        }
        break;
    case 0:
        Console.WriteLine("Saiu do programa.");
        break;
}

static void CarregarNotas()
{
    if (!File.Exists(ficheironotas))
    {
        using (File.Create(ficheironotas)) { }
    }
}

static void EliminarNotas()
{
    if(notas_apagar == ficheironotas)
    {
        File.Delete(ficheironotas);
    }
    else
    {
        Console.WriteLine("Nota não encontrada.");
    }
}

} while (opcoes != 0);