using SorteiosBFF.Domain.Entities;

namespace SorteiosBFF.Domain.Interfaces
{
    public interface ISorteioRepository
    {
        Task<List<Sorteio>> GetSorteiosAsync();
        Task<Vibes> GetVibesAsync();
    }
}