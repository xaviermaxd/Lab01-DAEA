// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Console.WriteLine("Hello, World!");

//Persona persona = new Persona();
//persona.Nombres = "Xavier";
//persona.Apellidos = "Mamani";
//persona.Edad = 22;

//string NombresCompletos = persona.GetNombreCompleto();
//Console.WriteLine(NombresCompletos);
//Console.Read();

Grifo grifo = new Grifo();

while (true)
{
    Console.WriteLine("Selecciona una opción:");
    Console.WriteLine("1) Mostrar información de usuarios");
    Console.WriteLine("2) Agregar cliente");
    Console.WriteLine("3) Agregar empleado");
    Console.WriteLine("4) Salir");

    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            grifo.MostrarUsuarios();
            break;
        case 2:
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo del cliente:");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese los litros cargados por el cliente:");
            double litros = Convert.ToDouble(Console.ReadLine());
            grifo.AgregarUsuario(new Cliente(nombre, saldo, litros));
            break;
        case 3:
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombreE = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo del empleado:");
            double saldoE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            grifo.AgregarUsuario(new Empleado(nombreE, saldoE, sueldo));
            break;
        case 4:
            Console.WriteLine("Saliendo.");
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}