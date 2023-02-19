namespace Formula_de_Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta1, delta2, bminus, x1, x2, div;



            Console.WriteLine("FORMULA DE BHASKARA");
            Console.WriteLine("X = \t-b +/- √b² - 4 * a * c\n\t______________________\t\n\t\t2*a");
            Console.WriteLine("");
            Console.WriteLine("Digite os valores:");
            
            Console.Write("A = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("B = ");
            b= double.Parse(Console.ReadLine());

            Console.Write("C = ");
            c = double.Parse(Console.ReadLine());

            delta1 = Delta1(a, b, c);

            delta2 = Delta2(delta1);

            bminus = (-(b));

            div = (2 / a);

            x1 = X1(bminus, delta2, div);

            x2= X2(bminus, delta2, div);

            Console.WriteLine("\n");
            Console.WriteLine("X = \t{0} +/- √ {1}² - 4 * {2} * {3}\n\t______________________\t\n\t\t2*{4}",bminus,b,a,c,a);
            Console.WriteLine("\n");
            Console.WriteLine("X = \t   {0} +/- √ {1}\n\t______________________\t\n\t\t2*{2}", bminus, delta1, a);
            Console.WriteLine("\n");
            Console.WriteLine("X = \t   {0} +/- {1}\n\t______________________\t\n\t\t2*{2}", bminus, delta2, a);
            Console.WriteLine("\n");

            if (delta1 < 0)
            {
                Console.WriteLine("Impossivel Calcular, Motivo: Delta < 0");
            }
            else
            {

                Console.WriteLine("RESULTADO DA FORMULÁ DE BHASKARA\n");
                Console.WriteLine("X¹ = {0}\n\nX² = {1}", x1, x2);
            }

        }
        static double Delta1(double a, double b, double c)
        {
            return ((b * b) - 4 * (a * c));
        }

        static double Delta2(double delta1)
        {
            return Math.Sqrt(delta1);
        }

        static double X1(double bminus, double delta2, double div)
        {
            return (bminus + delta2) / div;
        }

        static double X2(double bminus, double delta2, double div)
        {
            return (bminus - delta2) / div;
        }
    }
}