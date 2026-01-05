#1. Número positivo ou negativo; Peça um número ao usuário e informe se ele é positivo, negativo ou zero.
# Esse numero tem que ser inteiro
# Adicionar um while para verificar se é inteiro

# Solicita um número ao usuário
numero = float(input("Digite um número: "))

# Verifica se o número é positivo
if numero > 0:
    print("Este número é positivo:", numero)

 # Verifica se o número é negativo   
elif numero < 0:
    print("Este é um número negativo:", numero)

# Verifica se o número é 0    
else:
    print("Esse número é zero: ", numero)

