using DL.Softwares;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace DL.Repository
{
    public class SoftwareRepository : ISoftwareRepository
    {
        private Dictionary<int, SoftwareBase> storage = new Dictionary<int, SoftwareBase>();
        private int nextId = 0;

        public SoftwareBase GetSoftware(int id)
        {
            return storage[id];
        }

        public List<SoftwareBase> GetAllSoftwares()
        {
            return new List<SoftwareBase>(storage.Values);
        }

        public List<SoftwareBase> GetSoftwaresByType(Type type)
        {
            var result = new List<SoftwareBase>();
            foreach (var software in storage.Values)
            {
                if (software.GetType() == type)
                {
                    result.Add(software);
                }
            }
            return result;
        }

        public List<SoftwareBase> FindSoftwaresByName(string name)
        {
            var result = new List<SoftwareBase>();
            foreach (var software in storage.Values)
            {
                if (software.Name.ToLower().Contains(name.ToLower()))
                {
                    result.Add(software);
                }
            }
            return result;
        }

        public void AddSoftware(SoftwareBase software)
        {
            software.Id = nextId++;

            storage.Add(software.Id, software);
        }

        public void RemoveSoftware(int id)
        {
            if (storage.ContainsKey(id))
            {
                storage.Remove(id);
            }
            else
            {
                throw new KeyNotFoundException("Software with the given ID does not exist.");
            }
        }

        public void Save(string path)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(storage, options);
            File.WriteAllText(path, json);
        }

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    var json = File.ReadAllText(path);
                    storage = JsonSerializer.Deserialize<Dictionary<int, SoftwareBase>>(json);
                    nextId = (storage.Count == 0 ? 0 : storage.Values.Max(x => x.Id) + 1);
                }
            }
            else
            {
                throw new FileNotFoundException("File not found.");
            }
        }
    }
}
