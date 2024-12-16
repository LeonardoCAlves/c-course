using System;

class Principal {
    static void Main() {
        string nome = "Leonardo Alves";
        int idade = 30;
        double altura = 1.83;
        char media = 'A';
        bool status = false;

        // Sem o parse para converter o tipo, isso gera um erro
        // pq todo ReadLine retorna um texto
        Console.Write("Situação: ");
        bool resposta = bool.Parse(Console.ReadLine());

        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
        Console.WriteLine(media);
        Console.WriteLine(status);
    }
}