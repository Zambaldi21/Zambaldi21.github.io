
def eh_positivo(valor):
    while valor < 0:
        print("Não são aceitos números menores que 0. Digite novamente: ")
        valor = float(input())
    return valor

print("Digite o valor que deseja sacar: ")
valor = float(input())
verifica_valor = eh_positivo(valor)

def calcula_saque(valor):
    while valor > 0:
        if valor > 100:
            return valor
        elif valor > 50:
            return valor
        elif valor > 20:
            return valor
        elif valor > 10:
            return valor
        elif valor > 5:
            return valor
        elif valor > 2:
            return valor        
    return valor
 
saque = calcula_saque(valor)
print(saque)