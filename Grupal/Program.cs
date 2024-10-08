
using Grupal;
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Cyan;
bool menu = true;

List<Persona> listadoGeneralPersonas = new List<Persona>();
List<Tratamiento> listadoTratamientos = new List<Tratamiento>();
List<Cita_medica> listadoCitas = new List<Cita_medica>();
List<Medicamentos> listadoMedicamentos = new List<Medicamentos>();
Medico medicoBase = new Medico("aaa", "Josu", "Mi casa", DateTime.Now, "55", "Cardiologo");
Paciente pacienteBase= new Paciente("bbb", "Josu", "Mi casa", DateTime.Now, "55", listadoTratamientos);
listadoGeneralPersonas.Add(medicoBase);
listadoGeneralPersonas.Add(pacienteBase);
Tratamiento tratamientoBase = new Tratamiento(1,  listadoMedicamentos, 33);
Cita_medica citaMedicaBase = new Cita_medica(1,DateTime.Now,"medicoBase","pacienteBase","Paracetamol");

do
{
    try
    {
        Menu(listadoGeneralPersonas, listadoTratamientos, listadoCitas);
    }
    catch (FormatException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
        Console.ResetColor();
    }
    catch (OverflowException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
        Console.ResetColor();
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
        Console.ResetColor();
    }
    catch (NullReferenceException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
        Console.ResetColor();
    }
    catch (InvalidOperationException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
        Console.ResetColor();
    }
    catch (DivideByZeroException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
        Console.ResetColor();
    }

} while (menu);


void Menu(List<Persona> personas, List<Tratamiento> listadoTratamientos, List<Cita_medica> listadoCitas)
{
    while (menu)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.Clear();
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("             Hospital Pediatrico Alegría");
        Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
        Console.WriteLine("1. Agregar persona");
        Console.WriteLine("2. Programar cita");
        Console.WriteLine("3. Consultar listados");
        Console.WriteLine("4. Agregar tratamiento");
        Console.WriteLine("5. Salir");
        Console.Write("Ingrese una opción del menú: ");
        int optionSwitch = Convert.ToInt32(Console.ReadLine());
        switch (optionSwitch)
        {
            case 1:
                agregarPersona(personas);
                break;
            case 2:
                citaMedicaBase.AgregarCita(personas, listadoCitas);
                break;
            case 3:
                consultarListado(personas, listadoTratamientos, listadoCitas);
                break;
            case 4:
                tratamientoBase.ProgramarTratamiento(listadoCitas,listadoTratamientos,listadoMedicamentos, listadoGeneralPersonas);
                break;
            case 5:
                menu = false; break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese una opción valida"); Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Cyan;

                break;
        }
    }
}
void agregarPersona(List<Persona> personas)
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.Clear();
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("                    MENU AGREGAR");
    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
    Console.WriteLine("1. Agregar Paciente");
    Console.WriteLine("2. Agregar Médico");
    Console.WriteLine("3. Salir");
    Console.Write("Ingrese una opción del menú: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    switch (optionSwitch)
    {
        case 1:
            pacienteBase.agregarPaciente(personas);
            break;
        case 2:
            medicoBase.agregarMedico(personas);
            break;
        case 3:
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ingrese una opción valida"); Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
    }
}
void consultarListado(List<Persona> personas, List<Tratamiento> listadoTratamientos, List<Cita_medica> listadoCitas)
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.Clear();
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("                    MENU LISTADOS");
    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
    Console.WriteLine("1. Listado de Pacientes");
    Console.WriteLine("2. Listado de Médicos");
    Console.WriteLine("3. Listado de Tratamientos");
    Console.WriteLine("4. Listado de Citas");
    Console.WriteLine("5. Salir");
    Console.Write("Ingrese una opción del menú: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    switch (optionSwitch)
    {
        case 1:
          
                    Console.WriteLine("---------------------------------------------------");
                    pacienteBase.MostrarDetalles(listadoGeneralPersonas);
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine();
            break;
        case 2:

                    Console.WriteLine("---------------------------------------------------");
                    medicoBase.MostrarDetalles(listadoGeneralPersonas);
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine();
            break;
        case 3:
            tratamientoBase.ListadoTratamientos(listadoTratamientos);
            break;
        case 4:
            citaMedicaBase.ListadoCitas(listadoCitas);
            break;
        case 5:
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Ingrese una opción valida");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;

            break;
    }
    Console.ReadKey();
}
