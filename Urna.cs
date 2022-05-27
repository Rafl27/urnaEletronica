namespace trabalho1POO
{
    public class Urna
    {


        static int numeroDeCandidatos = 4, op;
        static Candidato[] candidatos = new Candidato[numeroDeCandidatos];
        string cidadeUrna = "";
        public static void Menu()
        {

            Stream entrada = File.Open("teste1.txt", FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);

            Console.WriteLine("Menu");
            Console.WriteLine("1. Cadastrar eleição");
            Console.WriteLine("2. Adicionar Candidatos");
            Console.WriteLine("Nº de candidatos");
            numeroDeCandidatos = Convert.ToInt32(Console.ReadLine());
            string linha = ;
            op = linha;

            switch (op)
            {
                case "1":
                    cadastrarEleicao();
                    break;
                // case "2":
                //     cadastrarEleicao();
                //     break;
                default:
                    Console.WriteLine("e aí?");
                    break;
            }

        }

        public static void cadastrarEleicao()
        {
            int op2 = Console.ReadLine();
            Console.WriteLine("Tipo de eleição");
            Console.WriteLine("1. Legislativo");
            //vereador
            Console.WriteLine("2. Executivo");
            if (op2 == 1)
            {
                registraVereador();
            }
            else
            {
                Console.WriteLine("e ai");
            }
        }

        public static void registraVereador()
        {

            Vereador[] arrayVereadores = new Vereador[5];
            string linha = leitor.ReadLine();
            string[] candidato = linha.Split(";");
            for (int i = 0; i < arrayVereadores.Length; i++)
            {
                arrayVereadores[i] = new Vereador(candidato[0], candidato[1], candidato[2], candidato[3], candidato[4]);
                Console.WriteLine(arrayVereadores[i].nome);
            }
        }

    }
}
