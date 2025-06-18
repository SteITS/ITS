namespace AutoveloxProject.WebAPI.dto
{
    public class MappaDTO
    {
        public int Id { get; set; }

        public int? IdComune { get; set; }

        public string? Nome { get; set; }

        public int AnnoInserimento { get; set; }

        public DateTime DataOraInserimento { get; set; }

        public double IdentificatoreOpenStreetMap { get; set; }

        public decimal Longitudine { get; set; }

        public decimal Latitudine { get; set; }

        public string? ComuneNome { get; set; }
        public string? ProvinciaNome { get; set; }
        public string? RegioneNome { get; set; }
    }
}
