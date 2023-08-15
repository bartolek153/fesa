import math

def funcao_f(alpha, beta, x):
    """
    Entrada: valor de x para o qual desejamos obter o valor de
    f(x) = x^(beta+1) + sen(x) - (alpha+1)/10

    Retorna o valor da função f para o valor de x recebido na entrada
    """

    return (x ** (beta + 1)) + math.sin(x) - (alpha + 1) / 10

