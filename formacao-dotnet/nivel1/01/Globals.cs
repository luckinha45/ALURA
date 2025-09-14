public static class Globals
{
    public static string FormataDuracao(int duracaoEmSegundos)
    {
        int horas = duracaoEmSegundos / 3600;
        int minutos = (duracaoEmSegundos % 3600) / 60;
        int segundos = duracaoEmSegundos % 60;

        if (horas > 0)
        {
            return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
        }
        else
        {
            return $"{minutos:D2}:{segundos:D2}";
        }
    }

    public static int DuracaoToSecs(int mins, int secs)
    {
        return mins * 60 + secs;
    }
}