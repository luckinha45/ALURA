using Aula09.Models;

namespace Aula09;

class _Exec
{
    public static void Executar()
    {
        // Altera o diretorio inicial
        Directory.SetCurrentDirectory(@".\09\");

        FileHandler.InputStream();
    }
}