
using Grupal;

bool menu = true;

List<Persona> listadoGeneralPersonas = new List<Persona>();
List<Tratamiento> listadoTratamientos = new List<Tratamiento>();
List<Cita_medica> listadoCitas = new List<Cita_medica>();

do
{
    try
    {
        Menu(listadoGeneralPersonas, listadoTratamientos, listadoCitas);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
    }
} while (menu);


void Menu(List<Persona> personas, List<Tratamiento> listadoTratamientos, List<Cita_medica> listadoCitas)
{
    while (menu)
    {
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
                //programarCita();
                break;
            case 3:
                consultarListado(personas, listadoTratamientos, listadoCitas);
                break;
            case 4:
                //agregarTratamiento();
                break;
            case 5:
                menu = false; break;
            default:
                Console.WriteLine("Ingrese una opción valida"); Console.ReadKey();
                break;
        }
    }
}
void agregarPersona(List<Persona> personas)
{
    Console.Clear();
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("                    MENU AGREGAR");
    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
    Console.WriteLine("1. Agregar paciente");
    Console.WriteLine("2. Agregar medico");
    Console.WriteLine("3. Salir");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    switch (optionSwitch)
    {
        case 1:
            //agregarPaciente();
            break;
        case 2:
            //agregarMedico();
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Ingrese una opción valida"); Console.ReadKey(); break;
    }
}
void consultarListado(List<Persona> personas, List<Tratamiento> listadoTratamientos, List<Cita_medica> listadoCitas)
{
    Console.Clear();
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("                    MENU LISTADOS");
    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
    Console.WriteLine("1. Listado de pacientes");
    Console.WriteLine("2. Listado de medicos");
    Console.WriteLine("3. Listado de tratamientos");
    Console.WriteLine("4. Listado de citas");
    Console.WriteLine("5. Salir");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    switch (optionSwitch)
    {
        case 1:
            //listadoPacientes
            break;
        case 2:
            //listadoMedicos

            break;
        case 3:
            //listadoTratamientos
            break;
        case 4:
            //listadoCitas
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Ingrese una opción valida"); Console.ReadKey();
            break;
    }
}

