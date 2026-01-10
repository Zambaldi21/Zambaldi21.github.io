def chamarnota(nota):
    while nota > 10 or nota < 0:
        print("Não aceitamos números menores que 0 ou maiores que 10. Digite novamente: ")
        nota = float(input())
    return nota

nota1 = float(input("Digite a primeira nota: "))
verificanota1 = chamarnota(nota1)

nota2 = float(input("Digite a segunda nota: "))
verificanota2 = chamarnota(nota2)

resultado = (verificanota1 + verificanota2) / 2
if resultado >= 7:
    print(f"Parabéns, você foi aprovado. Sua média é: {resultado}")
else:
    print(f"Você foi reprovado. Sua média é: {resultado}")