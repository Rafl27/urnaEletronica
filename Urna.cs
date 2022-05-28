using System;
using System.IO;

    class Urna
    {
        static int numeroDeCandidatos = 5, op, cont = 0;
        static Candidato[] candidatos = new Candidato[numeroDeCandidatos];
        string cidadeUrna = "";
        
        public Urna()
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("--------Menu--------");
            Console.WriteLine("1. Cadastrar eleição");
            Console.WriteLine("2. Adicionar Candidatos");
            Console.WriteLine("Nº de candidatos");
            Console.Write("\nOpção: ");
            //numeroDeCandidatos = Convert.ToInt32(Console.ReadLine());
            op =  int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
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
            Console.WriteLine("\n--------Tipo de eleição--------");
            Console.WriteLine("1. Legislativo");
            //vereador
            Console.WriteLine("2. Executivo");
            Console.Write("\nOpção: ");
            int op2 = int.Parse(Console.ReadLine());
            switch (op2)
            {
                case 1:
                    registraVereador();
                    break;
                case 2:
                    registraPrefeito();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }


        public static void registraVereador()
        {
            Stream VencedorVereador = File.Open("VencedorVereador.txt", FileMode.Create);
            StreamWriter VencedorV = new StreamWriter(VencedorVereador);
        
            Vereador[] arrayVereadores = new Vereador[5];
            string linha = "";
            Stream entrada = File.Open("candidatosVereador.txt",FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);
            linha = leitor.ReadLine();

            while (linha != null)
            {
                string[] candidato = linha.Split(';');
                arrayVereadores[cont] = new Vereador(candidato[0], candidato[1], candidato[2], int.Parse(candidato[3]), int.Parse(candidato[4]));
                Console.WriteLine(arrayVereadores[cont].numeroDeVotos);
                linha = leitor.ReadLine();
                cont++;
            }

            VencedorV.Write("O vencedor entre os Vereadores é o(a): " + Resultado(arrayVereadores));
            entrada.Close();
            VencedorV.Close();
            VencedorVereador.Close();
            leitor.Close();
        }

        public static void registraPrefeito()
        {
            Stream VencedorPrefeito = File.Open("VencedorPrefeito.txt", FileMode.Create);
            StreamWriter VencedorP = new StreamWriter(VencedorPrefeito);
            
            Prefeito[] arrayPrefeitos = new Prefeito[5];
            string linha = "";
            Stream entrada = File.Open("candidatosPrefeito.txt",FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);
            linha = leitor.ReadLine();

            while (linha != null)
            {
                string[] candidato = linha.Split(';');
                arrayPrefeitos[cont] = new Prefeito(candidato[0], candidato[1], candidato[2], int.Parse(candidato[3]), int.Parse(candidato[4]));
                Console.WriteLine(arrayPrefeitos[cont].numeroDeVotos);
                linha = leitor.ReadLine();
                cont++;
            }

            VencedorP.Write("O vencedor entre os Prefeitos é o(a): " + Resultado(arrayPrefeitos));
            entrada.Close();
            VencedorP.Close();
            VencedorPrefeito.Close();
            leitor.Close();

        }

        public static string Resultado(Candidato[] x)
        {
            int i = 0, votos = 0;
            string vencedor = "";
            for(i = 0; i < x.GetLength(0); i++)
            {
                if(x[i].numeroDeVotos > votos)
                {
                    votos = x[i].numeroDeVotos;
                    vencedor = x[i].nome;
                }
            }
            return vencedor;
        }
    }

