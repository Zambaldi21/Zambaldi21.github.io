namespace ConsoleApp1.Estudos.Media
{
    public class MediaDeAprovacao
    {
        public static void Processar()
        {
            var nota1 = Mensagem("primeira");
            var nota2 = Mensagem("segunda");
            var nota3 = Mensagem("terceira");

            var resultado = Calcular(nota1, nota2, nota3);
            Console.WriteLine();
            Console.Write($"Sua média foi {Math.Round(resultado, 2)}.");
        }
        private static decimal Mensagem(string descricao)
        {
            Console.Write($"Digite a {descricao} nota: ");
            var nota = Convert.ToDecimal(Console.ReadLine());
            while (nota < 0 || nota > 10)
            {
                Console.Write("Não são aceitas notas maiores que 10 e nem menores que 0. Digite novamente: ");
                nota = Convert.ToDecimal(Console.ReadLine());
            }
            return nota;
        }
        private static decimal Calcular(decimal nota1, decimal nota2, decimal nota3)
        {
            var resultado = (nota1 + nota2 + nota3) / 3;
            resultado = Math.Round(resultado, 2);
            return resultado;
        }
    }
}