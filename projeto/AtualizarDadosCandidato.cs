using System;

namespace projeto
{
    class AtualizarDadosCandidato
    {
        private string name, course;
        private char sex;
        private int age, inscNum;

        public AtualizarDadosCandidato(string nome, string curso, char sexo, int idade, int numInsc) {
            this.name = nome;
            this.course = curso;
            this.sex = sexo;
            this.age = idade;
            this.inscNum = numInsc;
        }

        public void updateName() {
            Candidatos.names[inscNum] = this.name;
        }

        public void updateSex() {
            Candidatos.sexs[inscNum] = this.sex;
        }

        public void updateAge() {
            Candidatos.ages[inscNum] = this.age;
        }

        public void updateCourse() {
            Candidatos.courses[inscNum] = this.course;
        }
    }
}
