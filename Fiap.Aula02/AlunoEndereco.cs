using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Fiap.Aula02
{
    public class AlunoEndereco : Aluno
    {
        [JsonPropertyName("logradouro")]
        public string LogradouroAluno { get; set; } 

        [JsonPropertyName("cep")]
        public string CepAluno { get; set; }

        [JsonPropertyName("uf")]
        public string UFAluno { get; set; }

        [JsonPropertyName("estado")]
        public string EstadoAluno { get; set; }

        [JsonPropertyName("bairro")]
        public string BairroAluno { get; set; }
    }
}
