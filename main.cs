using System;

class Program {

  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];
    int[] AsQueTem = new int[numeroDeFigurinhas];

    //A SOLUÇÃO

    for(int i=0; i < numeroDeFigurinhas; i++)
      AsQueTem[i] = 0;

    for (int i=0; i < numeroDeFigurinhasCompradas; i++)
        {
            albumDeFigurinha[i] = Int32.Parse(Console.ReadLine());
        }


    var contadorDeFigurinhas = 0;
    var albumPreenchido = 0;
    for (int q = 0; q < numeroDeFigurinhas; q++)
    {
        for (int w = 0; w < albumDeFigurinha.Length; w++)
        {
            if (q == albumDeFigurinha[w]-1)
            {
              AsQueTem[q] = 1;
            }
        }
        if(AsQueTem[q] == 1)
          totalDeFigurinhas++;   
    }


    Console.WriteLine(numeroDeFigurinhas - totalDeFigurinhas);

  }

}