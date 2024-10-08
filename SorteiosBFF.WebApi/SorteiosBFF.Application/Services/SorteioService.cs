﻿using SorteiosBFF.Application.DTOs;
using SorteiosBFF.Domain.Interfaces;

namespace SorteiosBFF.Application.Services
{
    public class SorteioService
    {
        private readonly ISorteioRepository _repository;

        public SorteioService(ISorteioRepository repository)
        {
            _repository = repository;
        }

        public async Task<SorteiosResponseDto> ObterDadosSorteiosAsync()
        {
            var sorteios = await _repository.GetSorteiosAsync();
            var vibes = await _repository.GetVibesAsync();

            return new SorteiosResponseDto
            {
                Sorteios = sorteios.Select(s => new SorteioDto
                {
                    Id = s.Id,
                    Nome = s.Nome,
                    StatusConcurso = s.StatusConcurso,
                    NumerosSorte = s.NumerosSorte.Select(ns => new DadosNumerosSorteDto
                    {
                        Numero = ns.Numero,
                        Data = ns.Data
                    }).ToList(),
                    NumeroSorteado = s.NumeroSorteado,
                    DataResultado = s.DataResultado,
                    NumerosDaSorte = s.NumerosDaSorte,
                    ResultadoStatus = s.ResultadoStatus
                }).ToList(),
                Vibes = new VibesDto
                {
                    VibesAcumuladas = vibes.VibesAcumuladas,
                    VibesRestantesParaNumeroDaSorte = vibes.VibesRestantesParaNumeroDaSorte
                },
                ParticipeSorteio = new ParticipeSorteioDto
                {
                    RegrasParticipacao = "Para tornar sua participacao no vibe...",
                    LinkCadastroParticipeSorteio = "link.direcionacadastro",
                    LinkImagemParticipacao = "baixarimagem.com",
                }
            };
        }
    }
}
