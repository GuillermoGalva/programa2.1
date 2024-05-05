

class ComparadorNumeros
{
    public double ObtenerNumero(string posicion)
    {
        Console.Write($"Ingrese el {posicion} número: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public void CompararNumeros(double num1, double num2)
    {
        // Instanciar la clase para realizar operaciones matemáticas y mostrar resultados
        OperacionesMatematicas operaciones = new OperacionesMatematicas();

        // Realizar las operaciones según el resultado de la comparación
        if (num1 > num2)
        {
            operaciones.MostrarSumaYDiferencia(num1, num2);
        }
        else
        {
            operaciones.MostrarProductoYDivision(num1, num2);
        }
    }
}


