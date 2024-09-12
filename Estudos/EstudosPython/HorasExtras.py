def solicita_dado(descricao):
        dado = int(input(descricao))
        return dado

hora = solicita_dado("Digite quantidade de horas: ")
minuto = solicita_dado("Digite quantidade de minutos: ")

converte_hora_minuto = hora * 60
hora = converte_hora_minuto
soma_minutos = hora + minuto
horas_extras = 0

if (soma_minutos > 360):
    horas_extras = soma_minutos - 360
    converte_hora_minuto = horas_extras / 60 
    print("Você tem", converte_hora_minuto, "horas extras.")
else:
    print("Você não tem horas extras.")
      



