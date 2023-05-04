import math

# 1) Desenvolva um algoritmo que calcule numericamente
#    as integrais abaixo descritas entre [0,1]:

"""
    a) f(x) = x^3 - 2x^2 + 8;

    b) f(x) = cos(3x);
        
    c) f(x) = e^(2x)

"""

# 2) Para a função f(x) = 3x^2 + e^x, determine:

"""
    o valor da integral de f(x) entre [0,1]
"""

INTERVALO = (0, 1)
SEGMENTOS = 100000


def _1a(x):
    return x**3 - (2 * x**2) + 8


def _1b(x):
    return math.cos(3 * x)  # assumindo x em radianos


def _1c(x):
    return math.e ** (2 * x)


def _2a(x):
    return 3 * x**2 + math.e**x



variacao = (INTERVALO[1] - INTERVALO[0]) / SEGMENTOS


def CalculaIntegral(funcao):

    y = funcao  # funcao a ser integrada
    x = INTERVALO[0]
    
    _resultado = 0

    while x <= INTERVALO[1]:
        resultado += variacao * y(x)
        x += variacao

    return round(_resultado, 5)


print(CalculaIntegral(_1a))
print(CalculaIntegral(_1b))
print(CalculaIntegral(_1c))
print(CalculaIntegral(_2a))