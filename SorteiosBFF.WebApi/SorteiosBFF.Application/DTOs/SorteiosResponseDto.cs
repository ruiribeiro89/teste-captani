namespace SorteiosBFF.Application.DTOs
{
    public class SorteiosResponseDto
    {
        public List<SorteioDto> Sorteios { get; set; }
        public VibesDto Vibes { get; set; }
        public string RegrasParticipacao { get; set; }
    }
}
