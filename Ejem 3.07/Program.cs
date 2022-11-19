namespace uvas
{
    public class program
    {
        public static void Main()
        {
            string Tipo;
            int ganancias;
            int precio;
            int tamaño;
            int costoN;
            int costoF;

            costoN = 0;
            Console.WriteLine("Digite el precio de kilo de uva");
            precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite si el tipo de uva es (A) o (B)");
            Tipo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite el tamaño (1) o (2)");
            tamaño = Convert.ToInt32(Console.ReadLine());


            if (Tipo == "A")
            {
                if (tamaño == 1)
                {
                    costoF = costoN + 20;
                    ganancias = precio + costoF;
                    Console.WriteLine($"Las ganancias obtenidas son de: {ganancias}");
                }
                if (tamaño == 2)
                {
                    costoF = costoN + 30;
                    ganancias = precio + costoF;
                    Console.WriteLine($"Las ganancias obtenidas son de: {ganancias}");
                }
            }
            if (Tipo == "B")
            {
                if (tamaño == 1)
                {
                    costoF = costoN - 30;
                    ganancias = precio + costoF;
                    Console.WriteLine($"Las ganancias obtenidas son de: {ganancias}");
                }
                if (tamaño == 2)
                {
                    costoF = costoN - 50;
                    ganancias = precio + costoF;
                    Console.WriteLine($"Las ganancias obtenidas son de: {ganancias}");
                }
            }

        }
    }
}
