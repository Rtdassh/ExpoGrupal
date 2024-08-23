bool menu = true;

do
{
    try
    {
        LecturaSwitch();
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error! " + ex.Message);
        Console.ReadKey();
    }
} while (menu);

int Menu()
{
    Console.Clear();
    Console.WriteLine("Hospital Pediatrico Alegría");
    Console.WriteLine("1. Agregar persona");
    Console.WriteLine("2. Programar cita");
    Console.WriteLine("3. Consultar listados");
    Console.WriteLine("4. ");
    Console.WriteLine("5. ");
    Console.Write("Ingrese una opción del menú: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    return optionSwitch;
}

void LecturaSwitch()
{
    switch (Menu())
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        default:
            Console.ReadKey();
            break;
    }
}


