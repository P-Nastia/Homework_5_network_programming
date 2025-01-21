using System.Text;

namespace NovaPoshta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            NovaPoshtaService novaPoshtaService = new NovaPoshtaService();
            novaPoshtaService.SeedAreas();
            var list = novaPoshtaService.GetListAreas();
            novaPoshtaService.SeedCities();
            var list2 = novaPoshtaService.GetListCities();
            novaPoshtaService.SeedWarehouses();
            var list3 = novaPoshtaService.GetWarehouses();
        }
    }
}
