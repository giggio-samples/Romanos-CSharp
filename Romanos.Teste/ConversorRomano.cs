namespace Romanos.Teste
{
    public class ConversorRomano
    {
        public static string Converter(int n)
        {

            string romano = "";
            
            if (n % 50 == 40)
            {
                while (n % 50 == 40)
                {
                    romano += "L";
                    n -= 40;
                }

                romano = "X" + romano;
            }

            while (n >= 5)
            {
                romano += "V";
                n -= 5;
            }

            if (n % 5 == 4)
            {
                while (n == 4)
                {
                    romano += "V";
                    n -= 4;
                }

                romano = "I" + romano;
            }
           

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