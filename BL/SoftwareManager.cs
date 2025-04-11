using DL.Repository;
using DL.Softwares;

namespace BL
{
    public class SoftwareManager : ISoftwareManager
    {
        private ISoftwareRepository repository;

        public SoftwareManager(ISoftwareRepository repository)
        {
            this.repository = repository;
        }

        public SoftwareBase GetSoftware(int id)
        {
            return repository.GetSoftware(id);
        }

        public List<SoftwareBase> GetAllSoftwares()
        {
            return repository.GetAllSoftwares();
        }

        public List<SoftwareBase> GetSoftwaresByType(Type type)
        {
            return repository.GetSoftwaresByType(type);
        }

        public List<SoftwareBase> FindSoftwaresByName(string name)
        {
            return repository.FindSoftwaresByName(name);
        }

        public List<SoftwareBase> GetAvailableSoftwares()
        {
            var allSoftwares = repository.GetAllSoftwares();
            var availableSoftwares = new List<SoftwareBase>();
            foreach (var software in allSoftwares)
            {
                if (software.IsAvailable())
                {
                    availableSoftwares.Add(software);
                }
            }

            return availableSoftwares;
        }

        public List<SoftwareBase> GetAvailableSoftwaresByType(Type type)
        {
            var softwaresByType = repository.GetSoftwaresByType(type);
            var availableSoftwares = new List<SoftwareBase>();
            foreach (var software in softwaresByType)
            {
                if (software.IsAvailable())
                {
                    availableSoftwares.Add(software);
                }
            }

            return availableSoftwares;
        }

        public void AddSoftware(SoftwareBase software)
        {
            repository.AddSoftware(software);
        }

        public void RemoveSoftware(int id)
        {
            repository.RemoveSoftware(id);
        }

        public void Save(string path)
        {
            repository.Save(path);
        }

        public void Load(string path)
        {
            repository.Load(path);
        }
    }
}
