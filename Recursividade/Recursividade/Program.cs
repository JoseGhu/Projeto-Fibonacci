using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sequência de Fibonacci até 50.000:");

        int i = 0;
        while (true)
        {
            int fibValor = Fibonacci(i);
            if (fibValor > 50000)
                break;

            Console.WriteLine(fibValor);
            i++;
        }
    }

    static int Fibonacci(int numero)
    {
        if (numero == 0)
            return 0;
        if (numero == 1)
            return 1;

        return Fibonacci(numero - 1) + Fibonacci(numero - 2);
    }
}