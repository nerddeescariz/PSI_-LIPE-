using System;
using System.Collections.Generic;

class Program
{
    public static List<Livro> livros = new List<Livro>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("====== Gestor de Biblioteca ======\n");
            Console.WriteLine("1. Listar livros");
            Console.WriteLine("2. Pesquisar livro");
            Console.WriteLine("3. Adicionar livro");
            Console.WriteLine("4. Requisitar livro");
            Console.WriteLine("5. Devolver livro");
            Console.WriteLine("6. Remover livro");
            Console.WriteLine("0. Sair\n");
            Console.Write("Selecione uma opção: ");

            opcao = int.Parse(Console.ReadLine() ?? "0");

            switch (opcao)
            {
                case 1:
                    ListarLivros();
                    break;
                case 2:
                    PesquisarLivro();
                    break;
                case 3:
                    AdicionarLivro();
                    break;
                case 4:
                    Console.WriteLine("Função ainda não implementada.");
                    break;
                case 5:
                    Console.WriteLine("Função ainda não implementada.");
                    break;
                case 6:
                    Console.WriteLine("Função ainda não implementada.");
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
            }
        }
        while (opcao != 0);
    }

    private static void ListarLivros()
    {
        Console.WriteLine("====== 1. Listar Livros ======\n");

        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }

        foreach (var livro in livros)
        {
            Console.WriteLine($"- {livro.Titulo} | Autor: {livro.Autor} | ISBN: {livro.ISBN} | Ano: {livro.AnoPublicacao} | Gênero: {livro.Genero}");
        }
    }

    private static void PesquisarLivro()
    {
        Console.WriteLine("====== 2. Pesquisar Livro ======\n");
        Console.Write("Digite o título ou ISBN: ");
        string termo = Console.ReadLine() ?? "";

        var resultado = livros.Find(l => l.Titulo.Contains(termo, StringComparison.OrdinalIgnoreCase)
            || l.ISBN.Contains(termo, StringComparison.OrdinalIgnoreCase));

        if (resultado == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        Console.WriteLine($"Livro encontrado: {resultado.Titulo} | Autor: {resultado.Autor}");
    }

    private static void AdicionarLivro()
    {
        Console.WriteLine("====== 3. Adicionar Livro ======\n");

        Console.Write("Título: ");
        string titulo = Console.ReadLine() ?? "";
        Console.Write("Autor: ");
        string autor = Console.ReadLine() ?? "";
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine() ?? "";
        Console.Write("Ano de Publicação: ");
        int anoPublicacao = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Género: ");
        string genero = Console.ReadLine() ?? "";

        Livro livroNovo = new Livro
        {
            Titulo = titulo,
            Autor = autor,
            ISBN = isbn,
            AnoPublicacao = anoPublicacao,
            Genero = genero
        };

        livros.Add(livroNovo);
        Console.WriteLine("Livro adicionado com sucesso!");
    }
}
