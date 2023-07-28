namespace ConsoleApp1.Estudos
{
    public class CategoriaDeNadadores
    {
        public static void Processar()
        {
            Console.WriteLine("Digite sua idade em anos.");
            var idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Parábens, você faz parte do time dos adultos.");
            }
            else if (idade >= 14)
            {
                Console.WriteLine("Parábens, você faz parte do time juvenil B.");
            }
            else if (idade >= 11)
            {
                Console.WriteLine("Parábens, você faz parte do time dos juvenil A.");
            }
            if (idade >=8 && idade <= 10)
            {
                Console.WriteLine("Parábens, você faz parte do time dos infantil B.");
            }
            if (idade >=5 && idade <= 7)
            {
                Console.WriteLine("Parábens, você faz parte do time dos infantil A.");
            }
        }
    }
}