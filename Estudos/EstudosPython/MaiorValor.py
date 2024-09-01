valorA = float(input("Digite o valor A: "))
valorB = float(input("Digite o valor B: "))
valorC = float(input("Digite o valor C: "))

maiorValor = valorA

if valorB > maiorValor:
    maiorValor = valorB

if valorC > maiorValor:
    maiorValor = valorC

print("O maior valor é:", maiorValor)
