using ConsoleApp1.Utils;
using System.ComponentModel;

namespace ConsoleApp1.Estudos
{
    public class CalculaIdade
    {
        public static void Processar()
        {
            // Inputs
            var dadosIo = new DadosIo();
            var comparaIdades = new ComparaIdades();
            comparaIdades.Idade1 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do primeiro homem em anos"));
            comparaIdades.Idade2 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do segundo homem em anos"));
            comparaIdades.Idade3 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do primeira mulher em anos"));
            comparaIdades.Idade4 = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite a idade do segunda mulher em anos"));

            // Process


            // Outputs
            if ((comparaIdades.HomemMaisVelho == comparaIdades.HomemMaisNovo) || (comparaIdades.MulherMaisNova == comparaIdades.MulherMaisVelha))
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, digite as idades novamente.As idades dos homens não devem ser iguais, bem como a das mulheres.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(@$"A soma das idades do homem mais velho com a mulher mais nova é {comparaIdades.HomemMaisVelho + comparaIdades.MulherMaisNova}. 
                    O produto das idades do homem mais novo com a mulher mais velha é {comparaIdades.HomemMaisNovo * comparaIdades.MulherMaisVelha}.");
            }
        }

        public class ComparaIdades
        {
            public int Idade1 { get; set; }
            public int Idade2 { get; set; }
            public int Idade3 { get; set; }
            public int Idade4 { get; set; }
            public int HomemMaisNovo { get; set; }
            public int HomemMaisVelho { get; set; }
            public int MulherMaisNova { get; set; }
            public int MulherMaisVelha { get; set; }

            private List<int> MaisVelho()
            {
                var listaIdade = new List<int>();

                while (listaIdade <= 4)
                {
                    listaIdade.Add(listaIdade);
                }

                HomemMaisVelho = (Idade1 < Idade2) ? Idade2 : Idade1;

                HomemMaisNovo = (Idade1 < Idade2) ? Idade1 : Idade2;

                MulherMaisVelha = (Idade3 < Idade4) ? Idade4 : Idade3;

                MulherMaisNova = (Idade3 < Idade4) ? Idade3 : Idade4;

                return listaIdade;
            }
        }
    }
}