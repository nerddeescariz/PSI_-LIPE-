using System;
using System.IO;

const string ficheironotas = @"C:\Users\Aluno\Documents\GitHub\PSI_-LIPE-\Fichas\ficha_1\notas.txt";
const string ficheirobackup = @"C:\Users\Aluno\Documents\GitHub\PSI_-LIPE-\Fichas\ficha_1\notas_backup.txt";
int opcoes;
string nota;

do
{
    Console.WriteLine("1 - Digitar nota");
    Console.WriteLine("2 - Consultar notas");
    Console.WriteLine("3 - Apagar nota");
    Console.WriteLine("4 - Criar cópia de segurança");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Digite a sua opção:");

    opcoes = int.Parse(Console.ReadLine());

    switch (opcoes)
    {
        case 1:
            Console.WriteLine("Digite a sua nota:");
            nota = Console.ReadLine();

            File.AppendAllText(ficheironotas, nota + Environment.NewLine);
            Console.WriteLine("Nota guardada.");
            break;

        case 2:
            Console.WriteLine("Suas notas são:");

            if (File.Exists(ficheironotas))
            {
                Console.WriteLine(File.ReadAllText(ficheironotas));
            }
            else
            {
                File.Create(ficheironotas).Close();
                string.isNullOrEmpty(File.ReadAllText(ficheironotas));
                Console.WriteLine("Ainda não existem notas.");
            }
            break;

        case 3:
            Console.WriteLine("Digite a nota que deseja apagar:");
            string nota_apagar = Console.ReadLine();

            if (File.Exists(ficheironotas))
            {
                string[] notas = File.ReadAllLines(ficheironotas);
                string novas_notas = "";
                bool encontrada = false;

                foreach (string n in notas)
                {
                    if (n == nota_apagar && !encontrada)
                    {
                        encontrada = true;
                    }
                    else
                    {
                        novas_notas += n + Environment.NewLine;
                    }
                }

                if (encontrada)
                {
                    File.WriteAllText(ficheironotas, novas_notas);
                    Console.WriteLine("Nota apagada.");
                }
                else
                {
                    Console.WriteLine("Nota não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Ainda não existem notas.");
            }
            break;

        case 4:
            if (File.Exists(ficheironotas))
            {
                File.Copy(ficheironotas, ficheirobackup, true);
                Console.WriteLine("Cópia de segurança criada.");
            }
            else
            {
                Console.WriteLine("Ainda não existem notas para guardar.");
            }
            break;

        case 0:
            break;
    }
} while (opcoes != 0);