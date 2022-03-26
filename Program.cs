 string fraseDigitada, fraseComDislalia;
Console.Write("digite uma frase com R:");
fraseDigitada=Console.ReadLine()!;
fraseComDislalia = fraseDigitada!
.Replace("r","l")
.Replace("R","L");
Console.WriteLine(fraseComDislalia);