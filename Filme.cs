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

        public Filme(Genero genero, string titulo, string descricao, int ano, bool excluido, double duracao){
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = excluido;
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

        
    }
}