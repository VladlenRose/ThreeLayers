using DL.Softwares;

namespace BL
{
    public interface ISoftwareManager
    {
        SoftwareBase GetSoftware(int id);

        List<SoftwareBase> GetAllSoftwares();

        List<SoftwareBase> GetSoftwaresByType(Type type);

        List<SoftwareBase> FindSoftwaresByName(string name);

        List<SoftwareBase> GetAvailableSoftwares();

        List<SoftwareBase> GetAvailableSoftwaresByType(Type type);

        void AddSoftware(SoftwareBase software);

        void RemoveSoftware(int id);

        void Save(String path);

        void Load(String path);
    }
}
