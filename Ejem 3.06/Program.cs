namespace langosta
{
    public class program
    {
        public static void Main()
        {
            double personas;
            double costoT;
            Console.WriteLine("Una persona paga 95.00$");
            Console.WriteLine("mas de 200 personas pero menor o igual que 300 paga 85.00$");
            Console.WriteLine("mas de 300 personas paga 75.00$");
            Console.WriteLine("Digite el numero de personas");
            personas = Convert.ToDouble(Console.ReadLine());

            if (personas <= 200)
            {
                costoT = personas * 95.00;
                Console.WriteLine($"El presupuesto que debe tener es de: {costoT}");
            }
            if (personas > 200 && personas <= 300)
            {
                costoT = personas * 85.00;
                Console.WriteLine($"El presupuesto que debe tener es de: {costoT}");
            }
            if (personas > 300)
            {
                costoT = personas * 75.00;
                Console.WriteLine($"El presupuesto que debe tener es de: {costoT}");
            }

        }
    }
}