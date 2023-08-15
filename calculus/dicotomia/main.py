from metodo_dicotomia import metodo_dicotomia


def main():
    # Valor de alpha (último algarismo do RA):
    alpha = 9

    # Valor de beta (penúltimo algarismo do RA):
    beta = 9

    # Extremos inferiores e superiores do intervalo [a,b]
    a, b = -2, 2

    # Definição da precisão desejada
    precisao_desejada = 0.00001

    # Cálculo da estimativa usando a função "metodo_dicotomia"
    estimativa = metodo_dicotomia(alpha, beta, a, b, precisao_desejada)

    # Impressão da estimativa final na tela:
    print("Estimativa final c/ precisão", precisao_desejada, ":", estimativa)


if __name__ == "__main__":
    main()
