# 2. Veja se um número é par ou ímpar.

numero = int(input("Digite um número: "))

resto = numero % 2

if resto == 0:
    print("O numéro é par")
else:
    print("O número é ímpar")