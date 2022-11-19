namespace SUMA_CON_CICLO
{
    public class program
    {
        public static void Main()
        {
            int numero;
            double numero_a_sumar;
            double total;
            numero = 1;
            total = 0;
            while (numero <= 10)
            {
                Console.WriteLine("Digite el numero a sumar ");
                numero_a_sumar = double.Parse(Console.ReadLine());
                total = total + numero_a_sumar;
                numero = numero + 1;
            }
            Console.Write($"El total de la suma es: {total}");
        }
    }
}
