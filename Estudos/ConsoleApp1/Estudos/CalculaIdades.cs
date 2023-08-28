namespace ConsoleApp1.Estudos
{
    public class CalculaIdade
    {
        public static void Processar()
        {
            var idade1 = ObterIdade("Digite a idade do primeiro homem em anos");
            var idade2 = ObterIdade("Digite a idade do segundo homem em anos");
            var idade3 = ObterIdade("Digite a idade da primeira mulher em anos");
            var idade4 = ObterIdade("Digite a idade da segunda mulher em anos");
            var homemMaisVelho = (idade1 < idade2) ? idade2 : idade1;
            var homemMaisNovo = (idade1 < idade2) ? idade1 : idade2;
            var mulherMaisVelha = (idade3 < idade4) ? idade4 : idade3;
            var mulherMaisNova = (idade3 < idade4) ? idade3 : idade4;

            if ((homemMaisNovo == homemMaisVelho) || (mulherMaisNova == mulherMaisVelha))
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, digite as idades novamente.As idades dos homens não devem ser iguais, bem como a das mulheres.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"A soma das idades do homem mais velho com a mulher mais nova é {homemMaisVelho + mulherMaisNova}. " +
                    $"O produto das idades do homem mais novo com a mulher mais velha é {homemMaisNovo * mulherMaisVelha}.");

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