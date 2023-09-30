namespace ProyectoLaboratorio
    //Ponin Eric. DNI: 32586510
{   //Legajo: 903149
    using System;
    using System.IO;
    using System.Security;

    internal class Program
    {
        struct Alumno_Materias
        {
            public string Indice;
            public string IndiceAlumno;
            public string IndiceMateria;
            public string IndiceCarrera;
            public bool Estado;
            public string Nota;
            public string Fecha;

        }
        struct Carrera_Alumno
        {
            public string Indice;
            public string IndiceAlumno;
            public string IndiceCarrera;
            public bool EstaActiva;

        }
        struct Carrera_Materia
        {
            public string Indice;
            public string Plan;
            public string IndiceMateria;
            public string IndiceCarrera;
            public bool EstaActiva;

        }
        struct Materia
        {
            public string Indice;
            public string NombreMateria;
            public bool EstaActiva;

        }
        struct Carrera
        {
            public string Indice;
            public string NombreCarrera;
            public bool EstaActiva;

        }
        struct Alumno
        {
            public string Indice;
            public string Nombre;
            public string Apellido;
            public string DNI;
            public string FechaNa;
            public string Domicilio;
            public bool EstaActivo;
        }
        static void Main(string[] args)
        {
            string rutaArchivoAlumnos = @"C:\Users\Eric\Desktop\ProyectoLabo\Alumnos.txt";
            string rutaArchivoCarreras = @"C:\Users\Eric\Desktop\ProyectoLabo\Carreras.txt";
            string rutaArchivoMaterias = @"C:\Users\Eric\Desktop\ProyectoLabo\Materias.txt";
            string rutaArchivoCarreraMaterias = @"C:\Users\Eric\Desktop\ProyectoLabo\CarreraMaterias.txt";
            string rutaArchivoCarreraAlumno = @"C:\Users\Eric\Desktop\ProyectoLabo\CarreraAlumno.txt";
            string rutaArchivoAlumnoMateria = @"C:\Users\Eric\Desktop\ProyectoLabo\AlumnoMateria.txt";
            string opcion;
            do
            {
                MenuPrincipal();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AdminAlumnos(rutaArchivoAlumnos);
                        break;
                    case "2":
                        AdminCarreras(rutaArchivoCarreras);
                        break;
                    case "3":
                        AdminMaterias(rutaArchivoMaterias);
                        break;
                    case "4":
                        AdminRelaciones(rutaArchivoAlumnos, rutaArchivoCarreras, rutaArchivoMaterias, rutaArchivoCarreraMaterias, rutaArchivoCarreraAlumno, rutaArchivoAlumnoMateria);
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del Programa..");

                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta..");
                        break;
                }

                Console.Clear();

            } while (opcion != "0");
        }
        static void AdminRelaciones(string rutaArchivoAlumnos, string rutaArchivoCarreras, string rutaArchivoMaterias, string rutaArchivoCarreraMaterias, string rutaArchivoCarreraAlumno, string rutaArchivoAlumnoMateria)
        {
            string opcion;
            do
            {
                menuRelaciones();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CarreraMateria(rutaArchivoCarreras, rutaArchivoMaterias, rutaArchivoCarreraMaterias);
                        break;
                    case "2":
                        CarreraAlumno(rutaArchivoAlumnos, rutaArchivoCarreras, rutaArchivoCarreraAlumno);
                        break;
                    case "3":
                        AlumnoMaterias(rutaArchivoCarreraAlumno, rutaArchivoCarreraMaterias, rutaArchivoAlumnoMateria);
                        break;
                    case "0":
                        Console.WriteLine("Volviendo al Menu Principal..");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta..");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != "0");
        }
        static void AdminMaterias(string ruta)
        {
            string opcion;
            do
            {
                menuMaterias();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AltaMateria(ruta);
                        break;
                    case "2":
                        BajaMateria(ruta);
                        break;
                    case "3":
                        ModificacionMateria(ruta);
                        break;
                    case "0":
                        Console.WriteLine("Volviendo al Menu Principal..");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta..");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != "0");
        }
        static void AdminCarreras(string ruta)
        {
            string opcion;
            do
            {
                menuCarreras();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AltaCarrera(ruta);
                        break;
                    case "2":
                        BajaCarrera(ruta);
                        break;
                    case "3":
                        ModificacionCarrera(ruta);
                        break;
                    case "0":
                        Console.WriteLine("Volviendo al Menu Principal..");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta..");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != "0");
        }
        static void AdminAlumnos(string ruta)
        {
            string opcion;
            do
            {
                menuAlumnos();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AltaAlumno(ruta);
                        break;
                    case "2":
                        BajaAlumno(ruta);
                        break;
                    case "3":
                        ModificacionAlumno(ruta);
                        break;
                    case "4":
                        MostrarAlumnos(ruta);
                        break;
                    case "0":
                        Console.WriteLine("Volviendo al Menu Principal..");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta..");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (opcion != "0");
        }
        static void MenuPrincipal()
        {
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **---------        MENU PRINCIPAL         ------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **--------- 1 * ADMINISTRACION DE ALUMNOS    ---**");
            Console.WriteLine("                                 **--------- 2 * ADMINISTRACION DE CARRERAS   ---**");
            Console.WriteLine("                                 **--------- 3 * ADMINISTRACION DE MATERIAS   ---**");
            Console.WriteLine("                                 **--------- 4 * ADMINISTRACION DE RELACIONES ---**");
            Console.WriteLine("                                 **--------- 0 * SALIR DEL PROGRAMA           ---**");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine();
            Console.Write("Ingrese una Opcion: ");
        }

        static void menuRelaciones()
        {
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **------        MENU RELACIONES            -----**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **--------- 1 * ASOCIAR MATERIA A CARRERA ------**");
            Console.WriteLine("                                 **--------- 2 * ASOCIAR CARRERA A ALUMNO  ------**");
            Console.WriteLine("                                 **--------- 3 * ASOCIAR ALUMNO A MATERIAS ------**");
            Console.WriteLine("                                 **--------- 0 * VOLVER AL MENU PRINCIPAL  ------**");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine();
            Console.Write("Ingrese una Opcion: ");
        }
        static void menuMaterias()
        {
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **------ ADMINISTRACION MATERIAS DE LA UTN -----**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **--------- 1 * ALTA DE MATERIAS          ------**");
            Console.WriteLine("                                 **--------- 2 * BAJA DE MATERIAS          ------**");
            Console.WriteLine("                                 **--------- 3 * MODIFICACION DE MATERIAS  ------**");
            Console.WriteLine("                                 **--------- 0 * VOLVER AL MENU PRINCIPAL  ------**");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine();
            Console.Write("Ingrese una Opcion: ");
        }
        static void menuCarreras()
        {
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **------ ADMINISTRACION CARRERAS DE LA UTN -----**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **--------- 1 * ALTA DE CARRERAS          ------**");
            Console.WriteLine("                                 **--------- 2 * BAJA DE CARRERAS          ------**");
            Console.WriteLine("                                 **--------- 3 * MODIFICACION DE CARRERAS  ------**");
            Console.WriteLine("                                 **--------- 0 * VOLVER AL MENU PRINCIPAL  ------**");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine();
            Console.Write("Ingrese una Opcion: ");
        }
        static void menuAlumnos()
        {
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **--------- ADMINISTRACION DE ALUMNOS UTN ------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **--------- 1 * ALTA DE ALUMNOS          -------**");
            Console.WriteLine("                                 **--------- 2 * BAJA DE ALUMNOS          -------**");
            Console.WriteLine("                                 **--------- 3 * MODIFICACION DE ALUMNOS  -------**");
            Console.WriteLine("                                 **--------- 4 * VER ALUMNOS              -------**");
            Console.WriteLine("                                 **--------- 0 * VOLVER AL MENU PRINCIPAL -------**");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine();
            Console.Write("Ingrese una Opcion: ");
        }

        static string FechaValida(string cartel)
        {
            string fecha;
            bool fechaValidada;
            DateTime date;
            do
            {
                Console.Write(cartel);
                fecha = Console.ReadLine();
                fechaValidada = DateTime.TryParse(fecha, out date);
                if (fechaValidada != true)
                {
                    Console.WriteLine("Fecha incorrecta.. intentelo nuevamente");
                }
            } while (fechaValidada != true);

            return fecha;
        }
        static bool ingresoOpcion(string cartel)
        {
            string opcion = "";
            bool op = false;
            do
            {
                Console.Write(cartel);
                opcion = Console.ReadLine();
            } while (opcion != "no" && opcion != "No" && opcion != "nO" && opcion != "NO" && opcion != "si" && opcion != "Si" && opcion != "sI" && opcion != "SI");
            if (opcion == "no" || opcion == "No" || opcion == "nO" || opcion == "NO")
            {
                op = false;
            }
            else
            {
                op = true;
            }

            return op;
        }
        static bool AlumnoExistente(string rutaArchivoAlumnos, ref string DniBuscado)
        {
            List<Alumno> ModiAlumno = new List<Alumno>();
            bool encontrado = false;
            DniBuscado = NumeroValido("Ingrese DNI del Alumno a Cargar: ");
            LeerArchivo(rutaArchivoAlumnos, ModiAlumno);

            for (int i = 0; i < ModiAlumno.Count; i++)
            {
                if (ModiAlumno[i].DNI == DniBuscado)
                {
                    encontrado = true;
                    if (ModiAlumno[i].EstaActivo == false)
                    {
                        ModiAlumno[i] = new Alumno
                        {
                            Indice = ModiAlumno[i].Indice,
                            Nombre = ModiAlumno[i].Nombre,
                            Apellido = ModiAlumno[i].Apellido,
                            DNI = ModiAlumno[i].DNI,
                            FechaNa = ModiAlumno[i].FechaNa,
                            Domicilio = ModiAlumno[i].Domicilio,
                            EstaActivo = ingresoOpcion("Alumno Existente Inactivo, Lo Activa?(Si/No): ")
                        };
                    }
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No se encontró ningún alumno con el DNI especificado.");
            }
            else
            {
                GrabarArchivo(rutaArchivoAlumnos, ModiAlumno);
            }
            return encontrado;
        }
        static void IngresoAlumno(string rutaArchivo, ref Alumno ListaAlumno, ref string DniBuscado)
        {
            ListaAlumno.Indice = NumeroValido("Ingrese Indice del alumno: ");
            Console.Write("Ingrese Nombre de Alumno: ");
            ListaAlumno.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido de Alumno: ");
            ListaAlumno.Apellido = Console.ReadLine();
            ListaAlumno.DNI = DniBuscado;
            ListaAlumno.FechaNa = FechaValida("Ingrese Fecha de Nacimineto(DD/MM/AAAA): ");
            Console.Write("Ingrese Domicilio de Alumno: ");
            ListaAlumno.Domicilio = Console.ReadLine();
            Console.Write("Alumno Activo? ");
            ListaAlumno.EstaActivo = ingresoOpcion("(si / no):");
        }
        static void AltaAlumno(string rutaArchivo)
        {
            string DniBuscado = "";
            if (AlumnoExistente(rutaArchivo, ref DniBuscado))
            {
                Console.WriteLine("Alumno existente Activo! Volviendo..");
            }
            else
            {
                List<Alumno> NuevoAlumno = new List<Alumno>();
                Alumno nuevo = new Alumno();

                while (ingresoOpcion("Se cargaran los Datos de un nuevo alumno, continua?(si / no): "))
                {
                    IngresoAlumno(rutaArchivo, ref nuevo, ref DniBuscado);
                    NuevoAlumno.Add(nuevo);

                }

                bool concateno = true;
                try
                {
                    StreamWriter escribir = new StreamWriter(rutaArchivo, concateno);

                    foreach (var item in NuevoAlumno)
                    {
                        escribir.Write(item.Indice + ",");
                        escribir.Write(item.Nombre + ",");
                        escribir.Write(item.Apellido + ",");
                        escribir.Write(item.DNI + ",");
                        escribir.Write(item.FechaNa + ",");
                        escribir.Write(item.Domicilio + ",");
                        escribir.Write(item.EstaActivo + ",");
                        escribir.WriteLine();
                    }

                    escribir.Close();
                    Console.WriteLine("Saliendo..");
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Hubo un error con el archivo.. {error.Message}");
                }
            }
        }

        static void ModificacionAlumno(string rutaArchivoAlumnos)
        {
            List<Alumno> ModiAlumno = new List<Alumno>();
            bool nuevoEstado;
            string DniBuscado;
            bool encontrado = false;

            DniBuscado = NumeroValido("Ingrese DNI del alumno que desea Modificar: ");

            LeerArchivo(rutaArchivoAlumnos, ModiAlumno);

            for (int i = 0; i < ModiAlumno.Count; i++)
            {
                if (ModiAlumno[i].DNI == DniBuscado)
                {
                    encontrado = true;
                    Console.Write($"Nombre Actual: - {ModiAlumno[i].Nombre} - Nuevo nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.Write($"Apellido Actual: - {ModiAlumno[i].Apellido} - Nuevo Apellido: ");
                    string nuevoApellido = Console.ReadLine();
                    Console.Write($"DNI Actual: - {ModiAlumno[i].DNI} - Nuevo DNI: ");
                    string nuevoDNI = Console.ReadLine();
                    Console.Write($"Fecha de Nacimiento Actual: - {ModiAlumno[i].FechaNa} - Nueva Fecha de nacimiento: ");
                    string nuevaFechaNa = FechaValida("DD/MM/AAAA): ");
                    Console.Write($"Domicilio Actual: - {ModiAlumno[i].Domicilio} - Nuevo Domicilio: ");
                    string nuevoDomicilio = Console.ReadLine();
                    Console.WriteLine($"Estado Actual: - {ModiAlumno[i].EstaActivo} - Nuevo Estado: ");
                    nuevoEstado = ingresoOpcion("Si: Para Activar / No: Para Desactivar:");

                    ModiAlumno[i] = new Alumno
                    {
                        Indice = ModiAlumno[i].Indice,
                        Nombre = nuevoNombre,
                        Apellido = nuevoApellido,
                        DNI = nuevoDNI,
                        FechaNa = nuevaFechaNa,
                        Domicilio = nuevoDomicilio,
                        EstaActivo = nuevoEstado,
                    };
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún alumno con el DNI especificado.");
            }
            else
            {
                GrabarArchivo(rutaArchivoAlumnos, ModiAlumno);
            }
        }
        static void GrabarArchivo(string rutaArchivo, List<Alumno> Alu)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);
                foreach (var alumno in Alu)
                {
                    escritor.Write(alumno.Indice + ",");
                    escritor.Write(alumno.Nombre + ",");
                    escritor.Write(alumno.Apellido + ",");
                    escritor.Write(alumno.DNI + ",");
                    escritor.Write(alumno.FechaNa + ",");
                    escritor.Write(alumno.Domicilio + ",");
                    escritor.Write(alumno.EstaActivo + ",");
                    escritor.WriteLine();
                }
                escritor.Close();

                Console.WriteLine("Los cambios se han guardado correctamente en el archivo.");
            }

            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }
        static void LeerArchivo(string rutaArchivo, List<Alumno> Alu)
        {
            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    Alumno alumno = new Alumno();
                    alumno.Indice = campos[0];
                    alumno.Nombre = campos[1];
                    alumno.Apellido = campos[2];
                    alumno.DNI = campos[3];
                    alumno.FechaNa = campos[4];
                    alumno.Domicilio = campos[5];
                    alumno.EstaActivo = bool.Parse(campos[6]);

                    linea = lector.ReadLine();
                    Alu.Add(alumno);
                }
                lector.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }
        }
        static void BajaAlumno(string rutaArchivoAlumnos)
        {
            List<Alumno> BajaAlumno = new List<Alumno>();
            string DniBuscado;
            DniBuscado = NumeroValido("Ingrese DNI del Alumno que desea Borrar: ");
            LeerArchivo(rutaArchivoAlumnos, BajaAlumno);
            for (int i = 0; i < BajaAlumno.Count; i++)
            {
                if (BajaAlumno[i].DNI == DniBuscado)
                {
                    if (BajaAlumno[i].EstaActivo == true)
                    {

                        BajaAlumno[i] = new Alumno
                        {
                            Indice = BajaAlumno[i].Indice,
                            Nombre = BajaAlumno[i].Nombre,
                            Apellido = BajaAlumno[i].Apellido,
                            DNI = BajaAlumno[i].DNI,
                            FechaNa = BajaAlumno[i].FechaNa,
                            Domicilio = BajaAlumno[i].Domicilio,
                            EstaActivo = !ingresoOpcion($"Desea Dar de Baja al Alumno: {BajaAlumno[i].Nombre} {BajaAlumno[i].Apellido} (Si / No): ")
                        };
                    }
                    else
                    {
                        Console.WriteLine("El Alumno ya esta desactivado..");
                    }
                }

            }

            GrabarArchivo(rutaArchivoAlumnos, BajaAlumno);

        }
        static void MostrarAlumnos(string rutaArchivo)
        {
            List<Alumno> MostrarAlumno = new List<Alumno>();

            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **--------- ADMINISTRACION DE ALUMNOS UTN ------**");
            Console.WriteLine("                                 **************************************************");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.WriteLine("                                 **--------- 1 * ALUMNOS ACTIVOS          -------**");
            Console.WriteLine("                                 **--------- 2 * ALUMNOS INACTIVOS        -------**");
            Console.WriteLine("                                 **----------------------------------------------**");
            Console.Write("Ingrese una Opcion: ");

            string opcion;

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    LeerArchivo(rutaArchivo, MostrarAlumno);
                    Console.WriteLine("  Alumnos Activos: ");
                    for (int i = 0; i < MostrarAlumno.Count; i++)
                    {
                        if (MostrarAlumno[i].EstaActivo == true)
                        {
                            Console.WriteLine($"Alumno {MostrarAlumno[i].Apellido} {MostrarAlumno[i].Nombre} DNI: {MostrarAlumno[i].DNI}");
                        }
                    }
                    break;
                case "2":
                    LeerArchivo(rutaArchivo, MostrarAlumno);
                    Console.WriteLine("Alumnos Inactivos: ");
                    for (int i = 0; i < MostrarAlumno.Count; i++)
                    {
                        if (MostrarAlumno[i].EstaActivo == false)
                        {
                            Console.WriteLine($"Alumno {MostrarAlumno[i].Apellido} {MostrarAlumno[i].Nombre} DNI: {MostrarAlumno[i].DNI}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    break;
            }

        }
        static string NumeroValido(string Cartel)
        {
            string numeroCadena = "";
            int Numero = 0;
            bool Valido = false;
            do
            {
                Console.Write(Cartel);
                numeroCadena = Console.ReadLine();
                Valido = int.TryParse(numeroCadena, out Numero);
                if (!Valido)
                {
                    Console.WriteLine("Numero incorrecto, Intentelo nuevamente..");
                }
            } while (!Valido);

            return numeroCadena;
        }


        /*------------------------------------------------------------------       CARRERAS      -----------------------------------------------------------------------------------------------*/
        static void IngresoCarrera(string rutaArchivo, ref Carrera ListaCarrera)
        {

            Console.Write("Ingrese Numero Unico de Carrera: ");
            ListaCarrera.Indice = Console.ReadLine();
            Console.Write("Ingrese Nombre de la Carrera: ");
            ListaCarrera.NombreCarrera = Console.ReadLine();
            Console.Write("Carrera Activa? ");
            ListaCarrera.EstaActiva = ingresoOpcion("(Si/No):");
        }
        static void AltaCarrera(string rutaArchivo)
        {
            if (CarreraExistente(rutaArchivo))
            {
                Console.WriteLine("Carrera Ya Existente..");
            }
            else
            {
                List<Carrera> NuevaCarrera = new List<Carrera>();
                Carrera nueva = new Carrera();

                while (ingresoOpcion("Se cargaran los Datos de una nueva Carrera, continua?(si / no): "))
                {
                    IngresoCarrera(rutaArchivo, ref nueva);
                    NuevaCarrera.Add(nueva);
                }

                bool concateno = true;
                try
                {
                    StreamWriter escribir = new StreamWriter(rutaArchivo, concateno);

                    foreach (var item in NuevaCarrera)
                    {
                        escribir.Write(item.Indice + ",");
                        escribir.Write(item.NombreCarrera + ",");
                        escribir.Write(item.EstaActiva + ",");
                        escribir.WriteLine();
                    }
                    escribir.Close();
                    Console.WriteLine("Saliendo..");
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Hubo un error con el archivo.. {error.Message}");
                }
            }
        }

        static bool CarreraExistente(string rutaArchivoCarreras)
        {
            List<Carrera> ModiCarrera = new List<Carrera>();
            string ID;
            bool encontrado = false;
            ID = NumeroValido("Ingrese INDICE de la Carrera a Cargar: ");
            LeerArchivoCarrera(rutaArchivoCarreras, ModiCarrera);

            for (int i = 0; i < ModiCarrera.Count; i++)
            {
                if (ModiCarrera[i].Indice == ID)
                {
                    encontrado = true;
                    if (ModiCarrera[i].EstaActiva == false)
                    {
                        ModiCarrera[i] = new Carrera
                        {
                            Indice = ModiCarrera[i].Indice,
                            NombreCarrera = ModiCarrera[i].NombreCarrera,
                            EstaActiva = ingresoOpcion("Carrera Existente Inactiva, La Activa?(Si/No): ")
                        };
                    }
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No se encontró ningúna Carrera con el ID especificado.");
            }
            else
            {
                GrabarArchivoCarrera(rutaArchivoCarreras, ModiCarrera);
            }
            return encontrado;
        }
        static void LeerArchivoCarrera(string rutaArchivo, List<Carrera> Car)
        {
            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    Carrera carrera = new Carrera();
                    carrera.Indice = campos[0];
                    carrera.NombreCarrera = campos[1];
                    carrera.EstaActiva = bool.Parse(campos[2]);

                    linea = lector.ReadLine();
                    Car.Add(carrera);
                }
                lector.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }
        }
        static void GrabarArchivoCarrera(string rutaArchivo, List<Carrera> Car)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);
                foreach (var carrera in Car)
                {
                    escritor.Write(carrera.Indice + ",");
                    escritor.Write(carrera.NombreCarrera + ",");
                    escritor.Write(carrera.EstaActiva + ",");
                    escritor.WriteLine();
                }
                escritor.Close();

                Console.WriteLine("Los cambios se han guardado correctamente en el archivo.");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }
        }
        static void ModificacionCarrera(string rutaArchivoCarreras)
        {
            List<Carrera> ModiCarrera = new List<Carrera>();
            bool nuevoEstado;
            string ID;
            bool encontrado = false;
            LeerArchivoCarrera(rutaArchivoCarreras, ModiCarrera);
            Console.WriteLine("Carreras en la UTN: ");
            for (int i = 0; i < ModiCarrera.Count; i++)
            {
                Console.WriteLine($"Indice: {ModiCarrera[i].Indice} Carrera: {ModiCarrera[i].NombreCarrera} ");
            }

            ID = NumeroValido("Ingrese INDICE de la Carrera a Modificar: ");

            for (int i = 0; i < ModiCarrera.Count; i++)
            {

                if (ModiCarrera[i].Indice == ID)
                {
                    encontrado = true;
                    Console.Write($"Indice Actual: - {ModiCarrera[i].Indice} - Nuevo Indice: ");
                    string nuevoIndice = Console.ReadLine();
                    Console.Write($"Nombre Actual: - {ModiCarrera[i].NombreCarrera} - Nuevo Nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.WriteLine($"Estado Actual: - {ModiCarrera[i].EstaActiva} - Nuevo Estado: ");
                    nuevoEstado = ingresoOpcion("Si: Para Activar / No: Para Desactivar:");

                    ModiCarrera[i] = new Carrera
                    {
                        Indice = nuevoIndice,
                        NombreCarrera = nuevoNombre,
                        EstaActiva = nuevoEstado,
                    };
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningúna Carrera con el ID especificado.");
            }
            else
            {
                GrabarArchivoCarrera(rutaArchivoCarreras, ModiCarrera);
            }
        }

        static void BajaCarrera(string rutaArchivoCarreras)
        {
            List<Carrera> BajaCarrera = new List<Carrera>();
            string ID;
            ID = NumeroValido("Ingrese Indice de la Carrera que desea Dar de Baja: ");
            LeerArchivoCarrera(rutaArchivoCarreras, BajaCarrera);
            for (int i = 0; i < BajaCarrera.Count; i++)
            {
                if (BajaCarrera[i].Indice == ID)
                {
                    if (BajaCarrera[i].EstaActiva == true)
                    {
                        BajaCarrera[i] = new Carrera
                        {
                            Indice = BajaCarrera[i].Indice,
                            NombreCarrera = BajaCarrera[i].NombreCarrera,
                            EstaActiva = !ingresoOpcion($"Desea Dar de Baja la Carrera: {BajaCarrera[i].NombreCarrera}(Si / No): "),
                        };
                    }
                    else
                    {
                        Console.WriteLine("La Carrera ya esta desactivada..");
                    }

                }
            }
            GrabarArchivoCarrera(rutaArchivoCarreras, BajaCarrera);
        }


        /*--------------------------------------------------------       MATERIAS      -----------------------------------------------------------------------------------------------*/

        static void IngresoMateria(string rutaArchivo, ref Materia ListaMateria)
        {

            Console.WriteLine("Ingrese Numero Unico de Materia: ");
            ListaMateria.Indice = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre de la Materia: ");
            ListaMateria.NombreMateria = Console.ReadLine();
            Console.WriteLine("Materia Activa? ");
            ListaMateria.EstaActiva = ingresoOpcion("(Si/No):");
        }
        static void AltaMateria(string rutaArchivo)
        {
            if (MateriaExistente(rutaArchivo))
            {
                Console.WriteLine("Materia Ya Existente..");
            }
            else
            {
                List<Materia> NuevaMateria = new List<Materia>();
                Materia nueva = new Materia();

                while (ingresoOpcion("Se cargaran los Datos de Una Nueva Materia, continua?(si / no): "))
                {
                    IngresoMateria(rutaArchivo, ref nueva);
                    NuevaMateria.Add(nueva);
                }

                bool concateno = true;
                try
                {
                    StreamWriter escribir = new StreamWriter(rutaArchivo, concateno);

                    foreach (var item in NuevaMateria)
                    {
                        escribir.Write(item.Indice + ",");
                        escribir.Write(item.NombreMateria + ",");
                        escribir.Write(item.EstaActiva + ",");
                        escribir.WriteLine();
                    }
                    escribir.Close();
                    Console.WriteLine("Saliendo..");
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Hubo un error con el archivo.. {error.Message}");
                }
            }
        }

        static bool MateriaExistente(string rutaArchivoMaterias)
        {
            List<Materia> ModiMateria = new List<Materia>();
            string ID;
            bool encontrado = false;
            ID = NumeroValido("Ingrese INDICE de la Materia a Cargar: ");
            LeerArchivoMateria(rutaArchivoMaterias, ModiMateria);

            for (int i = 0; i < ModiMateria.Count; i++)
            {
                if (ModiMateria[i].Indice == ID)
                {
                    encontrado = true;
                    if (ModiMateria[i].EstaActiva == false)
                    {
                        ModiMateria[i] = new Materia
                        {
                            Indice = ModiMateria[i].Indice,
                            NombreMateria = ModiMateria[i].NombreMateria,
                            EstaActiva = ingresoOpcion("Materia Existente Inactiva, La Activa?(Si/No): ")
                        };
                    }
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No se encontró ningúna Materia con el ID especificado.");
            }
            else
            {
                GrabarArchivoMateria(rutaArchivoMaterias, ModiMateria);
            }
            return encontrado;
        }

        static void LeerArchivoMateria(string rutaArchivo, List<Materia> Mar)
        {
            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    Materia materia = new Materia();
                    materia.Indice = campos[0];
                    materia.NombreMateria = campos[1];
                    materia.EstaActiva = bool.Parse(campos[2]);

                    linea = lector.ReadLine();
                    Mar.Add(materia);
                }
                lector.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }

        static void GrabarArchivoMateria(string rutaArchivo, List<Materia> Mar)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);
                foreach (var materia in Mar)
                {
                    escritor.Write(materia.Indice + ",");
                    escritor.Write(materia.NombreMateria + ",");
                    escritor.Write(materia.EstaActiva + ",");
                    escritor.WriteLine();
                }
                escritor.Close();

                Console.WriteLine("Los cambios se han guardado correctamente en el archivo.");
            }

            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }

        static void ModificacionMateria(string rutaArchivoMaterias)
        {
            List<Materia> ModiMateria = new List<Materia>();
            bool nuevoEstado;
            string ID;
            bool encontrado = false;
            LeerArchivoMateria(rutaArchivoMaterias, ModiMateria);
            Console.WriteLine("Materias en La UTN: ");
            for (int i = 0; i < ModiMateria.Count; i++)
            {
                Console.WriteLine($"Indice: {ModiMateria[i].Indice} Nombre: {ModiMateria[i].NombreMateria} ");

            }
            ID = NumeroValido("Ingrese INDICE de la Materia a Modificar: ");



            for (int i = 0; i < ModiMateria.Count; i++)
            {

                if (ModiMateria[i].Indice == ID)
                {
                    encontrado = true;
                    Console.Write($"Indice Actual: - {ModiMateria[i].Indice} - Nuevo Indice: ");
                    string nuevoIndice = Console.ReadLine();
                    Console.Write($"Nombre Actual: - {ModiMateria[i].NombreMateria} - Nuevo Nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.WriteLine($"Estado Actual: - {ModiMateria[i].EstaActiva} - Nuevo Estado: ");
                    nuevoEstado = ingresoOpcion("Si: Para Activar / No: Para Desactivar:");

                    ModiMateria[i] = new Materia
                    {
                        Indice = nuevoIndice,
                        NombreMateria = nuevoNombre,
                        EstaActiva = nuevoEstado,
                    };
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningúna Materia con el ID especificado.");
            }
            else
            {
                GrabarArchivoMateria(rutaArchivoMaterias, ModiMateria);
            }
        }

        static void BajaMateria(string rutaArchivoMaterias)
        {
            List<Materia> BajaMateria = new List<Materia>();
            string ID;
            ID = NumeroValido("Ingrese Indice de la Materia que desea Borrar: ");
            LeerArchivoMateria(rutaArchivoMaterias, BajaMateria);
            for (int i = 0; i < BajaMateria.Count; i++)
            {
                if (BajaMateria[i].Indice == ID)
                {
                    if (BajaMateria[i].EstaActiva == true)
                    {
                        BajaMateria[i] = new Materia
                        {
                            Indice = BajaMateria[i].Indice,
                            NombreMateria = BajaMateria[i].NombreMateria,
                            EstaActiva = !ingresoOpcion($"Desea Dar de Baja la Materia: {BajaMateria[i].NombreMateria}(Si / No): "),
                        };
                    }
                    else
                    {
                        Console.WriteLine("La Materia ya esta desactivada..");
                    }

                }
            }
            GrabarArchivoMateria(rutaArchivoMaterias, BajaMateria);
        }


        //------------------------------------------------------------------- RELACIONES ------------------------------------------------------------------------------------
        static void LeerArchivoCarreraMateria(string rutaArchivo, List<Carrera_Materia> CarMar)
        {
            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    Carrera_Materia carmar = new Carrera_Materia();
                    carmar.Indice = campos[0];
                    carmar.Plan = campos[1];
                    carmar.IndiceCarrera = campos[2];
                    carmar.IndiceMateria = campos[3];
                    carmar.EstaActiva = bool.Parse(campos[4]);

                    linea = lector.ReadLine();
                    CarMar.Add(carmar);
                }
                lector.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }
        static void CarreraMateria(string rutaArchivoCarreras, string rutaArchivoMaterias, string rutaArchivoCarreraMaterias)
        {
            bool encontrado = false;
            List<Carrera> carreras = new List<Carrera>();
            List<Materia> materias = new List<Materia>();
            List<Carrera_Materia> CarrerasMateria = new List<Carrera_Materia>();
            LeerArchivoCarrera(rutaArchivoCarreras, carreras);
            LeerArchivoMateria(rutaArchivoMaterias, materias);

            Console.WriteLine("Carreras existentes en la Universidad: ");
            for (int i = 0; i < carreras.Count; i++)
            {
                Console.WriteLine($"Indice {carreras[i].Indice} Nombre Carrera: {carreras[i].NombreCarrera} ");
            }
            Console.WriteLine();
            string selecCarrera = NumeroValido("Seleccione Una CARRERA segun su indice: ");
            Console.WriteLine();
            Console.WriteLine("Materias existentes en la Universidad: ");
            for (int i = 0; i < materias.Count; i++)
            {
                Console.WriteLine($"Indice {materias[i].Indice} Nombre Materia: {materias[i].NombreMateria} ");
            }
            Console.WriteLine();
            string selecMateria = NumeroValido("Seleccione una MATERIA para Asociar segun su Indice: ");
            

            LeerArchivoCarreraMateria(rutaArchivoCarreraMaterias, CarrerasMateria);
            for (int x = 0; x < CarrerasMateria.Count; x++)
            {
                if (selecMateria == CarrerasMateria[x].IndiceMateria)
                {
                    encontrado = true;
                    Console.WriteLine("Materia existente en la carrera..");
                    break;
                }
            }

            if (encontrado == false)
            {
                CarrerasMateria.Add(new Carrera_Materia
                {
                    Indice = NumeroValido("Ingrese Indice de la Relacion Carrera-Materia: "),
                    Plan = "2023",
                    IndiceCarrera = selecCarrera,
                    IndiceMateria = selecMateria,
                    EstaActiva = ingresoOpcion("Esta Activa? (Si/No)"),
                });
                GrabarArchivoCarreraMateria(rutaArchivoCarreraMaterias, CarrerasMateria);
            }
        }

        static void GrabarArchivoCarreraMateria(string rutaArchivo, List<Carrera_Materia> CarMar)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);
                foreach (var item in CarMar)
                {
                    escritor.Write(item.Indice + ",");
                    escritor.Write(item.Plan + ",");
                    escritor.Write(item.IndiceCarrera + ",");
                    escritor.Write(item.IndiceMateria + ",");
                    escritor.Write(item.EstaActiva + ",");
                    escritor.WriteLine();
                }
                escritor.Close();

                Console.WriteLine("Los cambios se han guardado correctamente en el archivo.");
            }

            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }

        static void CarreraAlumno(string rutaArchivoAlumnos, string rutaArchivoCarreras, string rutaArchivoCarreraAlumno)
        {
            bool encontrado = false;
            List<Carrera> carreras = new List<Carrera>();
            List<Alumno> Alumno = new List<Alumno>();
            List<Carrera_Alumno> CarrerasAlumno = new List<Carrera_Alumno>();
            LeerArchivoCarrera(rutaArchivoCarreras, carreras);
            LeerArchivo(rutaArchivoAlumnos, Alumno);
            LeerArchivoCarreraAlumno(rutaArchivoCarreraAlumno, CarrerasAlumno);

            Console.WriteLine("Carreras existentes en la Universidad: ");
            for (int i = 0; i < carreras.Count; i++)
            {
                Console.WriteLine($"Indice {carreras[i].Indice} Nombre Carrera: {carreras[i].NombreCarrera} ");
            }
            Console.WriteLine();
            string selecCarrera = NumeroValido("Seleccione por Indice la CARRERA a la cual va asociar al Alumno: ");
            Console.WriteLine();
            Console.WriteLine("Alumnos existentes en la Universidad: ");
            for (int i = 0; i < Alumno.Count; i++)
            {
                Console.WriteLine($"Indice {Alumno[i].Indice} Nombre Alumno: {Alumno[i].Nombre} {Alumno[i].Apellido}");
            }

            Console.WriteLine();
            string selecAlumno = NumeroValido("Seleccione El ALUMNO segun su Indice: ");
            


            for (int x = 0; x < CarrerasAlumno.Count; x++)
            {
                if (selecAlumno == CarrerasAlumno[x].IndiceAlumno)
                {
                    encontrado = true;
                    Console.WriteLine("Alumno existente en la carrera..");
                    break;
                }
            }

            if (encontrado == false)
            {
                CarrerasAlumno.Add(new Carrera_Alumno
                {
                    Indice = NumeroValido("Indice de la Relacion: "),
                    IndiceCarrera = selecCarrera,
                    IndiceAlumno = selecAlumno,
                    EstaActiva = ingresoOpcion("Esta Activa? (Si/No)"),
                });
                GrabarArchivoCarreraAlumno(rutaArchivoCarreraAlumno, CarrerasAlumno);
            }

        }

        static void LeerArchivoCarreraAlumno(string rutaArchivo, List<Carrera_Alumno> CarAlu)
        {
            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    Carrera_Alumno caralu = new Carrera_Alumno();
                    caralu.Indice = campos[0];
                    caralu.IndiceCarrera = campos[1];
                    caralu.IndiceAlumno = campos[2];
                    caralu.EstaActiva = bool.Parse(campos[3]);

                    linea = lector.ReadLine();
                    CarAlu.Add(caralu);
                }
                lector.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }

        static void GrabarArchivoCarreraAlumno(string rutaArchivo, List<Carrera_Alumno> CarAlu)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);
                foreach (var item in CarAlu)
                {
                    escritor.Write(item.Indice + ",");
                    escritor.Write(item.IndiceCarrera + ",");
                    escritor.Write(item.IndiceAlumno + ",");
                    escritor.Write(item.EstaActiva + ",");
                    escritor.WriteLine();
                }
                escritor.Close();

                Console.WriteLine("Los cambios se han guardado correctamente en el archivo.");
            }

            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }

        static void LeerArchivoAlumnoMaterias(string rutaArchivo, List<Alumno_Materias> AluMat)
        {
            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    Alumno_Materias alumat = new Alumno_Materias();
                    alumat.Indice = campos[0];
                    alumat.IndiceCarrera = campos[1];
                    alumat.IndiceAlumno = campos[2];
                    alumat.IndiceMateria = campos[3];
                    alumat.Estado = bool.Parse(campos[4]);
                    alumat.Nota = campos[4];
                    alumat.Fecha = campos[5];

                    linea = lector.ReadLine();
                    AluMat.Add(alumat);
                }
                lector.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }

        static void AlumnoMaterias(string rutaArchivoCarreraAlumno, string rutaArchivoCarreraMaterias, string rutaArchivoAlumnoMateria)
        {
            bool aprobado = false, encontrado = false;
            string fecha = "", nota = "", carrera = "";
            List<Carrera_Alumno> CarrerasAlumno = new List<Carrera_Alumno>();
            List<Carrera_Materia> CarrerasMateria = new List<Carrera_Materia>();
            List<Alumno_Materias> Alumno_Mat = new List<Alumno_Materias>();
            LeerArchivoCarreraAlumno(rutaArchivoCarreraAlumno, CarrerasAlumno);
            LeerArchivoCarreraMateria(rutaArchivoCarreraMaterias, CarrerasMateria);
            LeerArchivoAlumnoMaterias(rutaArchivoAlumnoMateria, Alumno_Mat);

            for (int i = 0; i < CarrerasAlumno.Count; i++)
            {
                Console.WriteLine($"Alumnos Anotados en Carreras Indice: {CarrerasAlumno[i].IndiceAlumno} ");
            }
            string Alumno = NumeroValido("Ingrese Indice del alumno Para cargar la nota: ");

            for (int i = 0; i < CarrerasAlumno.Count; i++)
            {
                if (CarrerasAlumno[i].IndiceAlumno == Alumno)
                {
                    carrera = CarrerasAlumno[i].IndiceCarrera;
                    encontrado = true;
                    for (int j = 0; j < CarrerasMateria.Count; j++)
                    {
                        Console.WriteLine($"Materias en la carrera indice:{CarrerasMateria[j].IndiceMateria}");
                    }

                }

            }
            if (encontrado == true)
            {
                string materia = NumeroValido("Seleccione Materia Para cargar nota: ");
                for (int i = 0; i < CarrerasMateria.Count; i++)
                {
                    if (CarrerasMateria[i].IndiceMateria == materia)
                    {
                        nota = NumeroValido("Ingrese Nota: ");
                        if (int.Parse(nota) >= 60)
                        {
                            aprobado = true;
                        }
                        else
                        {
                            aprobado = false;
                        }
                        fecha = FechaValida("Ingrese Fecha del Final Rendido(DD/MM/AAAA): ");

                    }

                }
                Alumno_Mat.Add(new Alumno_Materias
                {
                    Indice = NumeroValido("Ingrese indice de la relacion: "),
                    IndiceCarrera = carrera,
                    IndiceAlumno = Alumno,
                    IndiceMateria = materia,
                    Estado = aprobado,
                    Nota = nota,
                    Fecha = fecha,

                });
                GrabarArchivoAlumnoMateria(rutaArchivoAlumnoMateria, Alumno_Mat);

            }
            else
            {
                Console.WriteLine("Alumno No encontrado..");
            }
        }
        static void GrabarArchivoAlumnoMateria(string rutaArchivo, List<Alumno_Materias> AluMat)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);
                foreach (var item in AluMat)
                {
                    escritor.Write(item.Indice + ",");
                    escritor.Write(item.IndiceCarrera + ",");
                    escritor.Write(item.IndiceAlumno + ",");
                    escritor.Write(item.IndiceMateria + ",");
                    escritor.Write(item.Estado + ",");
                    escritor.Write(item.Nota + ",");
                    escritor.Write(item.Fecha + ",");
                    escritor.WriteLine();
                }
                escritor.Close();

                Console.WriteLine("Los cambios se han guardado correctamente en el archivo.");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hubo un error con el archivo: {error.Message}");
                return;
            }

        }



    }



}