def verificaSalario(salario):
    while salario < 0:
        print("Não é permitido valores menores que 0, Digite novamente: ")
        salario = float(input())
    return salario

salario = float(input("Digite o seu salário: "))
salario = verificaSalario(salario)
    
imposto = 0.0
if salario <= 2000:
    print("Você não tem que pagar imposto!")
elif salario <= 3500:
    imposto = salario * 0.10
    print("Você tem que pagar", imposto, "de imposto")
else:
    imposto = salario *0.20
    print("Você tem que pagar", imposto, "de imposto")
