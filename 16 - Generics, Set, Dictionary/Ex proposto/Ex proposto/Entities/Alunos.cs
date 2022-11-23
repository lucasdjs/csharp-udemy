using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_proposto.Entities
{
    internal class Alunos
    {
        public int Aluno { get; set; }

        public Alunos(int aluno)
        {
            Aluno = aluno;
        }


        public override int GetHashCode()
        {
            return Aluno.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Alunos))
            {
                return false;
            }

            Alunos other = obj as Alunos;

            return Aluno.Equals(other.Aluno);
        }
    }
}
