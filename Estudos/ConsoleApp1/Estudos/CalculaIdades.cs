using ConsoleApp1.Utils;
using static ConsoleApp1.Estudos.CalculaIdade;

namespace ConsoleApp1.Estudos
{
    public class CalculaIdade
    {
        public static void Processar()
        {
            // Inputs
            var dadosIo = new DadosIo();
            var parametroIdade = new ParametroIdade();
            parametroIdade.IdadeHomem1 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do primeiro homem em anos: ", 0));
            parametroIdade.IdadeHomem2 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do segundo homem em anos: ", 0));
            parametroIdade.IdadeMulher1 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do primeira mulher em anos: ", 0));
            parametroIdade.IdadeMulher2 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do segunda mulher em anos: ", 0));
            while ((parametroIdade.IdadeHomem1 == parametroIdade.IdadeHomem2) || (parametroIdade.IdadeMulher1 == parametroIdade.IdadeMulher2))
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, digite as idades novamente. As idades dos homens não devem ser iguais, bem como a das mulheres.");
                parametroIdade.IdadeHomem1 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do primeiro homem em anos: ", 0));
                parametroIdade.IdadeHomem2 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do segundo homem em anos: ", 0));
                parametroIdade.IdadeMulher1 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do primeira mulher em anos: ", 0));
                parametroIdade.IdadeMulher2 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do segunda mulher em anos: ", 0));
            }

            // Process
            var comparaIdade = new ComparaIdade();
            var resultadoIdade = comparaIdade.Calcular(parametroIdade);

            // Outputs
            Console.WriteLine($"A soma das idades do homem mais velho com a mulher mais nova é {resultadoIdade.HomemMaisVelho + resultadoIdade.MulherMaisNova}. " +
    $"O produto das idades do homem mais novo com a mulher mais velha é {resultadoIdade.HomemMaisNovo * resultadoIdade.MulherMaisVelha}.");

        }
        public class ParametroIdade
        {
            public int IdadeHomem1 { get; set; }
            public int IdadeHomem2 { get; set; }
            public int IdadeMulher1 { get; set; }
            public int IdadeMulher2 { get; set; }

            public int ObterIdadeHomemMaisVelho()
            {
                return (IdadeHomem1 < IdadeHomem2) ? IdadeHomem2 : IdadeHomem1;
            }

            public int ObterIdadeHomemMaisNovo()
            {
                return (IdadeHomem1 < IdadeHomem2) ? IdadeHomem1 : IdadeHomem2;
            }
            public int ObterIdadeMulherMaisVelha()
            {
                return (IdadeMulher1 < IdadeMulher2) ? IdadeMulher2 : IdadeMulher1;
            }
            public int ObterIdadeMulherMaisNova()
            {
                return (IdadeMulher1 < IdadeMulher2) ? IdadeMulher1 : IdadeMulher2;
            }
        }
        public class ResultadoIdade
        {
            public int HomemMaisNovo { get; set; }
            public int HomemMaisVelho { get; set; }
            public int MulherMaisNova { get; set; }
            public int MulherMaisVelha { get; set; }
        }
    }
    public class ComparaIdade
    {
        public ResultadoIdade Calcular(ParametroIdade parametroIdade)
        {
            var resultado = new ResultadoIdade();

            resultado.HomemMaisVelho = parametroIdade.ObterIdadeHomemMaisVelho();
            resultado.HomemMaisNovo = parametroIdade.ObterIdadeHomemMaisNovo();
            resultado.MulherMaisVelha = parametroIdade.ObterIdadeMulherMaisVelha();
            resultado.MulherMaisNova = parametroIdade.ObterIdadeMulherMaisNova();

            return resultado;
        }
    }
}