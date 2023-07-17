using media_notas.Domain;
using MySql.Data.MySqlClient;

namespace media_notas.Repositories
{
    public class AlunoRepository
    {
        public void SalvarAluno(Aluno aluno)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=root;database=alunosdb";
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string sql = @$"insert into t_aluno (nome, nota1, nota2, media, status) values 
                             ('{aluno.Nome}', {aluno.Notas[0]}, {aluno.Notas[1]}, {aluno.Media}, '{aluno.Status}')";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}

