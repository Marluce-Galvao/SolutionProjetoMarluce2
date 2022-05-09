using System.Collections.Generic;

namespace Domain.Dtos.Endereco
{
    public class ConsultaEnderecoDto
    {
        public ConsultaEnderecoDto(IEnumerable<EnderecoDto> endereco)
        {
            Endereco = endereco;
        }

        public IEnumerable<EnderecoDto> Endereco { get; private set; }
    }
}
