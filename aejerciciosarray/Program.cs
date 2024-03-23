while (true)
{
Console.WriteLine("Por Favor Seleccione que Programa quiere:\n");
Console.WriteLine("1. Lista de Nombres");
Console.WriteLine("2. Niumero Maximo y Minimo");
Console.WriteLine("3. Lista de Pises");
Console.WriteLine("4. Numeros Enteros");
Console.WriteLine("5. Lista de Calificaciones");
Console.WriteLine("6. Salir\n");

int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

switch (opcion)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 6:
            return;
default: // Opción Invalida
Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
break;
}
}

static void Ejercicio1()
{
    Console.WriteLine("Ingrese una lista de nombres separados por comas:");
    string input = Console.ReadLine();

    string[] nombres = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

    Array.Sort(nombres);

    Console.WriteLine("Lista de nombres ordenada:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre.Trim()); 
    }
}

static void Ejercicio2()
{
    Console.WriteLine("Ingrese una lista de números enteros separados por comas:");
    string input = Console.ReadLine();


    string[] numerosString = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


    int[] numeros = Array.ConvertAll(numerosString, int.Parse);


    int maximo = Array.Max(numeros);
    int minimo = Array.MIn(numeros);


    Console.WriteLine("El valor máximo es: " + maximo);
    Console.WriteLine("El valor mínimo es: " + minimo);
}

static void Ejercicio3()
{
    
    string[] paises = { "Estados Unidos", "Canadá", "México", "Brasil", "Argentina", "Chile", "Perú", "España", "Francia", "Alemania" };

    Console.WriteLine("Ingrese un nombre de país:");
    string paisBuscado = Console.ReadLine();

    int indice = Array.IndexOf(paises, paisBuscado);

    if (indice != -1)
    {
        Console.WriteLine("El país \"" + paisBuscado + "\" fue encontrado en el índice " + indice + " del arreglo.");
    }
    else
    {
        Console.WriteLine("El país \"" + paisBuscado + "\" no fue encontrado en el arreglo.");
    }
}


static void Ejercicio4()
{
    int[] arreglo = { 1, 2, 3, 4, 5 };

    // Mostrar el arreglo original
    Console.WriteLine("Arreglo original:");
    ImprimirArreglo(arreglo);

    // Utilizar Array.Reverse() para invertir el orden de los elementos
    Array.Reverse(arreglo);

    // Mostrar el arreglo invertido
    Console.WriteLine("Arreglo invertido:");
    ImprimirArreglo(arreglo);
}

static void ImprimirArreglo(int[] arreglo)
{
    foreach (int elemento in arreglo)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}

static void Ejercicio5()
{
    // Solicitar al usuario ingresar una lista de calificaciones numéricas
    Console.WriteLine("Ingrese una lista de calificaciones numéricas separadas por comas:");
    string input = Console.ReadLine();

    // Dividir la entrada en calificaciones individuales
    string[] calificacionesString = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

    // Convertir las calificaciones de tipo string a tipo int
    int[] calificaciones = Array.ConvertAll(calificacionesString, int.Parse);

    // Verificar si al menos una calificación es mayor o igual a 90 (sobresaliente)
    bool haySobresalientes = Array.Exists(calificaciones, calificacion => calificacion >= 90);

    // Mostrar un mensaje indicando si hay calificaciones sobresalientes o no
    if (haySobresalientes)
    {
        Console.WriteLine("Hay calificaciones sobresalientes.");
    }
    else
    {
        Console.WriteLine("No hay calificaciones sobresalientes.");
    }
}