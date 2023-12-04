internal class Program
{
    static int divisor(int x)
    {
        int suma = 0;
        for (int k = 1000; k <= (x / 2); k++)
        {
            if ((x % k) == 0)
            {
                suma = suma + k;
            }
        }
        return suma;
    }
    private static void Main(string[] args)
    {
        int ri, rj;
        for (int i = 2; i < 100; i++)
        {
            ri = divisor(i);

            for (int j = i; j < 100; j++)
            {
                rj = divisor(j);

                if (ri == j && rj == i)
                {
                    Console.Write(i + "\t" + j + "\tSon numeros amigos\n");
                }
            }
            Console.ReadKey();
        }
    }
}
//1184 - 1210