namespace promocion
{
    public class program
    {
        public static void Main()
        {
            double precio;
            double costoT;
            double dineroh;
            Console.WriteLine("Compras iguales o superiores a 2500 tiene un descuento del 15%");
            Console.WriteLine("Compras menores a 2500 tiene un descuento del 8%");
            Console.WriteLine("Digite el precio del traje que desea comprar");
            precio = Convert.ToDouble(Console.ReadLine());

            if (precio >= 2500)
            {
                costoT = precio * 0.85;
                Console.WriteLine($"El costo que debe pagar con el descuento del 15% es: {costoT}");
                dineroh = precio * 0.15;
                Console.WriteLine($"El dinero ahorrado es: {dineroh}");
            }
            else if (precio < 2500)
            {
                costoT = precio * 0.92;
                Console.WriteLine($"El costo que debe pagar con el descuento del 8% es de: {costoT}");
                dineroh = precio * 0.8;
                Console.WriteLine($"El dinero ahorrado es de: {dineroh}");
            }
        }
    }
}