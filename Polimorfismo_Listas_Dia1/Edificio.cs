

namespace Polimorfismo_Listas_Dia1
{
    public class Edificio
    {

        public string Tipo {  get; set; }
        public double Precio {  get; set; }

        public Edificio(string Tipos, double Precio)
        {
            this.Tipo = Tipos;
            this.Precio = Precio;
        }

        public void Vender()
        {
            Console.WriteLine();
            Console.WriteLine($"Edificio de tipo {Tipo}, ha sido vendido por el precio de L.{Precio.ToString("N2")}");
        }

        public void Vender(string Vendedor)
        {
            Console.WriteLine();
            Console.WriteLine($"Edificio de tipo {Tipo}, ha sido vendido por el precio de L.{Precio.ToString("N2")}, por el vendedor {Vendedor} ");
        }

        public void Vender(string Tpo, double Precio)
        {
            Console.WriteLine();
            Console.WriteLine($"Edificio de tipo {Tipo}, ha sido vendido por el precio de L.{Precio.ToString("N2")}");
        }

    }
}
