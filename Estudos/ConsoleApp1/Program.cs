// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o valor de A.");
var valorDeA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de B.");
var valorDeB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de C.");
var valorDeC = Convert.ToInt32(Console.ReadLine());
var valorDeR = (valorDeA + valorDeB);
var dobroDeR = Math.Pow(valorDeR, 2);
Console.WriteLine($"O valor de r é {dobroDeR}.");
var valorDeS = (valorDeB + valorDeC);
var dobroDeS = Math.Pow(valorDeS, 2);
Console.WriteLine($"O valor de s é {dobroDeS}.");
var valorDeD = (dobroDeR + dobroDeS) / 2;
Console.WriteLine($"O valor de d é {valorDeD}.");
