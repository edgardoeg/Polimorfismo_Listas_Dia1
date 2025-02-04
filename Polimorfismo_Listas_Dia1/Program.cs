using Polimorfismo_Listas_Dia1;

string? tipo, opcion;
double precio;
List<Edificio> lista= new List<Edificio>();

do
{
    Console.Write("Ingrese el tipo de edificio: ");
    tipo= Console.ReadLine();

    Console.Write("Ingrese el valor del edificio: ");
    precio = Convert.ToDouble(Console.ReadLine());

    Console.Write("Desea continuar? (S/N) o (s/n)");

    opcion = Console.ReadLine();

} while (opcion.ToUpper() !="N");


