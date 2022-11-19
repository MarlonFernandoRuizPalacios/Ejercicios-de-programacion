namespace numero_mayor
{
    public class program
    {
        public static void Main()
        {
            double num1;
            double num2;
            Console.WriteLine("Digite el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());


            if (num2 > num1)
            {
                Console.WriteLine($"El numero mayor es {num2}");
            }
            else if (num2 < num1)
            {
                Console.WriteLine($"El numero mayor es {num1}");
            }
        }
    }
}
