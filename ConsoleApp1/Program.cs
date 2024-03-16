// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
//Persona persona = new Persona();
//persona.Nombres = "Ana Cristina";
//persona.Nombres = "Ana Cristina";
//persona.Edad = 21;

//string NombresCompletos = persona.GetNombresCompletos();

//Console.WriteLine(NombresCompletos);
//Console.Read();


            Grifo grifo = new Grifo();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("i. Mostrar información de usuarios");
                Console.WriteLine("ii. Agregar cliente");
                Console.WriteLine("iii. Agregar empleado");
                Console.WriteLine("iv. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "i":
                        Console.WriteLine("Información de usuarios:");
                        grifo.MostrarUsuarios();
                        break;
                    case "ii":
                        Console.WriteLine("Ingrese el nombre del cliente:");
                        string nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el saldo del cliente:");
                        double saldoCliente = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese los litros cargados del cliente:");
                        double litrosCargadosCliente = Convert.ToDouble(Console.ReadLine());
                        Cliente nuevoCliente = new Cliente(nombreCliente, saldoCliente, litrosCargadosCliente);
                        grifo.AgregarUsuario(nuevoCliente);
                        Console.WriteLine("Cliente agregado exitosamente.");
                        break;
                    case "iii":
                        Console.WriteLine("Ingrese el nombre del empleado:");
                        string nombreEmpleado = Console.ReadLine();
                        Console.WriteLine("Ingrese el saldo del empleado:");
                        double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el sueldo del empleado:");
                        double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());
                        Empleado nuevoEmpleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                        grifo.AgregarUsuario(nuevoEmpleado);
                        Console.WriteLine("Empleado agregado exitosamente.");
                        break;
                    case "iv":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine();
            }