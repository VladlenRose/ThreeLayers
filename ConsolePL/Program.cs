using BL;
using DL.Repository;
using DL.Softwares;

namespace ConsolePL
{
    internal class Program
    {
        static void Main()
        {
            string path = "softwares.json";
            var manager = new SoftwareManager(new SoftwareRepository());


            var freeSoftware = new FreeSoftware("FreeApp", "FreeDev");
            var partlyFreeSoftware = new PartlyFreeSoftware("PartlyFreeApp", "PartlyFreeDev", DateTime.Now.AddMonths(1));
            var commercialSoftware = new CommercialSoftware("CommercialApp", "CommercialDev", DateTime.Now.AddYears(1), 1000);
            var expiredPartlyFreeSoftware = new PartlyFreeSoftware("ExpiredPartlyFreeApp", "ExpiredPartlyFreeDev", DateTime.Now.AddDays(-1));
            var expiredCommercialSoftware = new CommercialSoftware("ExpiredCommercialApp", "ExpiredCommercialDev", DateTime.Now.AddHours(-1), 999);

            manager.AddSoftware(freeSoftware);
            manager.AddSoftware(partlyFreeSoftware);
            manager.AddSoftware(commercialSoftware);
            manager.AddSoftware(expiredPartlyFreeSoftware);
            manager.AddSoftware(expiredCommercialSoftware);

            Console.WriteLine("После добавления ПО:");
            PrintSoftwares(manager.GetAllSoftwares());

            manager.Save(path);
            Console.WriteLine($"Данные успешно сохранены в {path}.");
            Console.WriteLine();

            manager.RemoveSoftware(freeSoftware.Id);
            Console.WriteLine($"После удаления ПО с ID {freeSoftware.Id}:");
            PrintSoftwares(manager.GetAllSoftwares());

            manager.RemoveSoftware(expiredPartlyFreeSoftware.Id);
            Console.WriteLine($"После удаления ПО с ID {expiredPartlyFreeSoftware.Id}:");
            PrintSoftwares(manager.GetAllSoftwares());

            manager = new SoftwareManager(new SoftwareRepository());
            manager.Load(path);
            Console.WriteLine("После загрузки из JSON:");
            PrintSoftwares(manager.GetAllSoftwares());

            Console.WriteLine("Доступное ПО:");
            PrintSoftwares(manager.GetAvailableSoftwares());


            Console.WriteLine("Бесплатное ПО:");
            PrintSoftwares(manager.GetSoftwaresByType(typeof(FreeSoftware)));

            Console.WriteLine("Пробное ПО:");
            PrintSoftwares(manager.GetSoftwaresByType(typeof(PartlyFreeSoftware)));

            Console.WriteLine("Платное ПО:");
            PrintSoftwares(manager.GetSoftwaresByType(typeof(CommercialSoftware)));

            Console.WriteLine("ПО, в названиях которых содержиться 'expired'");
            PrintSoftwares(manager.FindSoftwaresByName("expired"));
        }

        static void PrintSoftwares(List<SoftwareBase> softwares)
        {
            if (softwares.Count == 0)
            {
                Console.WriteLine("Нет доступного ПО.");
                return;
            }

            foreach (var software in softwares)
            {
                Console.WriteLine(software.GetInfo());
            }
            Console.WriteLine();
        }
    }
}
