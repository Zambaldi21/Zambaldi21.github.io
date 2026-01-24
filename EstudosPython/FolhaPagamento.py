
def eh_negativo(valor):
    while valor < 0:
        valor = float(input("Não são aceitos valores menores que 0. Digite novamente: "))
    return valor

nome = input("Digite seu nome completo: ")

hora_trabalhada = float(input("Digite a quantidade de horas trabalhadas: "))
hora_trabalhada = eh_negativo(hora_trabalhada)

valor_hora = float(input("Digite o valor da sua hora: "))
valor_hora = eh_negativo(valor_hora)

salario_bruto = hora_trabalhada * valor_hora
inss = salario_bruto * 0.08
salario_liquido = salario_bruto - inss

if hora_trabalhada > 160:
    diferenca_hora_extra = hora_trabalhada - 160
    jornada_trabalho = hora_trabalhada - diferenca_hora_extra
    valor_hora_trabalhada = (hora_trabalhada - diferenca_hora_extra) * valor_hora
    valor_hora_extra = diferenca_hora_extra * (valor_hora + (valor_hora * 0.50))
    salario_bruto = valor_hora_extra + valor_hora_trabalhada
    inss =  salario_bruto * 0.08    
    salario_liquido = salario_bruto - inss
    print("Seu salário bruto é de:",salario_bruto,". Sendo", jornada_trabalho,"de hora trabalhadas e" ,diferenca_hora_extra,"de horas extras." \
    "\nO valor das sua jornada de trabalho é:", valor_hora_trabalhada,"e o valor da hora extra é:",valor_hora_extra,"." \
    "\nSeu salário líquido é:", salario_liquido,"com o desconto de 8% pelo INSS que foi de:",inss,".")

print("Seu salário bruto é de:",salario_bruto,". Sendo", hora_trabalhada,"de hora trabalhadas." \
    "\nSeu salário líquido é:", salario_liquido,"com o desconto de 8% pelo INSS que foi de:",inss,".")

""" Crie um programa que: Peça nome, horas trabalhadas e valor da hora, Valide valores negativos Calcule: Salário bruto Hora extra (acima de 160h → +50%) 
INSS (8%) Mostre um resumo final formatado """