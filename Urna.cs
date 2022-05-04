namespace trabalho1POO
{
    public class Urna
    {
        static int numeroDeCandidatos, op;
        Candidato[] candidatos = new Candidato[numeroDeCandidatos];
        string cidadeUrna = "";

        
        public static void Menu() {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Adicionar Candidatos");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op) {
                case 1 :
                Console.WriteLine("hello"); 
                break;
                default :
                Console.WriteLine("oi");
                break;
            }
        }

    }
}