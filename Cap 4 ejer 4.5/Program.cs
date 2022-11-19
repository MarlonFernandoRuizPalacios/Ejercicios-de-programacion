namespace dias
{
    public class program
    {
        public static void Main()
        {
            int dias = 0;
            int mes = 0;
            int anyo = 0;
            int reciduo;

            Console.WriteLine("ingrese el anyo");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el dia");
            dias = Convert.ToInt32(Console.ReadLine());

            reciduo = anyo % 4;

            if (reciduo == 0)
            {

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dias <= 31)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 31)
                    {
                        Console.WriteLine("ERROR, EL DIA NO PUEDE PASAR DE 31, VUELVA A DIGITAR");
                    }
                }
                else if (mes > 12)
                {
                    Console.WriteLine("ERROR, EL MES NO PUEDE PASAR DE 12, VUELVA A DIGITAR");
                }

                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dias <= 30)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 30)
                    {
                        Console.WriteLine("ERROR, EL DIA NO PUEDE PASAR DE 30, VUELVA A DIGITAR");
                    }
                }


                if (mes == 2)
                {
                    if (dias <= 29)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 29)
                    {
                        Console.WriteLine("ERROR, EL DIA NO PUEDE PASAR DE 29, VUELVA A DIGITAR");
                    }
                }
            }

            else if (reciduo != 0)
            {

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dias <= 31)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 31)
                    {
                        Console.WriteLine("ERROR, EL DIA NO PUEDE PASAR DE 31, VUELVA A DIGITAR");
                    }
                }
                else if (mes > 12)
                {
                    Console.WriteLine("ERROR, EL MES NO PUEDE PASAR DE 12, VUELVA A DIGITAR");
                }

                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dias <= 30)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 30)
                    {
                        Console.WriteLine("ERROR, EL DIA NO PUEDE PASAR DE 30, VUELVA A DIGITAR");
                    }
                }


                if (mes == 2)
                {
                    if (dias <= 28)
                    {
                        DateTime mifecha = new DateTime(anyo, mes, dias);
                        mifecha = mifecha.AddDays(1);

                        Console.WriteLine(mifecha);
                    }
                    else if (dias > 28)
                    {
                        Console.WriteLine("ERROR, EL DIA NO PUEDE PASAR DE 28, VUELVA A DIGITAR");
                    }
                }
            }
        }
    }
}
