using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Inmobiliaria.Datos
{
    public abstract class RepositorioBase<T>
    {
        protected string FilePath;

        public RepositorioBase(string filePath)
        {
            FilePath = filePath;
        }

        public List<T> ObtenerTodos()
        {
            if (!File.Exists(FilePath))
                return new List<T>();

            var jsonData = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<T>>(jsonData) ?? new List<T>();
        }

        public void GuardarTodos(List<T> items)
        {
            var jsonData = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(FilePath, jsonData);
        }
    }
}
