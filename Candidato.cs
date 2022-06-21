using System;


     public class Candidato
    {
        public string nome, partido, cidade;
        public int numero, numeroDeVotos, idade;

        public Candidato(string nome, string partido, int idade, int numero, int numeroDeVotos)
        {
            this.nome = nome;
            this.partido = partido;
            this.numero = numero;
            this.numeroDeVotos = numeroDeVotos;
            this.idade = idade;
        }

        public Candidato(string nome, string partido, string cidade, int numero, int numeroDeVotos)
        {
            this.nome = nome;
            this.partido = partido;
            this.cidade = cidade;
            this.numero = numero;
            this.numeroDeVotos = numeroDeVotos;
        }

       public Candidato () {
         
       }

         public virtual string getNome(){
            return nome;
        }
        public virtual void setNome(string nome){
            this.nome = nome;
        } 
        public virtual string getPartido(){
            return partido;
        }
        public virtual void setPartido(string partido){
            this.partido = partido;
        }

        public virtual string getCidade(){
            return cidade;
        }
        public virtual void setCidade(string cidade){
            this.cidade = cidade;
        }

        public virtual int getNumero(){
            return numero;
        }
        public virtual void setNumero(int numero){
            this.numero = numero;
        }
        
        public virtual int getNumeroDeVotos(){
            return numeroDeVotos;
        }
        public virtual void setNumeroDeVotos(int numeroDeVotos){
            this.numeroDeVotos = numeroDeVotos;
        }

       public virtual int getIdade() 
        {
            return idade;
        }
    




        /* object.Name = "calanguinho";
        Console.WriteLine("Nome:" + object.Name); */

        /* public string Name { get; set; }
        public string Partido { get; set; }
        public string cidade { get; set; }
        public int numero { get; set; }
        public int numeroDeVotos { get; set; } */



    }
