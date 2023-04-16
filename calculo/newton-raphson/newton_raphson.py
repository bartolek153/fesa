from funcao_f import funcao_f as f1
from funcao_f_linha import funcao_f_linha as f2


def implementacao(x0, delta1, delta2, alpha, beta):
    iteracoes = 0

    while True:
        iteracoes += 1

        x = x0 - (f1(alpha, beta, x0) / f2(x0))

        if abs(x - x0) < delta1 or abs(f1(alpha, beta, x)) < delta2:
            break

        x0 = x

    print(f"O método convergiu após {iteracoes} iterações.")

    return x
