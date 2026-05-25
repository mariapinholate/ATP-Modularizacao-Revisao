using System;

class Program
{

    public static void Main()
    {
        
        int[] v = new int[12];

        Preencher(v);
 
        Console.WriteLine(" Estoque antes das vendas: ");
        ExibirEstoque(v);
        Console.WriteLine("Total: " + Total(v) + " produtos");
        Console.WriteLine();

       
        for (int i = 0; i < v.Length; i++)
        {
            Quantidade(ref v[i]);
        }

       
        Console.WriteLine(" Estoque apos as vendas: ");
        ExibirEstoque(v);
        Console.WriteLine("Total Final: " + Total(v) + " produtos");
    }

  
    static void Preencher(int[] vetor)
    {
        Random r = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(5, 51);
        }
    }

    
    static void Quantidade(ref int quantidade)
    {
        quantidade = quantidade - 5;

        if (quantidade < 0)
        {
            quantidade = 0;
        }
    }

  
    static int Total(int[] vetor)
    {
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma = soma + vetor[i];
        }

        return soma;
    }

    
    static void ExibirEstoque(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Produto " + (i + 1) + ": " + vetor[i] + " unidades");
        }
    }
}