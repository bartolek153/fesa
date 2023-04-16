import math


def seno(valor_radianos: int):
    precisao_desejada = 10 ** (-9)
    precisao_desejada_alcancada = False

    k = 0

    x = valor_radianos
    f = 0

    while not precisao_desejada_alcancada:
        k += 1

        if (1 / math.factorial(k + 1)) * (x) ** (k + 1) < abs(precisao_desejada):
            precisao_desejada_alcancada = True

        if k % 2 == 0:
            continue

        elif k % 4 == 3:
            f += -1 / math.factorial(k) * (x) ** k

        else:
            f += 1 / math.factorial(k) * (x) ** k

    return f


def seno_array_pontos(valor_radianos: int):
    precisao_desejada = 10 ** (-9)
    precisao_desejada_alcancada = False

    k = 0

    x = valor_radianos
    f = 0

    while not precisao_desejada_alcancada:
        k += 1

        if (
            (1 / math.factorial(k + 1)) * (x) ** (k + 1) < abs(precisao_desejada)
        ).all():
            precisao_desejada_alcancada = True

        if k % 2 == 0:
            continue

        elif k % 4 == 3:
            f += -1 / math.factorial(k) * (x) ** k

        else:
            f += 1 / math.factorial(k) * (x) ** k

    return f
