using System;

namespace AP14EJ02
{
    public class Triangulo
    {
        /// <summary>
        /// Informar el proceso
        /// </summary>
        private string proceso= "Creando triangulo";
        public Triangulo()
        {

            Console.WriteLine(proceso);
        }

        //Atributos de la clase (información de los tres lados)
        double lado1, lado2, lado3; 

        // Constructor
        public Triangulo(double l1, double l2, double l3):this()
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
            Console.WriteLine("Crear triangulo con exito");
        }

        public bool EsEquilatero()  // Todos los lados iguales
        {
            if (lado1 == lado2 && lado2 == lado3)
                return true;
            else
                return false;
        }

        public bool EsEscaleno() // Todos los lados distintos
        {
            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                return true;
            else
                return false;
        }

        public bool EsIsosceles()
        {
            if (EsEquilatero() || EsEscaleno())
                return false;
            else
                return true;
        }

    }
}
