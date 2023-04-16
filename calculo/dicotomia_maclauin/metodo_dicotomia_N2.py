from funcao_f_N2 import funcao_f_N2


def metodo_dicotomia_N2(alpha, beta, a, b, precisao_desejada):
    """
    Entradas:
            alpha: último algarismo do seu RA (necessário para
            o cálculo de f(x))

            beta: penúltimo algarismo do seu RA (necessário para
            o cálculo de f(x))

            a: extremo inferior do intervalo inicial

            b: extremo superior fo intervalo inicial
            precisao_desejada: precisão com que se deseja conhecer a raiz
    """

    erro_max = b - a

    numero_iteracoes = 0

    while erro_max > precisao_desejada:
        fa = funcao_f_N2(alpha, beta, a)
        fb = funcao_f_N2(alpha, beta, b)
        f_medio = funcao_f_N2(alpha, beta, (a + b) / 2)

        if f_medio * fa > 0 and f_medio * fb < 0:
            a = (a + b) / 2
        elif f_medio * fa < 0 and f_medio * fb > 0:
            b = (a + b) / 2

        numero_iteracoes += 1
        erro_max = (b - a) / 2

    estimativa_final = (a + b) / 2

    print(
        f"O número de iterações necessarias para determinar a estimativa final foi de {numero_iteracoes}"
    )

    return estimativa_final
