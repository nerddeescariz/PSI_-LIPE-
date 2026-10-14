using System;
using System.Collections.Generic;
using System.Text;


class Videojogo
{
    public string Nome { get; set; } // armazena o nome do jogo
    public string Plataforma { get; set; } // armazena a plataforma do jogo
    public double Preco { get; set; } // armazena o preço do jogo
    public int Stock { get; set; } // armazena a quantidade de stock do jogo

    public Videojogo(string nome, string plataforma, double preco, int stock) // classe onde armazena os dados todos anteriores
    {
        Nome = nome;
        Plataforma = plataforma;
        Preco = preco;
        Stock = stock;
    }

    public bool MetodoUm(int quantidade) // verica a quantidade de stock
    {
        if (quantidade <= 0)
        {
            return false;
        }

        if (quantidade > Stock)
        {
            return false;
        }

        Stock -= quantidade;
        return true;
    }

    public string MetodoDois() //metodo que retorna os dados separados por |
    {
        return $"{Nome}|{Plataforma}|{Preco}|{Stock}";
    }

    public void MetodoTres() // metodo que mostra os dados do jogo
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Plataforma: {Plataforma}");
        Console.WriteLine($"Preço: {Preco:F2} €");
        Console.WriteLine($"Stock: {Stock}");
    }
}