using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Loja loja = new Loja();
        bool continuar = true;
// Menu principal do programa
// onde o utilizador pode escolher entre listar videojogos, 
// adicionar um novo videojogo, vender um videojogo, consultar o valor total do stock ou sair do programa.

        while (continuar)
        {
            Console.WriteLine("\n1 - Listar videojogos");
            Console.WriteLine("2 - Adicionar videojogo");
            Console.WriteLine("3 - Vender videojogo");
            Console.WriteLine("4 - Consultar valor do stock");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine(); // Le a opcao escolhida pelo utilizador

            switch (opcao)
            {
                case "1":
                    loja.MetodoNove(); // Chama o metodo para listar os videojogos disponiveis na loja
                    break;

                case "2":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine(); // Le o nome do videojogo a ser adicionado

                    Console.Write("Plataforma: ");
                    string plataforma = Console.ReadLine(); // Le a plataforma do videojogo a ser adicionado

                    Console.Write("Preço: ");
                    if (!double.TryParse(Console.ReadLine(), out double preco)) // Tenta converter a entrada do utilizador
                    //  para um valor (double) e verifica se e valido
                    {
                        Console.WriteLine("Preço inválido."); // Mostra se o preco for invalido
                        break;
                    }

                    Console.Write("Stock: ");
                    if (!int.TryParse(Console.ReadLine(), out int stock) || stock < 0) // Tenta converter a entrada do utilizador
                    //  para um numero (int) e verifica se é válido
                    {
                        Console.WriteLine("Stock inválido.");
                        break;
                    }

                    loja.MetodoCinco(
                        new Videojogo(nome, plataforma, preco, stock)); // Cria um novo objeto Videojogo com os
                        //  dados fornecidos pelo utilizador e adiciona-o à loja

                    Console.WriteLine("Videojogo adicionado."); // Mensagem depois de criar 
                    break;

                case "3": 
                    Console.Write("Nome do videojogo: "); // Solicita ao utilizador o nome do videojogo que deseja vender
                    string nomeVenda = Console.ReadLine();

                    Videojogo jogo = loja.MetodoSete(nomeVenda);

                    if (jogo == null) // Verifica se o videojogo existe na loja
                    {
                        Console.WriteLine("Videojogo não encontrado."); // Se nao existir mostra uma mensagem de erro e volta ao menu
                        break;
                    }

                    Console.Write("Quantidade: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantidade))
                    {
                        Console.WriteLine("Quantidade inválida.");
                        break;
                    }

                    if (jogo.MetodoUm(quantidade))
                    {
                        loja.MetodoSeis();
                        Console.WriteLine("Venda realizada."); // Se a venda for bem-sucedida, atualiza o stock e 
                        // exibe uma mensagem de confirmação
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível realizar a venda."); // Se a venda nao for possível 
                        // exibe uma mensagem de erro
                    }
                    break;

                case "4":
                    Console.WriteLine(
                        $"Valor total do stock: {loja.MetodoOito():F2} €"); // Chama o metodo para calcular o valor e mostra o valor final
                    break;

                case "0":
                    loja.MetodoSeis();
                    continuar = false; // Desliga o loop e fecha o programa
                    break;

                default:
                    Console.WriteLine("Opção inválida."); // Caso o utilizador escreva outra opcao, mostra esta mensagem
                    break;
            }
        }
    }
}