namespace Impuesto
{
    public class program
    {
        public static void Main()
        {
            double precio_del_articulo, subtotal, total;

            Console.WriteLine("Digite el valor de precio del articulo: ");
            precio_del_articulo = double.Parse(Console.ReadLine());
            subtotal = precio_del_articulo * 0.12;
            total = subtotal + precio_del_articulo;

            if (total > 50000)
            {
                total = total * 0.95;
            }

            Console.WriteLine("Valor de total: " + total);

        }
    }
}