
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        //metodo para acessar um peça, pois a Classe Peça é privada
        public Peca peca(int linha, int coluna) //Construtor da peca
        {
            return pecas[linha, coluna];
        }
        //sobrecarga --> Construtora com paramentro posicao
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca (Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        
        public void colocarPeca(Peca p , Posicao pos) // Metodo de colocar peca pois o atributo eh privado
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        //Metodo para testar se a posicao eh valida
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao (Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }

        }
    }
}
