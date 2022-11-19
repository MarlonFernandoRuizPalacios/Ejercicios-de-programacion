namespace terreno
{
    public class program
    {
        public static void Main()
        {
            decimal A, B, C, AR, AT, ATo;
            Console.WriteLine("Digite el lado A");
            A = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite el lado B");
            B = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite el lado C");
            C = decimal.Parse(Console.ReadLine());

            AR = B * C;
            AT = (A - C) * B / 2;
            ATo = AR + AT;

            Console.Write($"El area total es: {ATo}");

        }
    }
}
