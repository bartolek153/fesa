import math

RA = 81220004

precisao_desejada = 10 ** (-9)

# Booleana que determina se a estimativa atual está dentro da
# precisão desejada ou não
precisao_desejada_alcancada = False

# número de termos da série de Maclaurin considerados até o momento
k = 0

x = 0.5  # (último algarismo do seu RA + 1)/10

# estimativa da função que queremos calcular, inicializada como 0
f = 0

# Enquanto a precisão desejada não tiver sido alcançada,
# incrementamos o valor de k e adicionamos novos termos ao
# polinômio.
while not precisao_desejada_alcancada:

    k += 1

    # implementacao do calculo da funcao seno a partir da serie de MacLaurin, 
    # bem como do resto (para verificar se a # precisão desejada foi alcançada)

    if (1 / math.factorial(k + 1)) * (x) ** (k + 1) < abs(precisao_desejada):
        precisao_desejada_alcancada = True

    if k % 2 == 0:  # f^k(0) = 0
        continue

    elif k % 4 == 3:  # f^k(0) = -1
        f += -1 / math.factorial(k) * (x) ** k

    else:  # f^k(0) = 1
        f += 1 / math.factorial(k) * (x) ** k


# Cálculo da diferença entre o valor fornecido pelo método "sin" e
# a estimativa obtida pelo algoritmo
diferenca = math.sin(x) - f


# Obs.: como especificado nas instruções, você não deve usar o
# método math.sin para verificar se a precisão foi atingida ou
# não dentro do laço for.

print(f"Valor da função (estimativa final): {f:.10f} ")
print(f"Valor de sen(0.5) (método embutido): {math.sin(0.5)}")
print("Termos considerados para o cálculo: ", k)
print("Diferença entre o valor calculado e o real: ", diferenca)
