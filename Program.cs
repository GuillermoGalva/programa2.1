using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Instanciar la clase para manejar la entrada de datos y comparación de números
            ComparadorNumeros comparador = new ComparadorNumeros();

            // Obtener los números ingresados por el usuario
            double num1 = comparador.ObtenerNumero("primer");
            double num2 = comparador.ObtenerNumero("segundo");

            // Realizar la comparación y mostrar los resultados
            comparador.CompararNumeros(num1, num2);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido.");
        }
    }
}

