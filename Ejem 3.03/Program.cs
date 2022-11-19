namespace negativo_o_positivo
{
    public class program
    {
        public static void Main()
        {
            int num1;
            double costoT;

            Console.WriteLine("Digite el numero de lapizeros que desea comprar");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (1000 <= num1)
            {
                costoT = num1 * 85;
                Console.WriteLine($"El costo que debe pagar es: {costoT}");
            }
            else if (1000 > num1)
            {
                costoT = num1 * 90;
                Console.WriteLine($"El costo que debe pagar es: {costoT}");
            }
        }
    }
}