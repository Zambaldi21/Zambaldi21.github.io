
usuarios = []

def dados_usuario():
    nome = input("Digite o nome do usuário:")
    telefone = input("Digite o telefone do usuário:")
    return nome, telefone 


def inserir_usuario(lista, nome, telefone):
    lista.append([telefone, nome])
    return

    
print("Seja bem vindo a lista de usuários\n" \
"Escolha uma opção:")
print("1 - Criar usuário\n" \
"2 - Listar usuários\n" \
"3 - Buscar usuário\n" \
"4 - Atualizar usuário\n " \
"5 - Remover usuário\n" \
"0 - Encerrar")

opcao = int(input())

if opcao == 1:
    nome, telefone = dados_usuario()    
    inserir_usuario(usuarios, nome, telefone)
