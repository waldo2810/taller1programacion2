using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<Estudiante> estudiantes = new List<Estudiante>();
                List<Profesor> profesores = new List<Profesor>();
                string nuevoValor;
                int nuevoValorInt;
                string buscarId;
                int datoMod;
                int opcion;
                int perfil;

                do
                {
                    Console.WriteLine("\nSeleccione su perfil: \n 1) Estudiante \n 2) Profesor \n 3) Salir");
                    Console.Write("---> ");
                    perfil = Convert.ToInt32(Console.ReadLine());

                    while (perfil > 3)
                    {
                        Console.WriteLine("Escriba una opcion valida");
                        Console.Write("---> ");
                        perfil = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Clear();
                    //ESTUDIANTE
                    if (perfil == 1)
                    {
                        do
                        {
                            Console.WriteLine("\n¿Qué acción desea realizar hoy?");
                            Console.WriteLine("1) Insertar usuario");
                            Console.WriteLine("2) Eliminar usuario");
                            Console.WriteLine("3) Modificar usuario");
                            Console.WriteLine("4) Mostrar usuarios");
                            Console.WriteLine("5) Menu principal");
                            Console.Write("\n---> ");

                            opcion = Convert.ToInt32(Console.ReadLine());

                            while (opcion > 5)
                            {
                                Console.WriteLine("Escoja una opción válida");
                                Console.Write("---> ");
                                opcion = Convert.ToInt32(Console.ReadLine());
                            }

                            switch (opcion)
                            {
                                case 1: //INSERTAR
                                    Console.Clear();
                                    for (int i = 0; i <= estudiantes.Count; i++)
                                    {
                                        Estudiante estudiante = new Estudiante();

                                        Console.Write("Escribir su identificacion: ");
                                        estudiante.identificacion = Console.ReadLine();
                                        Console.Write("Escribir su nombre: ");
                                        estudiante.nombre = Console.ReadLine();
                                        Console.Write("Escribir su apellido: ");
                                        estudiante.nombre = Console.ReadLine();
                                        Console.Write("Escribir su sexo: ");
                                        estudiante.sexo = Console.ReadLine();
                                        Console.Write("Escribir su edad: ");
                                        estudiante.edad = Console.ReadLine();
                                        Console.WriteLine("Escribir su facultad: \n 1) Ingenieria \n 2) Medicina \n 3) Ciencias Sociales \n 4) Ciencias Administrativas: ");
                                        estudiante.facultad = Convert.ToInt32(Console.ReadLine());

                                        while (estudiante.facultad > 4)
                                        {
                                            Console.WriteLine("Escoja una opción valida");
                                            Console.Write("\n---> ");
                                            estudiante.facultad = Convert.ToInt32(Console.ReadLine());
                                        }
                                        estudiante.settearFaculad(estudiante.facultad);

                                        estudiantes.Add(estudiante);
                                        break;
                                    }
                                    break;

                                case 2: //ELIMINAR
                                    Console.Clear();
                                    Console.Write("ID del usuario a eliminar: ");
                                    buscarId = Console.ReadLine();

                                    foreach (Estudiante estudiante in estudiantes.ToList())
                                    {
                                        if (estudiante.identificacion == buscarId)
                                        {
                                            estudiantes.Remove(estudiante);
                                            Console.WriteLine("Datos eliminados");
                                        }
                                        else
                                        {
                                            Console.WriteLine("No se han encontrado usuarios, intente de nuevo");
                                        }
                                    }
                                    break;

                                case 3: // MODIFICAR
                                    Console.Clear();
                                    Console.Write("ID del usuario a modificar: ");
                                    buscarId = Console.ReadLine();

                                    Console.WriteLine("Elija el dato a modificar \n 1. ID \n 2. Nombre \n 3. Apellido \n 4. Edad \n 5. Facultad");
                                    datoMod = Convert.ToInt32(Console.ReadLine());

                                    if (datoMod == 5)
                                    {
                                        Console.WriteLine("Recuerde: \n 1) Ingenieria \n 2) Medicina \n 3) Ciencias Sociales \n 4) Ciencias Administrativas");
                                        Console.Write("\nEscriba el nuevo valor: ");
                                        nuevoValor = Console.ReadLine();
                                        nuevoValorInt = Convert.ToInt32(nuevoValor);

                                        while (nuevoValorInt > 4)
                                        {
                                            Console.WriteLine("Escoja una opción valida");
                                            Console.Write("\n---> ");
                                            nuevoValorInt = Convert.ToInt32(Console.ReadLine());
                                            nuevoValor = Convert.ToString(nuevoValorInt);
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("Escriba el nuevo valor: ");
                                        nuevoValor = Console.ReadLine();
                                    }

                                    foreach (Estudiante estudiante in estudiantes)
                                    {
                                        if (estudiante.identificacion == buscarId)
                                        {
                                            switch (datoMod)
                                            {
                                                case 1:
                                                    estudiante.identificacion = nuevoValor;
                                                    break;
                                                case 2:
                                                    estudiante.nombre = nuevoValor;
                                                    break;
                                                case 3:
                                                    estudiante.apellido = nuevoValor;
                                                    break;
                                                case 4:
                                                    estudiante.edad = nuevoValor;
                                                    break;
                                                case 5:
                                                    estudiante.facultad = Convert.ToInt32(nuevoValor);
                                                    estudiante.settearFaculad(estudiante.facultad);
                                                    break;
                                            }
                                        }
                                    }
                                    break;

                                case 4: //MOSTRAR
                                    foreach (Estudiante estudiante in estudiantes)
                                    {
                                        Console.WriteLine("\nESTUDIANTE:");
                                        Console.WriteLine("Identificacion: " + estudiante.identificacion);
                                        Console.WriteLine("Nombre: " + estudiante.nombre);
                                        Console.WriteLine("Apellido: " + estudiante.apellido);
                                        Console.WriteLine("Edad: " + estudiante.edad);
                                        Console.WriteLine("Sexo: " + estudiante.sexo);
                                        Console.WriteLine("Facultad: " + estudiante.nombreFacultad);
                                    }
                                    break;

                                case 5:
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Escoja una opcion valida");
                                    break;
                            } //SWITCH
                            opcion = 5;
                        } while (opcion != 5);
                    }
                    //PROFESOR
                    if (perfil == 2)
                    {
                        Console.WriteLine("\n¿Qué acción desea realizar hoy?");
                        Console.WriteLine("1) Insertar usuario");
                        Console.WriteLine("2) Eliminar usuario");
                        Console.WriteLine("3) Modificar usuario");
                        Console.WriteLine("4) Mostrar usuarios");
                        Console.WriteLine("5) Menu princiapal");
                        Console.Write("\n---> ");

                        opcion = Convert.ToInt32(Console.ReadLine());

                        while (opcion > 5)
                        {
                            Console.WriteLine("Escoja una opción válida");
                            Console.Write("---> ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                        }
                        switch (opcion)
                        {
                            case 1: //INSERTAR
                                Console.Clear();
                                for (int i = 0; i <= profesores.Count; i++)
                                {
                                    Profesor profesor = new Profesor();

                                    Console.Write("Escribir su identificacion: ");
                                    profesor.identificacion = Console.ReadLine();
                                    Console.Write("Escribir su nombre: ");
                                    profesor.nombre = Console.ReadLine();
                                    Console.Write("Escribir su apellido: ");
                                    profesor.nombre = Console.ReadLine();
                                    Console.Write("Escribir su sexo: ");
                                    profesor.sexo = Console.ReadLine();
                                    Console.Write("Escribir su fecha de ingreso");
                                    profesor.f_ingreso = Console.ReadLine();
                                    Console.Write("Escribir nivel academico");
                                    profesor.n_academico = Console.ReadLine();
                                    Console.Write("Escribir su universidad");
                                    profesor.universidad = Console.ReadLine();
                                    Console.Write("Escribir año de culminacion");
                                    profesor.a_culminacion = Console.ReadLine();

                                    profesores.Add(profesor);
                                    break;
                                }
                                break;

                            case 2: //ELIMINAR
                                Console.Clear();
                                Console.Write("ID del usuario a eliminar: ");
                                buscarId = Console.ReadLine();

                                foreach (Profesor profesor in profesores.ToList())
                                {
                                    if (profesor.identificacion == buscarId)
                                    {
                                        profesores.Remove(profesor);
                                        Console.WriteLine("Datos eliminados");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se han encontrado usuarios, intente de nuevo");
                                    }
                                }
                                break;

                            case 3: // MODIFICAR
                                Console.Clear();
                                Console.Write("ID del usuario a modificar: ");
                                buscarId = Console.ReadLine();

                                Console.WriteLine("Elija el dato a modificar \n 1. ID \n 2. Nombre \n 3. Apellido \n 4. Edad \n 5. fecha de ingreso \n 6) nivel academico \n 7) año de culminacion");
                                datoMod = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Escriba el nuevo valor: ");
                                nuevoValor = Console.ReadLine();

                                foreach (Profesor profesor in profesores)
                                {
                                    if (profesor.identificacion == buscarId)
                                    {
                                        switch (datoMod)
                                        {
                                            case 1:
                                                profesor.identificacion = nuevoValor;
                                                break;
                                            case 2:
                                                profesor.nombre = nuevoValor;
                                                break;
                                            case 3:
                                                profesor.apellido = nuevoValor;
                                                break;
                                            case 4:
                                                profesor.f_ingreso = nuevoValor;
                                                break;
                                            case 5:
                                                profesor.n_academico = nuevoValor;
                                                break;
                                            case 6:
                                                profesor.universidad = nuevoValor;
                                                break;
                                            case 7:
                                                profesor.a_culminacion = nuevoValor;
                                                break;
                                        }
                                    }
                                }
                                break;

                            case 4: //MOSTRAR
                                foreach (Profesor profesor in profesores)
                                {
                                    Console.WriteLine("\nPROFESOR:");
                                    Console.WriteLine("Identificacion: " + profesor.identificacion);
                                    Console.WriteLine("Nombre: " + profesor.nombre);
                                    Console.WriteLine("Apellido: " + profesor.apellido);
                                    Console.WriteLine("Fecha de ingreso: " + profesor.f_ingreso);
                                    Console.WriteLine("Nivel academico: " + profesor.n_academico);
                                    Console.WriteLine("Universidad: " + profesor.universidad);
                                    Console.WriteLine("Año de culminacion: " + profesor.a_culminacion);
                                }
                                break;

                            case 5:
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("ESCOJA UNA OPCION VALIDA >:v");
                                break;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("\nAcción realizada\n1) Continuar \n3) Salir (y luego presione cualquier tecla)");
                    Console.Write("---> ");
                    perfil = Convert.ToInt32(Console.ReadLine());

                } while (perfil != 3);
            }
            Console.ReadKey();
        }
    }
}