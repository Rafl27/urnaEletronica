namespace trabalho1POO
{
    public class Urna
    {
        static int numeroDeCandidatos, op;
        Candidato[] candidatos = new Candidato[numeroDeCandidatos];
        string cidadeUrna = "";


        public static void Menu()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Adicionar Candidatos");
            Console.WriteLine("Nº de candidatos");
            numeroDeCandidatos = Convert.ToInt32(Console.ReadLine());
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    AdicionarCandidatos();
                    break;
                default:
                    Console.WriteLine("e aí?");
                    break;
            }
        }

        public static void AdicionarCandidatos(Candidato candidatoInfo)
        {
            for(int i = 0; i < )
            Console.WriteLine($"Insira o nome do {i}º Candidato");
            candidatos[i] = candidatoInfo;

        }

    }
}