namespace mediaInt
{
    internal class Program
    {
        static double media(int n1, int n2)
        {
            int somma = 0, o = 0;
            for (int i = n1; i <= n2; n2--)
            {
                if (n2 % 2 == 0)
                {

                }
                else
                {
                    somma = somma + n2;
                    o = o + 1;
                }
            }
            double m = somma / o;
            return m;

        }
        static void Main(string[] args)
        {
            int N1, N2;
            double M;
            Console.WriteLine("dimmi il primo numero il quale  vuoi  che l'intervallo inizii");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dimmi il  numero il quale fa finir l'intervallo ");
            N2 = Convert.ToInt32(Console.ReadLine());
            M = media(N1, N2);
            Console.WriteLine(" la media è " + M);




        }
    }
}
