
namespace tabuleiro
{
    class Posicao
    {   //Classe Posicao
        public int linha { get; set;}
        public int coluna { get; set; }

        public Posicao (int linha, int coluna) //Construtor da Classe
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores (int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //Convertendo para to String
        public override string ToString()
        {
            return linha
                + " , "
                + coluna;               
        }

    }
}

