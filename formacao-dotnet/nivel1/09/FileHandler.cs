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

    static public void TestWriting()
    {
        string filePath = @".\teste.txt";

        using (FileStream fs = new(filePath, FileMode.Create))
        using (StreamWriter sw = new(fs))
        {
            for (int i = 0; i < 1000000; i++)
            {
                sw.WriteLine($"asdasd {i}");
                sw.Flush();
            }
        }
    }

    static public void BinWrite()
    {

        string filePath = @".\teste.txt";

        using (FileStream fs = new(filePath, FileMode.Create))
        using (BinaryWriter bw = new(fs))
        {
            bw.Write(456);
            bw.Write(123123);
            bw.Write(123.43);
            bw.Write("Gustavo Lima");
        }
    }

    static public void BinRead()
    {
        string filePath = @".\teste.txt";

        using (FileStream fs = new(filePath, FileMode.Open))
        using (BinaryReader br = new(fs))
        {
            var ag = br.ReadInt32();
            var numero = br.ReadInt32();
            var saldo = br.ReadDouble();
            var nome = br.ReadString();

            Console.WriteLine($"{ag} {numero} {saldo} {nome}");
        }
    }
}
