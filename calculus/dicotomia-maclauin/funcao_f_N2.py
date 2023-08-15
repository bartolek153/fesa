import math
import numpy as np

from calculo_seno import *


def funcao_f_N2(alpha, beta, x):
    """
    Entrada: valor de x para o qual desejamos obter o valor de
    f(x) = x^(beta+1) + sen(x) - (alpha+1)/10

    Retorna o valor da função f para o valor de x recebido na entrada
    """

    if isinstance(x, np.ndarray):
        f = (x ** (beta + 1)) + seno_array_pontos(x) - (alpha + 1) / 10

    else:
        f = (x ** (beta + 1)) + seno(x) - (alpha + 1) / 10

    return f
