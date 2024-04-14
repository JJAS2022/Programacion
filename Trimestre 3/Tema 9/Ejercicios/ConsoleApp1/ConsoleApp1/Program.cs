using System;

internal class Program
{
    private static void Main(string[] args)
    {
            /*
            Este programa lee caracteres introducidos por teclado,
            los almacena en una cadena, calcula cuales son los mayores y menores atendiendo a la tabla ASCII * 
            También almacena el número de ellos que son mayúsculas
            */
            string Letras = "";
            int numLetras = 0;
            char minLetra = char.MinValue;
            char maxLetra = char.MaxValue;
            int numMayusculas = 0;

            bool salir = false;

            while (numLetras < 10 && !salir)
            {
                //Leo una letra
                Console.WriteLine("Introduce una letra. Pulsa 0 si quieres salir: ");
                char letraAux = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                Console.WriteLine("-------");
                Letras = Letras + letraAux.ToString();

                if (Letras[numLetras] == '0')
                    salir = true;

                //almaceno los menores y mayores. 
                if (minLetra > letraAux)
                {
                    minLetra = letraAux;
                }
                if (maxLetra < letraAux)
                {
                    maxLetra = letraAux;
                }

                //Incremento el contador de letras 
                numLetras++;
            }

            if (numLetras > 50)
                Console.WriteLine("El cadena de caracteres esta llena");

            //Para cada char de la cadena
            for (int i = 0; i < numLetras && Letras[i] != '0'; i++)
            {
                //Si la letra es mayusculas
                if (Letras[i] >= 'A' && Letras[i] <= 'Z')
                {
                    //contabiliza las letras mayusculas 
                    numMayusculas++;
                }
            }

            //Escribe el resultado
            Console.WriteLine("el Char menor es : " + minLetra); Console.WriteLine("el Char mayor es : " + maxLetra);
            Console.WriteLine("Hay " + numMayusculas + " letras mayusculas ");
            Console.ReadKey();
        }
}