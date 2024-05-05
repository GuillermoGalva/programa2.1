class OperacionesMatematicas
{
    public void MostrarSumaYDiferencia(double num1, double num2)
    {
        double suma = num1 + num2;
        double diferencia = num1 - num2;
        Console.WriteLine("El primer número es mayor.");
        Console.WriteLine("La suma de los números es: " + suma);
        Console.WriteLine("La diferencia de los números es: " + diferencia);
    }

    public void MostrarProductoYDivision(double num1, double num2)
    {
        double producto = num1 * num2;
        if (num2 != 0)
        {
            double division = num1 / num2;
            Console.WriteLine("El segundo número es mayor o igual al primero.");
            Console.WriteLine("El producto de los números es: " + producto);
            Console.WriteLine("La división del primer número respecto al segundo es: " + division);
        }
        else
        {
            Console.WriteLine("El segundo número es cero, no se puede realizar la división.");
        }
    }
}
