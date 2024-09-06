#Calcule a média aritmética das 3 notas de um aluno e mostre, além do valor da média, uma mensagem de "Aprovado", 
# caso a média seja igual ou superior a 6, ou a mensagem "reprovado", caso contrário.

def solicitar_nota(descricao):
    nota = float(input(descricao))
    while(nota > 10 or nota < 0):
        print("Não são aceitas notas menores que 0 e maiores que 10. Por favcr. digite novamente.")
        nota = float(input(descricao))
    return nota

def calcular(nota_1, nota_2, nota_3):
    media = (nota_1 + nota_2 + nota_3)/3
    return media

primeira_nota = solicitar_nota("Digite a 1° nota: ")
segunda_nota = solicitar_nota("Digite a 2° nota: ")
terceira_nota = solicitar_nota("Digite a 3° nota: ")

resultado = calcular(primeira_nota, segunda_nota, terceira_nota)

if (resultado>= 6):
    print("Aprovado, sua média foi:", resultado)
else:
    print("Reprovado, sua média foi:", resultado)
