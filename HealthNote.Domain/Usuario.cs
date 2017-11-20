namespace HealthNote.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string DocumentoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Apelido { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public string LoginUsu { get; set; }
        public string SenhaUsu { get; set; }
        public string Email { get; set; }

    }
}
