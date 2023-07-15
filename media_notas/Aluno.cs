using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_notas
{
    internal class Aluno
    {
        private string? _nome;
        public string? Nome
        {
            get
            { return _nome; }
        }
        private List<double> _notas = new List<double>();
        public List<double> Notas
        {
            get { return _notas; }
        }

        public Aluno(string? nome) 
        {
            _nome = nome;
        }

        public void AddNota(double nota)
        {
            _notas.Add(nota);
        }
    }
}
