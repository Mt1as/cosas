using System;

namespace Proyecto_CANTO
{
	class Program
	{
		struct Registro
		{
			public decimal Precio;

			/// <summary>
			/// Estado: 0 Desocupado, 1 Ocupado.
			/// </summary>
			public int Estado;

			public int DNI;

			public int Sexo;

			public int Edad;

		}

		static void Main(string[] args)
		{
			//Declaracion de la Matriz de Registro

			Registro[,] Asientos = new Registro[6, 10];

			ResetearAsientos(Asientos);

		

			string _opcion = "";
			//Creacion y carga del vectoc de precio de los pasajes

			decimal[] _PrecioPasaje = new decimal[3];
			_PrecioPasaje[0] = 500;
			_PrecioPasaje[1] = 200;
			_PrecioPasaje[2] = 100;

			Console.WriteLine("alla ura");
			Console.WriteLine("Facultad Regional del trula");
			Console.WriteLine("Tecnicatura Universitaria en Programación");
			Console.WriteLine("Cátedra de Programación I – 2019");
			Console.WriteLine("");
			Console.WriteLine("Segundo Taller ");
			Console.WriteLine("Ejercicio 2: Venta de pasajes aéreos");
			Console.WriteLine("");
			Console.WriteLine("Abel Fernandez");
			Console.WriteLine("DNI: 41276239");
			Console.WriteLine("abelfernandez550@gmail.com");
			Console.WriteLine("");
			Console.WriteLine("Matias Jose Ibañez Villafañe");
			Console.WriteLine("DNI: 41833080");
			Console.WriteLine("matukikoelenano@gmail.com");
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para comenzar...");

			Console.ReadKey();

			Console.Clear();

			do
			{
				Console.Clear();
				Console.WriteLine("**");
				Console.WriteLine("                                                           ");
				Console.WriteLine("                   Venta de pasajes aéreos                 ");
				Console.WriteLine("                                                           ");
				Console.WriteLine("  1)Comprar Asiento ");
				Console.WriteLine("  2) ");
				Console.WriteLine("  3)Mostrar cantidad asientos libres ");
				Console.WriteLine("  4) ");
				Console.WriteLine("  5) ");
				Console.WriteLine("  6) ");
			
				Console.WriteLine("Ingrese una opcion: ");
				_opcion = Console.ReadLine();
				


				switch (_opcion)
				{

					case "1":

						CargarAsiento(Asientos,_PrecioPasaje);


						break;

					case "2":

						

						break;


					case "3":

						CantidadAsientosL(Asientos);
						MostrarEstado(Asientos);
						Console.ReadKey();

						break;


					case "4":

						break;


					case "5":

						break;



					case "6":
						

						break;
					case "7":

						Console.WriteLine("Hasta Luego");
						Console.ReadKey();

						break;




				}





			} while (_opcion != "7");


		}

		private static void MostrarEstado(Registro[,] asientos)
		{
			for (int i = 0; i < asientos.GetLength(0); i++)
			{
				for (int j = 0; j < asientos.GetLength(1); j++)
				{

					Console.Write($" {asientos[i, j].Estado} ");

				}

				Console.WriteLine();
			}
			Console.ReadKey();
		}

		private static void CantidadAsientosL(Registro[,] asiento)
		{
			int clase = 0;
			int librec1 = 0;
			int ocupadoc1 = 0;
			int librec2 = 0;
			int ocupadoc2 = 0;
			int librec3 = 0;
			int ocupadoc3 = 0;





			for (int i = 0; i < asiento.GetLength(0); i++)
			{
				for (int j = 0; j <asiento.GetLength(1); j++)
				{

					clase = j;


					if (clase < 2)

					{
						if (asiento[i, j].Estado == 0)
						{
							librec1++;

						}
						else
						{
							ocupadoc1++;
						}

					}
					else if (clase < 5)
					{
						if (asiento[i, j].Estado == 0)
						{
							librec2++;

						}
						else
						{
							ocupadoc2++;
						}



					}
					else
					{
						if (asiento[i, j].Estado == 0)
						{
							librec3++;

						}
						else
						{
							ocupadoc3++;
						}


					}


				}

			}


			Console.WriteLine($"Primera Clase: ");
			Console.WriteLine($"Asientos Libres: {librec1.ToString("00")}");
			Console.WriteLine($"Asientos Ocupados: {ocupadoc1.ToString("00")}");
			Console.WriteLine();
			Console.WriteLine($"Clase Business: ");
			Console.WriteLine($"Asientos Libres: {librec2.ToString("00")}");
			Console.WriteLine($"Asientos Ocupados: {ocupadoc2.ToString("00")}");
			Console.WriteLine();
			Console.WriteLine($"Clase Turista: ");
			Console.WriteLine($"Asientos Libres: {librec3.ToString("00")}");
			Console.WriteLine($"Asientos Ocupados: {ocupadoc3.ToString("00")}");
			Console.WriteLine();


			Console.ReadKey();
		}

		private static void CargarAsiento(Registro[,] asiento, decimal[] precio)
		{
			int ubicacion = 0;
			Console.Clear();
			int[,] mat = new int[asiento.GetLength(0), asiento.GetLength(1)];
			int c = 0;
			

			for (int i = 0; i < asiento.GetLength(0); i++)
			{
				for (int j = 0; j < asiento.GetLength(1); j++)
				{

					mat[i, j] += c;

					c++;
				}
			}
			for (int i = 0; i < asiento.GetLength(0); i++)
			{
				for (int j = 0; j <asiento.GetLength(1); j++)
				{

					Console.Write($" {mat[i, j].ToString("00")} ");


				}
				Console.WriteLine();
			}

			Console.WriteLine("Ingrese la ubicacion del asiento: ");
			ubicacion = int.Parse(Console.ReadLine());

			int columna = 0;
			int filas = 0;
			int aux = ubicacion;
			decimal p = 0m;
			if (ubicacion > 9)
			{
				while (aux > 9)
				{

					filas++;
					aux -= 10;

				}
				columna = aux;
			}
			else
			{
				
				columna = ubicacion;

			}

			if (columna == 0 || columna == 1)
			{
				Console.WriteLine("PASAJE ASIENTO: PRIMERA CLASE");
				Console.WriteLine($"PRECIO: {precio[0]}");
				p = precio[0];
			
			}
			else if (columna == 2 || columna == 3 || columna == 4)
			{

				Console.WriteLine("PASAJE ASIENTO: BUSINESS");
				Console.WriteLine($"PRECIO: {precio[1]}");
				p = precio[1];

			}
			else
			{
				Console.WriteLine("PASAJE ASIENTO: TURISTA");
				Console.WriteLine($"PRECIO: {precio[2]}");
				p = precio[2];

			}


			for (int i = filas; i == filas; i++)
			{
				for (int j = columna; j == columna; j++)
				{
					if (asiento[i, j].Estado == 0)
					{
						Console.WriteLine("El Asiento esta DISPONIBLE");
						asiento[i, j].Estado = 1;

						Console.Write("Ingrese Numero de Documento: ");
						asiento[i, j].DNI = Int32.Parse(Console.ReadLine());

						Console.Write("Ingrese su Edad: ");
						asiento[i, j].Edad = Int32.Parse(Console.ReadLine());

						Console.Write("Ingrese su Sexo: Masculino/Femenino ");
						asiento[i, j].Sexo = int.Parse(Console.ReadLine());

						asiento[i, j].Precio = p;

					}
					else
					{
						Console.WriteLine("El Asiento esta OCUPADO");
					
					}
					

				}
			}

			

			Console.ReadKey();
			
			
		}

		

		private static void ResetearAsientos(Registro[,] Asientos)
		{
			for (int i = 0; i < Asientos.GetLength(0); i++)
			{
				for (int j = 0; j < Asientos.GetLength(1); j++)
				{

					Asientos[i, j].Estado = 0;
					
				}

			}
		}

		
	}
}
