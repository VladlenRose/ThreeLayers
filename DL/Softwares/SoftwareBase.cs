using System.Text.Json.Serialization;

namespace DL.Softwares
{
    [JsonDerivedType(typeof(FreeSoftware), "FreeSoftware")]
    [JsonDerivedType(typeof(PartlyFreeSoftware), "PartlyFreeSoftware")]
    [JsonDerivedType(typeof(CommercialSoftware), "CommercialSoftware")]
    public abstract class SoftwareBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }

        [JsonConstructor]
        protected SoftwareBase(int id, string name, string developer)
        {
            Id = id;
            Name = name;
            Developer = developer;
        }
        protected SoftwareBase(string name, string developer)
        {
            Name = name;
            Developer = developer;
        }

        public abstract bool IsAvailable();

        public abstract string GetInfo();
    }
}