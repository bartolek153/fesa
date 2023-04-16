from newton_raphson import implementacao

RA = 81220004

# Estimativa Inicial
x0 = -0.5

# Definição da precisão desejada
delta1 = delta2 = 10 ** (-9)

# Cálculo da estimativa usando a função "metodo_newton_raphson"
beta = 0
alpha = 4

estimativa = implementacao(x0, delta1, delta2, alpha, beta)

# Impressão da estimativa final na tela:
print(f"Estimativa final: {estimativa:.10f}")
