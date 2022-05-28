using System.Collections;

namespace projeto
{
    static class Candidatos
    {
        public static ArrayList names = new ArrayList();
        public static ArrayList sexs = new ArrayList();
        public static ArrayList ages = new ArrayList();
        public static ArrayList courses = new ArrayList();
        public static ArrayList biNumbers = new ArrayList();
        public static ArrayList inscritionNumbers = new ArrayList();
        public static ArrayList posicoesCandidatosEliminados = new ArrayList();
        public static int qtdMascEliminados = 0;
        public static int qtdFemEliminados = 0;

        public static void saveName(string name) {
            names.Add(name);
        }

        public static void saveSex(char sex) {
            sexs.Add(sex);
        }

        public static void saveAge(int age) {
            ages.Add(age);
        }

        public static void saveCourse(string course) {
            courses.Add(course);
        }

        public static void saveBiNumber(string biNumber) {
            biNumbers.Add(biNumber);
        }

        public static void saveInscritionNumber(int inscNum) {
            inscritionNumbers.Add(inscNum);
        }
    }
}
