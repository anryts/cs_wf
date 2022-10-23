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
    void ProcessWithData(List<IPrintable> someThing);
}

internal interface IWritable
{
}

internal class WriteInFile : IWorkData
{
    private string WritePath => null;

    public void ProcessWithData(List<IPrintable> someThing)
    {
        foreach (var temp in someThing)
        {
            using var sw = new StreamWriter(WritePath, true, Encoding.Default);
            sw.WriteLine(temp.GetData());
        }
    }
}