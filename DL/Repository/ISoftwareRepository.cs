using DL.Softwares;

namespace DL.Repository
{
    public interface ISoftwareRepository
    {
        SoftwareBase GetSoftware(int id);

        List<SoftwareBase> GetAllSoftwares();

        List<SoftwareBase> GetSoftwaresByType(Type type);

        List<SoftwareBase> FindSoftwaresByName(string name);

        void AddSoftware(SoftwareBase software);

        void RemoveSoftware(int id);

        void Save(String path);

        void Load(String path);
    }
}
