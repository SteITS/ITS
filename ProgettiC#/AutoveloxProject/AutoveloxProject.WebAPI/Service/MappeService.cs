using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Autovelox.Data.Models;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using AutoveloxProject.WebAPI.dto;

public class MappaService
{
    private AutoveloxContext _context;

    public MappaService(AutoveloxContext context)
    {
        _context = context;
    }

    public async Task<List<MappaDTO>> GetAllMappeAsync()
    {
        return await _context.Mappa
            .Include(m => m.IdComuneNavigation)
            .Select(m => new MappaDTO
            {
                Id = m.Id,
                Nome = m.Nome,
                AnnoInserimento = m.AnnoInserimento,
                DataOraInserimento = m.DataOraInserimento,
                IdentificatoreOpenStreetMap = m.IdentificatoreOpenStreetMap,
                Longitudine = m.Longitudine,
                Latitudine = m.Latitudine,
                ComuneNome = m.IdComuneNavigation != null ? m.IdComuneNavigation.Denominazione : null,
                ProvinciaNome = m.IdComuneNavigation.IdProvinciaNavigation != null ? m.IdComuneNavigation.IdProvinciaNavigation.Denominazione : null,
                RegioneNome = m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation != null ? m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation.Denominazione : null
            })
            .ToListAsync();
    }

    public async Task<List<MappaDTO>> GetMapsById(int id)
    {
        return await _context.Mappa
            .Include(m => m.IdComuneNavigation)
            .Select(m => new MappaDTO
            {
                Id = m.Id,
                Nome = m.Nome,
                AnnoInserimento = m.AnnoInserimento,
                DataOraInserimento = m.DataOraInserimento,
                IdentificatoreOpenStreetMap = m.IdentificatoreOpenStreetMap,
                Longitudine = m.Longitudine,
                Latitudine = m.Latitudine,
                ComuneNome = m.IdComuneNavigation != null ? m.IdComuneNavigation.Denominazione : null,
                ProvinciaNome = m.IdComuneNavigation.IdProvinciaNavigation != null ? m.IdComuneNavigation.IdProvinciaNavigation.Denominazione : null,
                RegioneNome = m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation != null ? m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation.Denominazione : null
            }).Where(m => m.Id == id)
            .ToListAsync();
    }

    public async Task<List<MappaDTO>> GetMapsByFilter(string? comune, string? provincia, string? regione)
    {
        var query = _context.Mappa
            .Include(m => m.IdComuneNavigation)
                .ThenInclude(c => c.IdProvinciaNavigation)
                    .ThenInclude(p => p.IdRegioneNavigation)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(comune))
        {
            query = query.Where(m => m.IdComuneNavigation.Denominazione.Contains(comune));
        }

        if (!string.IsNullOrWhiteSpace(provincia))
        {
            query = query.Where(m => m.IdComuneNavigation.IdProvinciaNavigation.Denominazione.Contains(provincia));
        }

        if (!string.IsNullOrWhiteSpace(regione))
        {
            query = query.Where(m => m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation.Denominazione.Contains(regione));
        }

        // Project to DTO to avoid circular references and unnecessary data
        return await query
            .Select(m => new MappaDTO
            {
                Id = m.Id,
                Nome = m.Nome,
                AnnoInserimento = m.AnnoInserimento,
                DataOraInserimento = m.DataOraInserimento,
                IdentificatoreOpenStreetMap = m.IdentificatoreOpenStreetMap,
                Longitudine = m.Longitudine,
                Latitudine = m.Latitudine,
                ComuneNome = m.IdComuneNavigation != null ? m.IdComuneNavigation.Denominazione : null,
                ProvinciaNome = m.IdComuneNavigation.IdProvinciaNavigation != null ? m.IdComuneNavigation.IdProvinciaNavigation.Denominazione : null,
                RegioneNome = m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation != null ? m.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation.Denominazione : null
            })
            .ToListAsync();
    }

}