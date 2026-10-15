namespace Herencia_Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto v1 = new Auto("Ford", "Ka", 2015, 4, true);
            Auto v2 = new Auto("Ford", "Ka", 2005, 5, false);

            //Console.WriteLine(v.MostrarInformacion());
            //Vehiculo.MostrarInformacion(v);

            if (v1 > v2)
            {
                Console.WriteLine("es");
            }
            else
            {
                Console.WriteLine("no es");

            }




        }
    }
}
