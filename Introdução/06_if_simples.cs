using System;

class Principal {
    static void Main() {
        Console.Write("Total da Compra: ");
        double total = double.Parse(Console.ReadLine());
        bool cupomDesconto = true;

        if (cupomDesconto) {
            total = total * 0.9; // Desconto de 10%
        }
        Console.WriteLine("Total a pagar: R$ " + total);
    }
}