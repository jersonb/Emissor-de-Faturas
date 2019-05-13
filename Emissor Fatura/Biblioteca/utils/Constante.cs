namespace Biblioteca.utils
{
    public static class Constante
    {
        public static string PathData(Tipo t) { return @"C:\ProgramData\Fatura\data\" + Leitura.SelectTipo(t); }
        public const string PATH_FILES = @"C:\ProgramData\Fatura\files\";
        public const string PATH_FATURAS = @"C:\ProgramData\Fatura\faturas\";

    }
}
