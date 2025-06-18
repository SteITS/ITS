using Autovelox.Data.Models;

namespace AutoveloxProject.WebAPI.dto
{
    public class ProvinciaComuneDTO
    {
        public int Id { get; set; }
        public int IdRegione { get; set; }
        public string? DenominazioneProvincia { get; set; }
        public string? Sigla { get; set; }
        public List<ComuneDTO> Comunes { get; set; } = new List<ComuneDTO>();
    }
}
