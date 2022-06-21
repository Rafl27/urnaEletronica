
public class Partido
{
    public string nome;
    public int votos;

    public Partido(string nome, int votos){
        this.nome = nome;
        this.votos = votos;
    }

    public string getNome(){
        return nome;
    }

    public int getVotos(){
        return votos;
    }
    public void setVotos(int votos){
        this.votos = this.votos + votos;
    }
}
