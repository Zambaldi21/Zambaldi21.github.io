
def eh_positivo(valor):
    while valor < 0:
        print("Não são aceitos números menores que 0. Digite novamente: ")
        valor = float(input())
    return valor

print("Digite o valor que deseja sacar: ")
valor = float(input())
verifica_valor = eh_positivo(valor)