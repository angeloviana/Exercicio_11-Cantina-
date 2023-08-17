using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        int cod, qntd;
        double total = 0;

        Console.WriteLine("Digite o código do ítem e quantidade");
        string[] num = Console.ReadLine().Split(' ');
        cod = int.Parse(num[0], CultureInfo.InvariantCulture);
        qntd = int.Parse(num[1], CultureInfo.InvariantCulture);


        if ( cod == 1 )
        {
            total = 4.00 * qntd;
        }

        else if (cod == 2)
        {
            total = 4.50 * qntd;
        }

        else if (cod == 3)
        {
            total = 5.00 * qntd;
        }

        else if (cod == 4)
        {
            total = 2.00 * qntd;
        }

        else if (cod == 5)
        {
            total = 4.50 * qntd;
        }

        else
        {
            Console.WriteLine("Código inválido");
        }
        
        Console.WriteLine("Total a pagar é de R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }
}