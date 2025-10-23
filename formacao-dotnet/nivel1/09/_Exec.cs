namespace Aula09;

class _Exec
{
    public static void Executar()
    {
        string addrArquivo = ".\\09\\contas.txt";

        using (var fs = new FileStream(addrArquivo, FileMode.Open))
        {
            var sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                var linha = sr.ReadLine();
                Console.WriteLine(linha);
            }
        }
    }
}