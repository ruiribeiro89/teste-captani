
using SorteiosBFF.Domain.Enums;

namespace SorteiosBFF.Application.DTOs
{
    public class SorteioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EStatusConcurso StatusConcurso { get; set; }
        public int NumerosDaSorte { get; set; }
        public List<DadosNumerosSorteDto> NumerosSorte { get; set; }
        public string NumeroSorteado { get; set; }
        public DateTime? DataResultado { get; set; }
        public string ResultadoStatus { get; set; }
    }

    public class DadosNumerosSorteDto
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
    }
}
