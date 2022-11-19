namespace PagoPorMetroCubicoDeAgua
{
    public class PagoPorMetroCubicoDeAgua
    {
        public static void Main()
        {
            double alto_en_m, ancho_en_m, largo_en_m, pago, precio_por_m3;
            double volumen_en_m3;
            Console.WriteLine("Digite el valor de alto en m");
            alto_en_m = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de ancho en m: ");
            ancho_en_m = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de largo en m: ");
            largo_en_m = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de precio por m3: ");
            precio_por_m3 = double.Parse(Console.ReadLine());
            volumen_en_m3 = alto_en_m * largo_en_m * ancho_en_m;
            pago = volumen_en_m3 * precio_por_m3;
            Console.WriteLine("Valor de pago: " + pago);
            Console.WriteLine("Valor de volumen en m3: " + volumen_en_m3);
        }
    }
}