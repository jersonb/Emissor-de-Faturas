
namespace Biblioteca.basicas
{
    public class Cliente : Entidade
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }

        public string InscMunicipal { get; set; }
        public string Endereco { get; set; }
        public string Uf { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoMunicipio { get; set; }
        public string EnderecoBairro { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
