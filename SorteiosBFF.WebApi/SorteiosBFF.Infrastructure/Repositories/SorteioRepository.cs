using SorteiosBFF.Domain.Entities;
using SorteiosBFF.Domain.Enums;
using SorteiosBFF.Domain.Interfaces;

namespace SorteiosBFF.Infrastructure.Repositories
{
    public class SorteioRepository : ISorteioRepository
    {
        public Task<List<Sorteio>> GetSorteiosAsync()
        {
            var sorteios = new List<Sorteio>
            {
                new Sorteio
                {
                    Id = 1,
                    Nome = "Sorteio N° 1",
                    StatusConcurso = EStatusConcurso.NaoFoiDessaVez,
                    NumerosDaSorte = 4,
                    NumerosSorte = new List<DadosNumerosSorte>
                    {
                        new DadosNumerosSorte { Numero = "62091", Data = new DateTime(2024, 06, 18) },
                        new DadosNumerosSorte { Numero = "94920", Data = new DateTime(2024, 06, 25) },
                        new DadosNumerosSorte { Numero = "27171", Data = new DateTime(2024, 06, 26) },
                        new DadosNumerosSorte { Numero = "75947", Data = new DateTime(2024, 06, 26) }
                    },
                    NumeroSorteado = "85968",
                    DataResultado = new DateTime(2024, 07, 27),
                    ResultadoStatus = "Sorteio realizado em 27/07/2024"
                },
                new Sorteio
                {
                    Id = 2,
                    Nome = "Sorteio N° 2",
                    StatusConcurso = EStatusConcurso.Concorrendo,
                    NumerosDaSorte = 5,
                    NumerosSorte = new List<DadosNumerosSorte>(),
                    NumeroSorteado = "Em breve",
                    DataResultado = new DateTime(2024, 08, 02),
                    ResultadoStatus = "Resultado até 02/10/2024"
                },
                new Sorteio
                {
                    Id = 3,
                    Nome = "Sorteio N° 3",
                    StatusConcurso = EStatusConcurso.Concorrendo,
                    NumerosDaSorte = 5,
                    NumerosSorte = new List<DadosNumerosSorte>(),
                    NumeroSorteado = "Em breve",
                    DataResultado = new DateTime(2024, 10, 02),
                    ResultadoStatus = "Resultado até 02/10/2024"
                }
            };

            return Task.FromResult(sorteios);
        }

        public Task<Vibes> GetVibesAsync()
        {
            var vibes = new Vibes
            {
                VibesAcumuladas = 7,
                VibesRestantesParaNumeroDaSorte = 23
            };
            return Task.FromResult(vibes);
        }
    }
}
