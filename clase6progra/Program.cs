while (true)
{
Console.WriteLine("Por Favor Seleccione que Conversion Desea Realizar:\n");
Console.WriteLine("1. Suma de elementos pares en un arreglo");
Console.WriteLine("2. invertir el orden de un arreglo");
Console.WriteLine("3. encontar el valor maximo de un arreglo");
Console.WriteLine("4. buscar elemnetos de un arreglo");
Console.WriteLine("5. ordenar el arreglo de orden asendente");
Console.WriteLine("6. Salir\n");

int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

switch (opcion)
{
case 1: // Suma
Ejercicio1();
break;
case 2: // Resta
Ejercicio2();
break;
case 3: // Multiplicacion
Ejercicio3();
break;
case 4: // Division
Ejercicio4();
break;
//case 5: // Modulo
//Ejercicio5();
//break;
case 6:
return;
default: // Opción Invalida
Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
break;
}
}

static void Ejercicio1()
{
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int sumaPares = SumarElementosPares(array);
    Console.WriteLine("los elementos son 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
    Console.WriteLine(" La suma de los elementos pares es: " + sumaPares);
}

static int SumarElementosPares(int[] arreglo)
{
    int suma = 0;
    foreach (int numero in arreglo)
    {
        if (numero % 2 == 0)
        {
            suma += numero;
        }
    }
    return suma;
}

static void Ejercicio2()
{
        int[] originalArray = { 1, 2, 3, 4, 5 };
int[] reversedArray = InvertirArreglo(originalArray);

Console.WriteLine("Arreglo original:");
ImprimirArreglo(originalArray);

Console.WriteLine("Arreglo invertido:");
ImprimirArreglo(reversedArray);
    }

    static int[] InvertirArreglo(int[] arreglo)
{
    int[] arregloInvertido = new int[arreglo.Length];

    for (int i = 0; i < arreglo.Length; i++)
    {
        arregloInvertido[i] = arreglo[arreglo.Length - 1 - i];
    }

    return arregloInvertido;
}

static void ImprimirArreglo(int[] arreglo)
{
    foreach (int elemento in arreglo)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}

static void Ejercicio3()
{
    int[] array = { 3, 7, 2, 8, 5 };
    int maximo = EncontrarMaximo(array);
    Console.WriteLine("Los numero del arreglo son 3, 7, 2, 8, 5");
    Console.WriteLine("El máximo valor en el arreglo es: " + maximo);
}

static int EncontrarMaximo(int[] arreglo)
{
    if (arreglo == null || arreglo.Length == 0)
    {
        throw new ArgumentException("El arreglo no puede estar vacío o nulo.");
    }

    int maximo = arreglo[0]; 

    for (int i = 1; i < arreglo.Length; i++) 
    {
        if (arreglo[i] > maximo)
        {
            maximo = arreglo[i];
        }
    }

    return maximo;
}

static void Ejercicio4()
{
    int[] array = { 3, 7, 2, 8, 5 };
    int valorABuscar = 8;
    int posicion = BuscarValor(array, valorABuscar);

    if (posicion != -1)
    {
        Console.WriteLine("El valor " + valorABuscar + " se encuentra en la posición " + posicion + " del arreglo.");
    }
    else
    {
        Console.WriteLine("El valor " + valorABuscar + " no se encuentra en el arreglo.");
    }
}

static int BuscarValor(int[] arreglo, int valorABuscar)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == valorABuscar)
        {
            return i; 
        }
    }

    return -1; 
}

//static void Ejercicio5()
//{
//    int[] array = { 3, 7, 2, 8, 5 };
//    int[] arrayOrdenado = OrdenarArreglo(array);

//    Console.WriteLine("Arreglo original:");
//    ImprimirArreglo(array);

//    Console.WriteLine("Arreglo ordenado:");
//    ImprimirArreglo(arrayOrdenado);
//}

//static int[] OrdenarArreglo(int[] arreglo)
//{
//    int[] arregloOrdenado = new int[arreglo.Length];
//    Array.Copy(arreglo, arregloOrdenado, arreglo.Length); 

//    Array.Sort(arregloOrdenado); 

//    return arregloOrdenado;
//}
//static void ImprimirArreglo(int[] arreglo)
//{
//    foreach (int elemento in arreglo)
//    {
//        Console.Write(elemento + " ");
//    }
//    Console.WriteLine();
//}
