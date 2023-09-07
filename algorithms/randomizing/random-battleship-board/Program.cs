namespace BatalhaNaval 
{
    static class Program
    {

        // retorna verdadeiro se 
        // - a posicao sorteada estiver dentro dos limites do tabuleiro 
        // - ou se ainda restam tropas do navio sorteado no Strike Group
        static bool teste_dentro_do_intervalo(int posicaoSorteada, int comprimentoNavio, int IDstrikeGroup) { 
            return (posicaoSorteada + comprimentoNavio >= 60 || IDstrikeGroup == 0) ;
        }

        // retorna verdadeiro se
        // - a posicao sorteada ja estiver sido ocupada por um outro navio
        static bool teste_sobreposicao(int posicaoSorteada, int comprimentoNavio, char[] tabuleiro) {
            
            for (int i = posicaoSorteada; i < (posicaoSorteada + comprimentoNavio); i++) {
                if (tabuleiro [i] != '-')
                    return true;
            }

            return false;
        }

        static char inicialNavio(int navioSorteado) {

            switch (navioSorteado) {
                case 2:
                    return 'S';
                case 3:
					return 'D';
				case 4:
					return 'C';
				case 5:
					return 'P';
            }

            return '\0';
        }

        static void Main() {

            char[] tabuleiro = new char[60];
            Array.Fill(tabuleiro, '-'); // Preenche tabuleiro com o caracter '-', que representa a agua

            // Espacos que cada navio ocupa: S(2) | D(3) | C(4) | P(5)
            int[] navios = new int[] { 2, 3, 4, 5 };

            // Quantidades: S(3) | D(3) | C(2) | P(1) 
			int[] strikeGroup = new int[] { 3, 3, 2, 1 };

            // Numero total de navios no jogo
            int total = strikeGroup[0] + strikeGroup[1] + strikeGroup[2] + strikeGroup[3];

			
            // Variaveis a serem utilizadas ao longo do programa
            int index, navio, posicao;
            Random rnd = new Random();


			while (total != 0) {
                index = rnd.Next(0, navios.Length);
				navio = navios[index];

				posicao = rnd.Next(0, 60);

				if (teste_dentro_do_intervalo(posicao, navio, strikeGroup[index]))
					continue;

				if (teste_sobreposicao(posicao, navio, tabuleiro))
                	continue;

				strikeGroup[index]--;
				total--;

				for (int i = posicao; i < (posicao + navio); i++)
					tabuleiro[i] = inicialNavio(navio);
			}

            var final = new Design();
            final.FrontEnd(tabuleiro);
        }
    }
}

