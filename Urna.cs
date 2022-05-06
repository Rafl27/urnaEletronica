namespace trabalho1POO
{
    public class Urna
    {
        static int numeroDeCandidatos = 4, op;
        static Candidato[] candidatos = new Candidato[numeroDeCandidatos];
        string cidadeUrna = "";
        public static void Menu()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Cadastrar eleição");
            Console.WriteLine("2. Adicionar Candidatos");
            Console.WriteLine("2. ");
            Console.WriteLine("Nº de candidatos");
            numeroDeCandidatos = Convert.ToInt32(Console.ReadLine());
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    AdicionarCandidatos();
                    break;
                case 2:
                    cadastrarEleicao();
                    break;
                default:
                    Console.WriteLine("e aí?");
                    break;
            }
        }

        public static void cadastrarEleicao()
        {
            Console.WriteLine("Tipo de eleição");
            Console.WriteLine("1. Legislativo");
            Console.WriteLine("2. Executivo");
        }

    }
}