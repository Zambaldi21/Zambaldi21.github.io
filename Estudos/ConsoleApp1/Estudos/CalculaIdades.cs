namespace ConsoleApp1.Estudos
{
    public class CalculaIdade
    {
        public static void Processar()
        {
            var idade1 = ObterIdade("Digite a idade do primeiro homem em anos");
            var idade2 = ObterIdade("Digite a idade da primeira mulher em anos");
            var idade3 = ObterIdade("Digite a idade do segundo homem em anos");
            var idade4 = ObterIdade("Digite a idade da segunda mulher em anos");
            var maiorIdadeHomem = Convert.ToInt32(idade1);
            var maiorIdadeMulher = Convert.ToInt32(idade2);
            var menorIdadeHomem = Convert.ToInt32(idade3);
            var menorIdadeMulher = Convert.ToInt32(idade4);
            if (maiorIdadeHomem < idade2)
            {
                maiorIdadeHomem = idade3;
                menorIdadeHomem = idade1;
            }
            if (maiorIdadeMulher < idade4)
            {
                maiorIdadeMulher = idade4;
                menorIdadeMulher = idade2;
            }
            if ((idade1 == idade3) && (idade2 == idade4))
            {
                Console.WriteLine("Por favor, digite as idades novamente.As idades dos homens não devem ser iguais, bem como a das mulheres.");
            }
            else
            {
                var idadeHomemVelho = Convert.ToInt32(maiorIdadeHomem + menorIdadeMulher);
                var idadeHomemNovo = Convert.ToInt32(maiorIdadeMulher + menorIdadeHomem);
                Console.WriteLine();
                Console.WriteLine($"A soma das idades do homem mais velho com a mulher mais nova é {idadeHomemVelho}. " +
                    $"A soma das idades do homem mais novo com a mulher mais velha é {idadeHomemNovo}.");

            }
        }

        private static int ObterIdade(string descricao)
        {
            Console.WriteLine(descricao);
            var idade = Convert.ToInt32(Console.ReadLine());
            return idade;
        }
    }
}