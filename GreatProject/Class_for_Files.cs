using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
   //delegate int count_of_j (string line, int i);
    class Read_from_file
    {
        public void ReadFile()
        {
            string readPath = @"C:\C#_dir\1.txt";
            using (StreamReader r = new(readPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    if (line.Contains("Food"))
                    {
                        Food temp = new();
                        int j = 0;
                        for (int i = 4; i < line.Length; i++)
                        {
                            if (Char.IsLetter(line[i]))
                            {                           
                                for (j = i; !Char.IsWhiteSpace(line[j]); j++)
                                {

                                }
                                temp.Name = line.Substring(i, j - i);
                                i = j;

                            }
                            if (Char.IsDigit(line[i]) && j != 0)
                            {
                                j = 0;
                                for (j = i; j < line.Length; j++)
                                {

                                }
                                temp.Expiration_date = Convert.ToDateTime(line.Substring(i, j - i));
                                i = j;
                            }
                        }
                        Date.Property_for_warehouse.list_of_food.Add(temp);

                    }
                    if (line.Contains("Materials"))
                    {
                        Materials temp = new();
                        Date.Property_for_warehouse_materials.list_of_materials.Add(temp);
                    }
                }
            }
        }


    }
}
