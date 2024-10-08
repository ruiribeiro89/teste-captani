namespace SorteiosBFF.Application.DTOs
{
    public class SorteiosResponseDto
    {
        public List<SorteioDto> Sorteios { get; set; }
        public VibesDto Vibes { get; set; }
        public ParticipeSorteioDto ParticipeSorteio { get; set; }
    }
    public class ParticipeSorteioDto
    {
        public string RegrasParticipacao { get; set; }
        public string LinkImagemParticipacao { get; set; }
        public string LinkCadastroParticipeSorteio { get; set; }
    }
}