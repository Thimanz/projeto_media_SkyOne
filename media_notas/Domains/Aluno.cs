namespace media_notas.Domain
{
    public class Aluno
    {
        private string? _nome;
        public string? Nome { get => _nome; }

        private List<double> _notas = new List<double>(2);
        public List<double> Notas { get => _notas; }

        private double _media = 0;
        public double Media { get => _media; }

        private string? _status;
        public string? Status { get => _status; }

        public Aluno(string? nome)
        {
            _nome = nome;
        }

        public void AddNota(double nota)
        {
            _notas.Add(nota);
            _media = _notas.AsQueryable().Average();
            _status = _media >= 6.5 ? "Aprovado" : "Reprovado";
        }
    }
}
