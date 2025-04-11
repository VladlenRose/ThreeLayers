using System.Text.Json.Serialization;

namespace DL.Softwares
{
    public class FreeSoftware : SoftwareBase
    {
        public FreeSoftware(string name, string developer)
            : base(name, developer) { }

        [JsonConstructor]
        public FreeSoftware(int id, string name, string developer)
            : base(id, name, developer) { }

        public override bool IsAvailable() { return true; }

        public override string GetInfo()
        {
            return $"ID: {Id}, Название: {Name}, Разработчик: {Developer}, Статус: Доступно";
        }
    }


    public class PartlyFreeSoftware : SoftwareBase
    {
        public DateTime ExpirationDate { get; set; }

        public PartlyFreeSoftware(string name, string developer, DateTime expirationDate)
            : base(name, developer)
        {
            ExpirationDate = expirationDate;
        }

        [JsonConstructor]
        public PartlyFreeSoftware(int id, string name, string developer, DateTime expirationDate)
            : base(id, name, developer)
        {
            ExpirationDate = expirationDate;
        }

        public override bool IsAvailable()
        {
            return DateTime.Now < ExpirationDate;
        }

        public override string GetInfo()
        {
            string availability = IsAvailable() ? "Доступно" : "Недоступно";
            return $"ID: {Id}, Название: {Name}, Разработчик: {Developer}, " +
                   $"Срок действия: {ExpirationDate.ToShortDateString()}, Статус: {availability}";
        }
    }


    public class CommercialSoftware : SoftwareBase
    {
        public DateTime ExpirationDate { get; set; }
        public double Price { get; set; }

        public CommercialSoftware(string name, string developer, DateTime expirationDate, double price)
            : base(name, developer)
        {
            ExpirationDate = expirationDate;
            Price = price;
        }

        [JsonConstructor]
        public CommercialSoftware(int id, string name, string developer, DateTime expirationDate, double price)
            : base(id, name, developer)
        {
            ExpirationDate = expirationDate;
            Price = price;
        }

        public override bool IsAvailable()
        {
            return DateTime.Now < ExpirationDate;
        }

        public override string GetInfo()
        {
            string availability = IsAvailable() ? "Доступно" : "Недоступно";
            return $"ID: {Id}, Название: {Name}, Разработчик: {Developer}, " +
                   $"Срок действия: {ExpirationDate.ToShortDateString()}, Цена: {Price}, Статус: {availability}";
        }
    }
}
