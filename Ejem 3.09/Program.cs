namespace CompaniaTelefonica
{
    public class program
    {
        public static void Main()
        {
            int dia, turno;
            double impuestos, minutos, subtotal, total;
            Console.Write("Digite el valor de minutos: ");
            minutos = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona el valor de dia.");
            Console.WriteLine("1.- domingo");
            Console.WriteLine("2.- h\u00E1bil");
            Console.WriteLine("3.- inh\u00E1bil");
            do
            {
                dia = int.Parse(Console.ReadLine());
                if (dia < 1 || dia > 3)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (dia < 1 || dia > 3);
            Console.WriteLine("Selecciona el valor de turno.");
            Console.WriteLine("1.- matutino");
            Console.WriteLine("2.- vespertino");

            do
            {
                turno = int.Parse(Console.ReadLine());
                if (turno < 1 || turno > 2)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (turno < 1 || turno > 2);
            subtotal = 0;
            if (minutos <= 5)
                subtotal = minutos;
            if (minutos > 5 && minutos <= 8)
                subtotal = 5.0 + (minutos - 5) * 0.8;
            if (minutos > 8 && minutos <= 10)
                subtotal = 5.0 + 3.0 * 0.8 + (minutos - 8) * 0.7;
            if (minutos > 10)
                subtotal = 5.0 + 3.0 * 0.8 + 2.0 * 0.7 + (minutos - 10) * 0.5;
            impuestos = 0;
            if (dia == 1)
                impuestos = subtotal * 0.03;
            if (dia == 2 && turno == 1)
                impuestos = subtotal * 0.15;
            if (dia == 2 && turno == 1)
                impuestos = subtotal * 0.1;
            total = subtotal + impuestos;
            Console.WriteLine("Valor de impuestos: " + impuestos);
            Console.WriteLine("Valor de subtotal: " + subtotal);
            Console.WriteLine("Valor de total: " + total);

        }
    }
}