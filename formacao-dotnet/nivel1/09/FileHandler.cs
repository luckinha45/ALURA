using System.Text;

namespace Aula09;

internal class FileHandler
{
    static public int BUFFER_SIZE = 1024;

    static public void WriteBuffer(byte[] buffer, int totalBytes)
    {
        var utf8 = new UTF8Encoding();
        var txt = utf8.GetString(buffer, 0, totalBytes);
        Console.Write(txt);
    }

    static public void NewFile(string filePath)
    {
        using (FileStream fs = new(filePath, FileMode.Create))
        using (StreamWriter sw = new(fs))
        {
            string contaStr = "456, 7895, 4575.23, Gustávo Jorjï";
            sw.Write(contaStr);
        }
    }
}
