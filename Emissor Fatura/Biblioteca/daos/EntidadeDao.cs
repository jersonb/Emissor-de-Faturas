using System;


namespace Biblioteca.daos
{
    abstract internal class EntidadeDao
    {
        public string Encode(string o)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(o));
        }

        public string Decode(string o)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(o));
        }
    }
}
