using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Urna.DTO
{
    class DTOAluno
    {
        int id_aluno;
        string Rn;
        string Modulo;
        string Curso;
        string Turma;
        string Senha; 
        public int Id_aluno { get => id_aluno; set => id_aluno = value; }
        public string Rn1 { get => Rn; set => Rn = value; }
        public string Modulo1 { get => Modulo; set => Modulo = value; }
        public string Curso1 { get => Curso; set => Curso = value; }
        public string Turma1 { get => Turma; set => Turma = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
    }
}