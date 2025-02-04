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

    Edificio edificio = new Edificio(tipo, precio);
    lista.Add(edificio);

    Console.Write("Desea continuar? (S/N) o (s/n)");

    opcion = Console.ReadLine();

    Console.WriteLine();

    

} while (opcion.ToUpper() !="N");

foreach (Edificio edificio in lista)
{

    edificio.Vender();

}



