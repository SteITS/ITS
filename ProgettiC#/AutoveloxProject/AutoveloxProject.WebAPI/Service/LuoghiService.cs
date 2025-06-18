using Autovelox.Data.Models;
using AutoveloxProject.WebAPI.dto;
using Microsoft.EntityFrameworkCore;

namespace AutoveloxProject.WebAPI.Service
{
    public class LuoghiService
    {
        private AutoveloxContext _context;

        public LuoghiService(AutoveloxContext context)
        {
            _context = context;
        }

        public async Task<List<Regione>> GetAllRegioniAsync()
        {
            return await _context.Regione.ToListAsync();
        }

        public async Task<List<Provincia>> GetAllProvinceAsync()
        {
            return await _context.Provincia.ToListAsync();
        }

        public async Task<List<Comune>> GetAllComuniAsync()
        {
            return await _context.Comune.ToListAsync();
        }

        public async Task<List<Provincia>> GetProvinceByRegione(string regione)
        {
            return await _context.Provincia
                    .Where(p => p.IdRegioneNavigation.Denominazione == regione)
                    .ToListAsync();
        }

        public async Task<List<Comune>> GetComuniByProvincia(string provincia)
        {
            return await _context.Comune
                    .Where(p => p.IdProvinciaNavigation.Denominazione == provincia)
                    .ToListAsync();
        }

        //public async Task<List<Comune>> GetDTOByRegione(string regione)
        //{
        //    return await _context.Comune
        //        .Include(m => m.IdProvinciaNavigation)
        //        .Select(m => new ProvinciaComuneDTO
        //        {
        //            Id = (int)m.IdProvincia,
        //            IdRegione = m.IdProvinciaNavigation.IdRegioneNavigation.Id,
        //            DenominazioneProvincia = m.Denominazione,
        //            Sigla = m.IdProvinciaNavigation.Sigla
        //            Comunes = _context.Comune.Where(m => m.IdProvinciaNavigation.IdRegioneNavigation.Denominazione == regione).ToListAsync()

        //        })
        //            .Where(p => m.IdProvinciaNavigation.IdRegioneNavigation.Denominazione == regione)
        //            .ToListAsync();
        //}

        public async Task<List<ProvinciaComuneDTO>> GetDTOByRegione(string regione)
        {
            var provinces = await _context.Provincia
                .Include(p => p.Comunes) // Make sure Provincia entity has navigation property "Comunes"
                .Where(p => p.IdRegioneNavigation.Denominazione == regione)
                .Select(p => new ProvinciaComuneDTO
                {
                    Id = p.Id,
                    IdRegione = p.IdRegioneNavigation.Id,
                    DenominazioneProvincia = p.Denominazione,
                    Sigla = p.Sigla,
                    Comunes = p.Comunes.Select(c => new ComuneDTO
                    {
                        Id = (int)c.IdProvincia,
                        Denominazione = c.Denominazione,
                        CodiceCatastale = c.CodiceCatastale,
                        CapoluogoProvincia = c.CapoluogoProvincia,
                        ZonaAltimetrica = c.ZonaAltimetrica,
                        AltitudineCentro = c.AltitudineCentro,
                        ComuneLitoraneo = c.ComuneLitoraneo,
                        ComuneMontano = c.ComuneMontano,
                        SuperficieTerritoriale = c.SuperficieTerritoriale,
                        Popolazione2001 = c.Popolazione2001,
                        Popolazione2011 = c.Popolazione2011

                    }).ToList()
                })
                .ToListAsync();

            return provinces;
        }

    }
}
