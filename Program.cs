static void ejemplo1()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 92, 77, 68, 94, 55, 89, 71, 95, 65 };
    //Console.WriteLine(calificaciones[2]); para imprimir la posicion de la cadena
    //int suma = 0; variable para hacer una suma en la caderna  
    //foreach (int ejemplo1 in calificaciones)
    //for (int i = 0; i < calificaciones.Length; i++) una suma con ciclos

    {
        //suma += ejemplo1;aca hace la suma de la cadena
        //Console.WriteLine($"Calificación [{i +1}: {calificaciones[i]}]");
    }
    /*double promedio = (double)suma / calificaciones.Length;
    Console.WriteLine($"El promedio es: {promedio}"); aca hace la division para sacar el promedio e imprime el resultado*/
}

static void ejemplo2()
{
    int[] elementos = new int[] { 10, 20, 30, 40, 50 };
    Console.WriteLine("Original:");
    foreach (int item in elementos)
    { 
        Console.WriteLine(item);
    }
    Console.WriteLine("Ordenado:");
    Array.Sort(elementos);
    foreach (int item in elementos)
    {
        Console.WriteLine(item);
    }
    Array.Reverse(elementos);
    foreach (int item in elementos)
    {
        Console.WriteLine(item);
    }
}
static void despliegue(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}
static void ejemplo3()
{
    int[] elementos = new[] { 50, 20, 80, 90, 60 };
    Console.WriteLine("Original:");
    despliegue(elementos);
    Console.WriteLine("Ordenado:");
    Array.Sort(elementos);
    despliegue(elementos);
    Console.WriteLine("Reverso:");
    Array.Reverse(elementos);
    despliegue(elementos);
}
static void ejemplo4()
{
    int[] edades = { 25, 30, 18, 42, 30 };
    int indice = Array.IndexOf(edades, 30);
    Console.WriteLine(indice);
}

static void ejemplo5()
{
    int[] calificaciones = { 85, 92, 77, 68, 94 };
    //bool HayAprovados = Array.Exists(calificaciones, calif => calif => 60);
}
static void ejemplo6()
{
    int[] numeros = { 5, 8, 12, 3, 7 };
    int PrimerNumeroMayor = Array.Find(numeros, num => num > 8);
    Console.WriteLine(PrimerNumeroMayor);

}
ejemplo6();
