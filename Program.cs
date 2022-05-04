namespace trabalho1POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("teste");
            Candidato c = new Candidato("rafael", "verde", "brumadinho", 70, 1000);
            Console.WriteLine(c.getCidade());
            c.setCidade("BH");
            Console.Write(c.getCidade());
            Urna.Menu();
        }
    }
}
