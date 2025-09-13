using System;
using System.Collections.Generic;

public class Livro
{
    // Atributos da classe
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;

    // Construtor padrão
    public Livro()
    {
        Titulo = "Sem título";
        Autor = "Desconhecido";
        AnoPublicacao = 0;
    }

    // Construtor com parâmetros
    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }

    // Método para exibir detalhes do livro
    public void ExibirDetalhes()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano de Publicação: " + AnoPublicacao);
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando lista de livros
        List<Livro> livros = new List<Livro>();

        // Livro criado com o construtor padrão
        Livro livro1 = new Livro();

        // Livros criados com construtor com parâmetros
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro3 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943);

        // Adicionando à lista
        livros.Add(livro1);
        livros.Add(livro2);
        livros.Add(livro3);

        // Exibindo detalhes de todos os livros
        Console.WriteLine(" Lista de Livros Cadastrados:\n");

        foreach (Livro livro in livros)
        {
            livro.ExibirDetalhes();
        }

        Console.ReadLine(); // Para manter a janela aberta no console
    }
}
