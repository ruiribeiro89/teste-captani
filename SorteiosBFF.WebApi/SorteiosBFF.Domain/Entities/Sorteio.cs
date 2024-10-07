
namespace SorteiosBFF.Domain.Entities
{
    public class Sorteio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroSorteado { get; set; }
        public DateTime DataResultado { get; set; }
        public int NumerosDaSorte { get; set; }
    }
}