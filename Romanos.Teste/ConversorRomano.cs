namespace Romanos.Teste
{
    public class ConversorRomano
    {
        public static string Converter(int n)
        {

            string romano = "";

            while (n >= 50)
            {
                romano += "L";
                n -= 50;
            }

            if (n % 50 >= 40 && n % 50 < 50)
            {
                while (n % 50 >= 40 && n % 50 < 50)
                {
                    romano += "L";
                    n -= 40;
                }

                romano = "X" + romano;
            }

            var dezena = "";
            while (n >= 5)
            {
                dezena += "V";
                n -= 5;
            }

            if (n % 5 == 4)
            {
                while (n == 4)
                {
                    dezena += "V";
                    n -= 4;
                }

                dezena = "I" + dezena;
            }
            romano = romano + dezena;

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