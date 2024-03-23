static void ejemplo1()
{
    int[] calificaciones;
    {
        calificaciones = new int[] { 85, 77, 68, 94, 75 };
        Console.WriteLine(calificaciones[2]);
    }
}
{
    ejemplo1();
}
static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "juan";
    nombres[1] = "ana";
    nombres[2] = "pedro";

    foreach (string nombre in nombres)
    {
        Console.WriteLine("nombre=" + nombre);
    }
}
{

    ejemplo2();

}


static void promedios()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int suma = 0;

    foreach (int nota in notas)
        suma = suma + nota;
    {
        Console.WriteLine("promedio=" + suma / 6);
    }
}

{ promedios(); }
