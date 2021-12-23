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

        private string writePath;

        public string WritePath     
        {
            get { return writePath; }
            set { writePath = value; }
        }

        public void ProcessWithData(List<IPrintable> some_thing)
        {
            foreach (IPrintable temp in some_thing)
            {
                using (StreamWriter sw = new StreamWriter(WritePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(temp.GetData());
                }
            }
        }
    }

    

}
    


    

