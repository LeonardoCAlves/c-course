using System;

class Principal {
    static void Main() {
        Console.Write("Total da Compra: ");
        double total = double.Parse(Console.ReadLine());

        Console.Write("Cupom de desconto? [s ou n]: ");
        char temCupom = char.Parse(Console.ReadLine().ToLower()); // Converte para minúscula

        bool cupomDesconto = temCupom == 's'; // Determina o valor booleano com base na entrada

        Console.Write("Tipo de desconto:\n[1] 10%\n[2] 15%\n[3] 20%\n[4] 25%\nOpção: ");
        int tipoDesconto = int.Parse(Console.ReadLine());

        if (cupomDesconto) {
            if (tipoDesconto == 1) {
                total = total * (1 - 0.1); // 10% de desconto
            }
            else if (tipoDesconto == 2) {
                total = total * (1 - 0.15); // 15% de desconto
            }
            else if (tipoDesconto == 3) {
                total = total * (1 - 0.2); // 20% de desconto
            }
            else if (tipoDesconto == 4) {
                total = total * (1 - 0.25); // 25% de desconto
            }
            else {
                Console.WriteLine("Tipo de desconto inválido. Sem desconto aplicado.");
            }
        }
        Console.WriteLine("\nTotal a pagar: R$" + total);
    }
}
