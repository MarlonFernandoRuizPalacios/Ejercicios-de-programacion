namespace suma_producto_media
{
    public class Program
    {
        public static void Main()
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int suma;
            int producto;
            double media;
            Console.WriteLine("Digite el primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer número:");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el cuarto número:");
            numero4 = Convert.ToInt32(Console.ReadLine());
            suma = numero1 + numero2 + numero3 + numero4;
            producto = numero1 * numero2 * numero3 * numero4;
            media = (numero1 + numero2 + numero3 + numero4) / 4;
            Console.WriteLine($"El resultado de la suma de los números es: {suma}");
            Console.WriteLine($"El resultado del producto de los números es: {producto}");
            Console.WriteLine($"El resultado de la media es: {media}");
        }
    }
}