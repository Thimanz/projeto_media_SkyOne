using media_notas.Domain;
using media_notas.Repositories;

namespace media_notas.Services
{
    public class AlunoService
    {
        private readonly AlunoRepository _alunoRepository;
        public AlunoService()
        {
            _alunoRepository = new AlunoRepository();
        }

        public void SalvarAluno(Aluno aluno)
        {
            _alunoRepository.SalvarAluno(aluno);
        }
    }
}
