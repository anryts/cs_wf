using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GreatProject
{
    
       
    interface IPrintable
    {
        string GetData();
    }

    interface IWorkData
    {
        void ProcessWithData(List<IPrintable> some_thing);
    }

    interface IWritable
    {

    }

    class Write_in_File : IWorkData
    {
        public void ProcessWithData(List<IPrintable> some_thing)
        {
            string writePath = @"C:\C#_dir\1.txt";
            foreach (IPrintable temp in some_thing)
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(temp.GetData());
                    
                }

            }
        }
    }

    

}
    


    

