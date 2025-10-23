using System.Text;

namespace Aula09;

internal class FileHandler
{
    static public int BUFFER_SIZE = 1024;

    static public void WriteBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();
        var txt = utf8.GetString(buffer);
        Console.Write(txt);
    }
}
