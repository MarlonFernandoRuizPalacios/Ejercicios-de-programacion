namespace Sumar_con_para
{
    public class program
    {
        public static void Main()
        {
            int contador;
            int limite;
            int sumatoria;
            sumatoria = 0;
            contador = 1;
            limite = 10;
            for (contador = 1; contador <= limite; contador++)
            {
                sumatoria = sumatoria + contador;
            }
            Console.WriteLine($"El resultado de la sumatoria de los enteros de 1 al 10 es: {sumatoria}");
        }
    }
}