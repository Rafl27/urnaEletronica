using System;

    public class Prefeito : Candidato
    {
        public Prefeito(string nome, string partido, string cidade, int numero, int numeroDeVotos) : base(nome, partido, cidade, numero, numeroDeVotos)
        {
            this.nome = nome;
            this.partido = partido;
            this.cidade = cidade;
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
