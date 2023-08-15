from funcao_f import funcao_f


def metodo_dicotomia(alpha, beta, a, b, precisao_desejada):
    """
    Função que implementa o método da dicotomia para encontrar uma estimativa

    Entradas:
             alpha: último algarismo do seu RA (necessário para
             o cálculo de f(x))

             beta: penúltimo algarismo do seu RA (necessário para
             o cálculo de f(x))

             a: extremo inferior do intervalo inicial

             b: extremo superior fo intervalo inicial

             precisao_desejada: precisão com que se deseja conhecer a raiz
    """

    # Calculo do erro maximo considerando o intervalo inicial:
    erro_max = b - a

    # Inicialização do numero de iteracoes:
    numero_iteracoes = 0

    # Enquanto o erro maximo cometido for maior que a precisão desejada, faça:
    while erro_max > precisao_desejada:
        # Variável fa recebe o valor da função f calculada em a:
        fa = funcao_f(alpha, beta, a)
        fb = funcao_f(alpha, beta, b)
        f_medio = funcao_f(alpha, beta, (a + b) / 2)

        if f_medio > 0 and fa > 0 and fb < 0:
            a = (a + b) / 2
        elif f_medio < 0 and fa > 0 and fb < 0:
            b = (a + b) / 2

        numero_iteracoes += 1
        erro_max = (b - a) / 2

    # Calculo da estimativa final
    estimativa_final = (a + b) / 2

    # Impressão do número de iterações na tela
    print("Número de iterações: ", numero_iteracoes)

    # Função retorna o valor da estimativa final:
    return estimativa_final
