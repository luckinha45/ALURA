using Aula09.Models;

namespace Aula09;

class _Exec
{
    public static void Executar()
    {
        // Altera o diretorio inicial
        Directory.SetCurrentDirectory(@".\09\");

        FileHandler.BinWrite();
        FileHandler.BinRead();


        // string addrArquivo = ".\\contas.txt";

        // using (var fs = new FileStream(addrArquivo, FileMode.Open))
        // {
        //     var sr = new StreamReader(fs);

        //     ContaCorrente? cc = null;

        //     while (!sr.EndOfStream)
        //     {
        //         var linha = sr.ReadLine();
        //         cc = ContaCorrente.StringToCC(linha ?? "");
        //         cc.ExibeDetalhes();
        //     }
        // }
    }
}