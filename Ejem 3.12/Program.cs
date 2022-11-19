namespace ConsultorioDelDrLorenzo
{
    public class program
    {
        public static void Main()
        {
            int monto_que_ha_pagado, numero_de_cita, pago_por_la_cita;
            Console.Write("Digite el valor de numero de cita: ");
            numero_de_cita = int.Parse(Console.ReadLine());
            pago_por_la_cita = 0;
            monto_que_ha_pagado = 0;

            if (numero_de_cita >= 1 && numero_de_cita <= 3)
            {
                pago_por_la_cita = 200;
                monto_que_ha_pagado = numero_de_cita * 200;
            }
            if (numero_de_cita >= 4 && numero_de_cita <= 5)
            {
                pago_por_la_cita = 150;
                monto_que_ha_pagado = 3 * 200 + (numero_de_cita - 3) * 150;
            }
            if (numero_de_cita >= 6 && numero_de_cita <= 9)
            {
                pago_por_la_cita = 100;
                monto_que_ha_pagado = 3 * 200 + 2 * 150 + (numero_de_cita - 5) * 100;
            }
            if (numero_de_cita >= 10)
            {
                pago_por_la_cita = 50;
                monto_que_ha_pagado = 3 * 200 + 2 * 150 + 3 * 100 + (numero_de_cita - 9) * 50;
            }
            Console.WriteLine("Valor de monto que ha pagado: " + monto_que_ha_pagado);
            Console.WriteLine("Valor de pago por la cita: " + pago_por_la_cita);

        }
    }
}