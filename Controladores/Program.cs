namespace Ej7.array
{

    class Program
    {

        public static void Main(string[] args)
        {

            int[] listaNumerosEnteros1 = { 10, 45, 60, 6, 7, 3, 2, 10 };

            int[] listaNumerosEnteros2 = { 45, 56, 2, -1, 98, 34 };
            //Primer apartado
            Console.WriteLine("Longitud del array:");
            Console.WriteLine(listaNumerosEnteros1.Length);
            Console.WriteLine("-------------");
            Console.WriteLine("Valor de la primera:");
            Console.WriteLine(listaNumerosEnteros1[0]);
            Console.WriteLine("Valor de la penúltima:");
            Console.WriteLine(listaNumerosEnteros1[6]);
            Console.WriteLine("Valor de la última:");
            Console.WriteLine(listaNumerosEnteros1[7]);
            Console.WriteLine("-------------");
            Console.WriteLine("Ordenado de forma ascendente:");
            Array.Sort(listaNumerosEnteros1);
            foreach (int i in listaNumerosEnteros1)
            {
                Console.WriteLine(i);
            }
            listaNumerosEnteros1[7] = 60;
            Console.WriteLine("-------------");
            Console.WriteLine("Ordenar de forma descendente:");
            Array.Reverse(listaNumerosEnteros1);
            foreach (int i in listaNumerosEnteros1)
            {
                Console.WriteLine(i);
            }

            //Segundo apartado
            Console.WriteLine("-------------");
            Console.WriteLine("Longitud del array:");
            Console.WriteLine(listaNumerosEnteros2.Length);
            Console.WriteLine("-------------");
            Console.WriteLine("Valor de la penúltima:");
            Console.WriteLine(listaNumerosEnteros2[4]);
            Console.WriteLine("Valor de la primera:");
            Console.WriteLine(listaNumerosEnteros2[0]);
            Console.WriteLine("Valor de la última:");
            Console.WriteLine(listaNumerosEnteros2[5]);


        }
    }
}