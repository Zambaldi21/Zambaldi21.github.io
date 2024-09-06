def calculadora(numero_1, numero_2, operador):
    match operador:
        
        case "+":
            return numero_1 + numero_2
        
        case "-":
            return numero_1 - numero_2

        case "*":
            return numero_1 * numero_2

        case "/":
            return numero_1 / numero_2

numero_1 = float(input("Escreva o 1° número: "))
numero_2 = float(input("Escreva o 2° número: "))
operador = input("Escolha um operador entre os 4 sinais, +, -, *, /: ")

resultado = calculadora(numero_1, numero_2, operador)

print("O resultado é:",resultado)