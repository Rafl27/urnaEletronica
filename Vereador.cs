using System;

    public class Vereador : Candidato
    {
        public Vereador(string nome, string partido, int idade, int numero, int numeroDeVotos) : base(nome, partido, idade, numero, numeroDeVotos)
        {
            this.nome = nome;
            this.partido = partido;
            this.numero = numero;
            this.numeroDeVotos = numeroDeVotos;
        }

        public override string getNome()
        {
            return nome;
        }
        public override void setNome(string nome)
        {
            this.nome = nome;
        }
        public override string getPartido()
        {
            return partido;
        }
        public override void setPartido(string partido)
        {
            this.partido = partido;
        }

        public override string getCidade()
        {
            return cidade;
        }
        public override void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public override int getNumero()
        {
            return numero;
        }
        public override void setNumero(int numero)
        {
            this.numero = numero;
        }

        public override int getNumeroDeVotos()
        {
            return numeroDeVotos;
        }
        public override void setNumeroDeVotos(int numeroDeVotos)
        {
            this.numeroDeVotos = numeroDeVotos;
        }

        
    }
