using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GreatProject;

internal class BinFile<T> where T : Item
{
    private readonly BinaryFormatter _formatter = new();

    public void WriteFile(List<T> exampleGen, string path)
    {
        using (var fs = new FileStream(path, FileMode.Open))
        {
            _formatter.Serialize(fs, exampleGen);
        }
    }

    public List<T> ReadFile(string path)
    {
        using (var fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            try
            {
                if (fs.Length != 0)
                {
                    var deserializeList = (List<T>)_formatter.Deserialize(fs);
                    return deserializeList;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }
    }
}

internal class ReadFromFile
{
    // change direction of folder in ReadPath TODO
    private const string ReadPath = @"C:\C#_dir\1.txt";

    public void ReadFile()
    {
        using (StreamReader r = new(ReadPath, Encoding.Default))
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                if (line.Contains("Food"))
                {
                    Food temp = new();
                    var onlyLetters = new string(line.Substring(5, line.Length - 5).Where(char.IsLetter).ToArray());
                    var onlyDateTime = new string(line.Substring(10, line.Length - 10)
                        .Where(c => char.IsDigit(c) || c == '/').ToArray());
                    temp.Name = onlyLetters;
                    temp.Expiration_date = Convert.ToDateTime(onlyDateTime);
                    Date.Property_for_warehouse.list_of_food.Add(temp);
                }

                if (!line.Contains("Materials")) continue;
                {
                    Materials temp = new();
                    Date.Property_for_warehouse_materials.list_of_materials.Add(temp);
                }
            }
        }
    }
}