namespace divisor
{
    public class program
    {
        public static void Main()
        {
            int NumUno;
            int NumDos;
            double divisible;
            Console.WriteLine("Digite el primer numero");
            NumUno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            NumDos = Convert.ToInt32(Console.ReadLine());

            divisible = NumUno % NumDos;

            if (divisible == 0)
            {
                Console.WriteLine("El primer numero es divible entre el segundo");
            }
            else if (divisible != 0)
            {
                Console.WriteLine("El primer numero no es divible entre el segundo");
            }

        }

    }
}