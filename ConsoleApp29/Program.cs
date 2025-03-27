using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
	namespace ConsoleApp25
	{
		public class Persona
		{
			public string nombre { get; set; }
			public int edad { get; set; }
			public string correo { get; set; }

			public override string ToString()
			{
				return $"Nombre: {nombre}, Edad: {edad}, Correo: {correo}";
			}
		}

		public class GestionDatos
		{
			static List<Persona> personas = new List<Persona>();

			static void Main(string[] args)
			{
				while (true)
				{
					Console.WriteLine("\nMenú:");
					Console.WriteLine("1. Agregar persona");
					Console.WriteLine("2. Ver personas");
					Console.WriteLine("3. Buscar persona");
					Console.WriteLine("4. Salir");
					Console.Write("Ingrese la opción: ");

					switch (Console.ReadLine())
					{
						case "1":
							AgregarPersona();
							break;
						case "2":
							VerPersonas();
							break;
						case "3":
							BuscarPersona();
							break;
						case "4":
							return;
						default:
							Console.WriteLine("Opción no válida.");
							break;
					}
				}
			}

			static void AgregarPersona()
			{
				Console.Write("Nombre: ");
				string nombre = Console.ReadLine();
				Console.Write("Edad: ");
				int edad = int.Parse(Console.ReadLine());
				Console.Write("Correo electrónico: ");
				string correo = Console.ReadLine();

				personas.Add(new Persona { nombre = nombre, edad = edad, correo = correo });
				Console.WriteLine("Persona agregada.");
			}

			static void VerPersonas()
			{
				if (personas.Count == 0)
				{
					Console.WriteLine("No hay personas registradas.");
					return;
				}

				foreach (var persona in personas)
				{
					Console.WriteLine(persona);
				}
			}

			static void BuscarPersona()
			{
				Console.Write("Ingrese el nombre a buscar: ");
				string nombreBuscar = Console.ReadLine();

				var resultados = personas.FindAll(p => p.nombre.Contains(nombreBuscar));

				if (resultados.Count == 0)
				{
					Console.WriteLine("No se encontraron coincidencias.");
					return;
				}

				foreach (var persona in resultados)
				{
					Console.WriteLine(persona);
				}
			}
		}
	}
}
