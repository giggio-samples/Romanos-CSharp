namespace Romanos.Teste
{
    public class ConversorRomano
    {
        public static string Converter(int n)
        {

            string romano = "";

            var cem = "";
            while (n >= 100)
            {
                cem += "C";
                n -= 100;
            }

            var cinquenta = "";
            while (n >= 50)
            {
                cinquenta += "L";
                n -= 50;
            }
            if (n % 50 >= 40 && n % 50 < 50)
            {
                n -= 40;
                cinquenta = "X" + cinquenta + "L";
            }

            var dezena = "";
            while (n >= 5)
            {
                dezena += "V";
                n -= 5;
            }

            if (n % 5 == 4)
            {
                n -= 4;
                dezena = "I" + dezena + "V";
            }
            romano += cem + cinquenta + dezena;

            romano = romano.Replace("VV", "X");
            romano = romano.Replace("XXXXX", "L");
            romano = romano.Replace("LL", "C");


            for (int i = 1; i <= n; i++)
            {
                romano += "I";

            }
            return romano;
        }
    }
}