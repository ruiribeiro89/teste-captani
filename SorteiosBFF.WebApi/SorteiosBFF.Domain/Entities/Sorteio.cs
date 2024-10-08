
using SorteiosBFF.Domain.Enums;

namespace SorteiosBFF.Domain.Entities
{
    public class Sorteio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EStatusConcurso StatusConcurso { get; set; }
        public int NumerosDaSorte { get; set; }
        public List<DadosNumerosSorte> NumerosSorte { get; set; }
        public string NumeroSorteado { get; set; }
        public DateTime? DataResultado { get; set; }
        public string ResultadoStatus { get; set; }
    }

    public class DadosNumerosSorte
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
    }
}