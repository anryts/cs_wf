using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GreatProject;

internal interface IPrintable
{
    string GetData();
}

internal interface IWorkData
{
    void ProcessWithData(List<IPrintable> some_thing);
}

internal interface IWritable
{
}

internal class Write_in_File : IWorkData
{
    public string WritePath { get; set; }

    public void ProcessWithData(List<IPrintable> some_thing)
    {
        foreach (var temp in some_thing)
            using (var sw = new StreamWriter(WritePath, true, Encoding.Default))
            {
                sw.WriteLine(temp.GetData());
            }
    }
}