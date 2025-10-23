namespace Aula09;

class _Exec
{
    public static void Executar()
    {
        string addrArquivo = ".\\09\\contas.txt";
        var fs = new FileStream(addrArquivo, FileMode.Open);


        int totalBytes = -1;
        int offset = 0;
        int count = FileHandler.BUFFER_SIZE;
        while (totalBytes != 0)
        {
            var buffer = new byte[count];
            totalBytes = fs.Read(buffer, 0, count);
            offset += totalBytes;

            FileHandler.WriteBuffer(buffer);
            count = totalBytes;
        }


    }
}