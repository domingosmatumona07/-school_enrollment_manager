using System.IO;

namespace projeto
{
    class GuardaDadosCandidato
    {
        private string name, biNumber, course, insc;
        private int age, inscritionNumber;
        private char sex;

        StreamWriter candidatos = new StreamWriter(@"candidatos.txt", true);

        public GuardaDadosCandidato(string name, string course, char sex, int age, string biNumber, int inscritionNumber) {
            this.name = name;
            this.course = course;
            this.sex = sex;
            this.age = age;
            this.biNumber = biNumber;
            this.inscritionNumber = inscritionNumber;
        }

        public void saveInscritionNumber() {
            candidatos.Close();
            StreamReader numeroInscricao = new StreamReader(@"candidatos.txt");

            while (!numeroInscricao.EndOfStream)
            {
                this.insc = numeroInscricao.ReadLine();
                inscritionNumber++;
            }

            numeroInscricao.Close();

            this.candidatos = new StreamWriter(@"agenda.txt", true);

            candidatos.Write(++this.inscritionNumber + " - ");
        }

        public void saveName() {
            candidatos.Write(this.name + " ");
        }

        public void saveSex() {
            candidatos.Write(this.sex + " ");
        }

        public void saveAge() {
            candidatos.Write(this.age + " ");
        }

        public void saveCourse() {
            candidatos.Write(this.course + " ");
        }

        public void saveBiNumber() {
            candidatos.Write(this.biNumber);
            candidatos.WriteLine();
            candidatos.Close();
        }
    }
}