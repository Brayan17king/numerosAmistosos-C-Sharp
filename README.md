# Numeros Amistosos

##### Muchos pares de números amigables son conocidos; sin embargo, sólo uno de los pares (220, 284) tiene valores menores que 1000. El siguiente par está en el rango [1000, 1500].
##### Desarrolle un programa que permita encontrar dicho par.

```csharp
    static int divisor(int x)
    {
        int suma = 0;
        for (int i = 1; i <= (x / 2); i++)
        {
            if ((x % i) == 0)
            {
                suma = suma + i;
            }
        }
        return suma;
    }
    private static void Main(string[] args)
    {
        int ri, rj;
        for (int i = 2; i < 1500; i++)
        {
            ri = divisor(i);

            for (int j = i; j < 1500; j++)
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
```