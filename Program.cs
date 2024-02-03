// Define una clase pública llamada NumerosAmistosos
public class NumerosAmistosos
{
    // Define el método Main(), que es el punto de entrada del programa
    public static void Main(string[] args)
    {
        // Bucle for que itera desde 1000 hasta 1500
        for (int i = 1000; i <= 1500; i++)
        {
            // Bucle for anidado que itera desde i + 1 hasta 1500
            for (int j = i + 1; j <= 1500; j++)
            {
                // Verifica si los dos números actuales (i y j) son amistosos
                if (EsAmistoso(i, j))
                {
                    // Imprime los dos números amistosos en la consola
                    Console.WriteLine("Los Numeros amistosos Entre 1000 y 1500 son: ({0}, {1})", i, j);
                }
            }
        }
    }

    // Define una función estática llamada EsAmistoso() que toma dos números como entrada y devuelve un valor booleano
    static bool EsAmistoso(int a, int b)
    {
        // Variable para almacenar la suma de los divisores propios de a
        int sumaDivisoresA = 0;

        // Variable para almacenar la suma de los divisores propios de b
        int sumaDivisoresB = 0;

        // Bucle for que itera desde 1 hasta a - 1
        for (int i = 1; i < a; i++)
        {
            // Verifica si i es un divisor de a
            if (a % i == 0)
            {
                // Suma i a la variable sumaDivisoresA
                sumaDivisoresA += i;
            }
        }

        // Bucle for que itera desde 1 hasta b - 1
        for (int i = 1; i < b; i++)
        {
            // Verifica si i es un divisor de b
            if (b % i == 0)
            {
                // Suma i a la variable sumaDivisoresB
                sumaDivisoresB += i;
            }
        }

        // Devuelve true si la suma de los divisores propios de a es igual a b y la suma de los divisores propios de b es igual a a
        return sumaDivisoresA == b && sumaDivisoresB == a;
    }
}