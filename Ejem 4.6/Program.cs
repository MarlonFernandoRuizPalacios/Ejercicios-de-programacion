public class program
{
    public static void Main()
    {
        int mes;
        double deposito;
        double total;
        mes = 1;
        total = 0;


        while (mes <= 12)
        {
            Console.WriteLine($"Digite la cantidad que deposita en el mes {mes} ");
            deposito = Convert.ToDouble(Console.ReadLine());
            total = total + deposito;
            mes = mes + 1;
            Console.WriteLine($"lleva ahorrado {total}");
        }
        Console.WriteLine($"El total ahorrado es de: {total}");
    }
}
