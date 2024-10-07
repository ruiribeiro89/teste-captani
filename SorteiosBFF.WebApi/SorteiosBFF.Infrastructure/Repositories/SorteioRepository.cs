using SorteiosBFF.Domain.Entities;
using SorteiosBFF.Domain.Interfaces;

namespace SorteiosBFF.Infrastructure.Repositories
{
    public class SorteioRepository : ISorteioRepository
    {
        public Task<List<Sorteio>> GetSorteiosAsync()
        {
            var sorteios = new List<Sorteio>
            {
                new Sorteio { Id = 1, Nome = "Sorteio N° 1", NumeroSorteado = "85968", DataResultado = new DateTime(2024, 07, 27), NumerosDaSorte = 4 },
                new Sorteio { Id = 2, Nome = "Sorteio N° 2", NumeroSorteado = "Em breve", DataResultado = new DateTime(2024, 08, 02), NumerosDaSorte = 5 }
            };

            return Task.FromResult(sorteios);
        }

        public Task<Vibes> GetVibesAsync()
        {
            var vibes = new Vibes { VibesAcumuladas = 7, VibesRestantesParaNumeroDaSorte = 23 };
            return Task.FromResult(vibes);
        }
    }
}
