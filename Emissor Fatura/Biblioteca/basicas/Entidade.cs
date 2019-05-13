using Newtonsoft.Json;
using System;

namespace Biblioteca.basicas
{
    public abstract class Entidade 
    {
        public int Id { get ; set ; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

       
    }
}
          