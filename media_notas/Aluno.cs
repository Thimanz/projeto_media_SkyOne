using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_notas
{
    public class Aluno
    {
        private string? _nome;
        public string? Nome { get => _nome; }

        private List<double> _notas = new List<double>(2);

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
            _media = Queryable.Average(_notas.AsQueryable());
            _status = _media >= 6.5 ? "Aprovado" : "Reprovado";
        }
    }
}
