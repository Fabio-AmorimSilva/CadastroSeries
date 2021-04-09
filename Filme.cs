using System;

namespace Series
{
    public class Filme : EntidadeBase
    {

        private Genero Genero{get; set;}
        private string Titulo{get; set;}
        private string Descricao{get; set;}
        private int Ano{get; set;}
        private bool Excluido{get; set;}
        private double Duracao{get; set;}

        public Filme(int id, Genero genero, string titulo, string descricao, int ano, double duracao){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Duracao = duracao;

        }

        public string retornaTitulo(){
            return this.Titulo;

        }

        public int retornaId(){
            return this.Id;

        }

        public double retornaDuracao(){
            return this.Duracao;

        }

        public string retornaDescricao(){
            return this.Descricao;

        }

        public void Excluir(){
            this.Excluido = true;

        }

        public bool retornaExcluido(){
            return this.Excluido;

        }

        public override string ToString(){

            string retorno = "";
            retorno += "#ID: " + this.retornaId() + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Duração: " + this.Duracao + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;

        }

        
    }
}