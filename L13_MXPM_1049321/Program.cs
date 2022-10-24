using System;

namespace L13_MXPM_1049321
{
    class Lab13
    {
        private string[] nombres;
        private int[] edades;
        public void Cargar()
        {
            Console.WriteLine("Laboratorio No.13: Vectores");
            nombres = new string[5];
            edades = new int[5];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Por favor ingrese su nombre:");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Edad:");
                string linea;
                linea = Console.ReadLine();
                edades[i] = int.Parse(linea);
                Console.WriteLine("--------------------------");
            }
        }
        public void MayoresdeEdad()
        {
            Console.WriteLine("Las personas que son mayores de 18 años son: ");
            for (int i = 0; i < nombres.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    Console.WriteLine(nombres [i]);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Lab13 pv = new Lab13();
            pv.Cargar();
            pv.MayoresdeEdad();
        }
    }
}



