namespace HealthNote.Domain
{
    public class Medicamento
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Medico { get; set; }
        public string Indicacao { get; set; }
        public string PrincipioAtivo { get; set; }
        public string AcaoTerapeutica { get; set; }
        public string Laboratorio { get; set; }
        public string Obs { get; set; }

    }
}
