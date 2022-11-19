namespace ej_210
{
    public class program
    {
        public static void Main()
        {
            double Metro;
            double Pulgada = 0.0254;
            double totalp;

            Console.WriteLine("Cuantos metros requiere");
            Metro = Convert.ToDouble(Console.ReadLine());

            totalp = Metro / Pulgada;

            Console.Write($"Las pulgada que debe pedir son: {totalp}");
        }
    }
}