namespace sueldo_semanal
{
    public class program
    {
        public static void Main()
        {
            double horaT, pagoH, pagoS;

            Console.WriteLine("Digite la catidad de horas");
            horaT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la catidad de paga por hora");
            pagoH = Convert.ToDouble(Console.ReadLine());

            pagoS = horaT * pagoH;

            Console.Write($"El sueldo semanal es: {pagoS}");
        }
    }
}