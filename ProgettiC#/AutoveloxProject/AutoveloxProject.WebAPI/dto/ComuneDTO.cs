using Autovelox.Data.Models;

namespace AutoveloxProject.WebAPI.dto
{
    public class ComuneDTO
    {
        public int Id { get; set; }
        public string? Denominazione { get; set; }
        public string? CodiceCatastale { get; set; }

        public int? CapoluogoProvincia { get; set; }

        public string? ZonaAltimetrica { get; set; }

        public int? AltitudineCentro { get; set; }

        public int? ComuneLitoraneo { get; set; }

        public string? ComuneMontano { get; set; }

        public string? SuperficieTerritoriale { get; set; }

        public int? Popolazione2001 { get; set; }

        public int? Popolazione2011 { get; set; }
    }
}
