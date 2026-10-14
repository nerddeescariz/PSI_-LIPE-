using System;
using System.Collections.Generic;
using System.Text;

class Loja
{
    public List<Videojogo> Jogos { get; set; }
    private const string CaminhoFicheiro = "videojogos.txt"; // Caminho do ficheiro onde os dados dos videojogos serão armazenados

    public Loja() // inicaliza e carrega os dados do jogo apartir do ficheiro
    {
        Jogos = new List<Videojogo>();
        MetodoQuatro();
    }

    public void MetodoCinco(Videojogo jogo) // metodo para adicionar jogos 
    {
        Jogos.Add(jogo);
        MetodoSeis();
    }

    public Videojogo MetodoSete(string nome) // metodo que procura o jogo pelo nome
    {
        foreach (Videojogo jogo in Jogos)
        {
            if (jogo.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return jogo;
            }
        }

        return null;
    }

    public double MetodoOito() // metodo que calcula o valor total do stock
    {
        double total = 0;

        foreach (Videojogo jogo in Jogos)
        {
            total += jogo.Preco * jogo.Stock;
        }

        return total;
    }

    public void MetodoNove() // metodo que lista os jogos disponiveis
    {
        foreach (Videojogo jogo in Jogos)
        {
            jogo.MetodoTres();
            Console.WriteLine("--------------------");
        }
    }

    public void MetodoSeis() // metodo que guarda os dados dos jogos no ficheiro
    {
        List<string> linhas = new List<string>();

        foreach (Videojogo jogo in Jogos)
        {
            linhas.Add(jogo.MetodoDois());
        }

        File.WriteAllLines(CaminhoFicheiro, linhas);
    }

    public void MetodoQuatro() // metodo que carrega os dados dos jogos a partir do ficheiro
    {
        if (!File.Exists(CaminhoFicheiro))
        {
            File.WriteAllText(CaminhoFicheiro, "");
            return;
        }

        string[] linhas = File.ReadAllLines(CaminhoFicheiro);

        foreach (string linha in linhas)
        {
            string[] dados = linha.Split('|');

            if (dados.Length == 4 &&
                double.TryParse(dados[2], out double preco) &&
                int.TryParse(dados[3], out int stock))
            {
                Videojogo jogo = new Videojogo(
                    dados[0], dados[1], preco, stock);

                Jogos.Add(jogo);
            }
        }
    }
}