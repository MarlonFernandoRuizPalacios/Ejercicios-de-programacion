namespace NumerosRomanos
{
    public class program
    {
        public static void Main()
        {
            double u, d, c, m;
            double num;
            string romanoM = null;
            string romanoC = null;
            string romanoD = null;
            string romanoU = null;
            Console.WriteLine("Digite un numero que no supere los 3999");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 4000)
            {
                Console.WriteLine("El numero no puede ser mayor a 3999");
            }
            if (num == 0 || num < 1)
            {
                Console.WriteLine("El numero no puede ser 0 o negatico");
            }
            m = Math.Truncate(num / 1000);
            c = Math.Truncate(num / 100) % 10;
            d = Math.Truncate(num / 10) % 10;
            u = Math.Truncate(num / 1) % 10;
            if (m == 1)
            {
                romanoM = "M";
            }
            if (m == 2)
            {
                romanoM = "MM";
            }
            if (m == 3)
            {
                romanoM = "MMM";
            }
            if (c == 1)
            {
                romanoC = "C";
            }
            if (c == 2)
            {
                romanoC = "CC";
            }
            if (c == 3)
            {
                romanoC = "CCC";
            }
            if (c == 4)
            {
                romanoC = "CD";
            }
            if (c == 5)
            {
                romanoC = "D";
            }
            if (c == 6)
            {
                romanoC = "DC";
            }
            if (c == 7)
            {
                romanoC = "DCC";
            }
            if (c == 8)
            {
                romanoC = "DCCC";
            }
            if (c == 9)
            {
                romanoC = "CM";
            }
            if (d == 1)
            {
                romanoD = "X";
            }
            if (d == 2)
            {
                romanoD = "XX";
            }
            if (d == 3)
            {
                romanoD = "XXX";
            }
            if (d == 4)
            {
                romanoD = "XL";
            }
            if (d == 5)
            {
                romanoD = "L";
            }
            if (d == 6)
            {
                romanoD = "LX";
            }
            if (d == 7)
            {
                romanoD = "LXX";
            }
            if (d == 8)
            {
                romanoD = "LXXX";
            }
            if (d == 9)
            {
                romanoD = "XC";
            }
            if (u == 1)
            {
                romanoU = "I";
            }
            if (u == 2)
            {
                romanoU = "II";
            }
            if (u == 3)
            {
                romanoU = "III";
            }
            if (u == 4)
            {
                romanoU = "IV";
            }
            if (u == 5)
            {
                romanoU = "V";
            }
            if (u == 6)
            {
                romanoU = "VI";
            }
            if (u == 7)
            {
                romanoU = "VII";
            }
            if (u == 8)
            {
                romanoU = "VIII";
            }
            if (u == 9)
            {
                romanoU = "IX";
            }
            romanoM += romanoC += romanoD += romanoU;
            System.Console.WriteLine(romanoM);
        }
    }
}