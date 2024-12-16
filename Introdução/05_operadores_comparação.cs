using System;

class Principal {
    static void Main() {
        Console.Write("Primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(num1 == num2);
        Console.WriteLine(num1 != num2);
        Console.WriteLine(num1 > num2);
        Console.WriteLine(num1 >= num2);
        Console.WriteLine(num1 < num2);
        Console.WriteLine(num1 <= num2);
    }
}