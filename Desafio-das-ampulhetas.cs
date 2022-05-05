static void Main(string[] args)
    {
        List<int> l1 = new List<int>(){ -9, -9, -9, 1, 1, 1 };
        List<int> l2 = new List<int>(){ 0, -9, 0, 4, 3, 2 };
        List<int> l3 = new List<int>(){ -9, -9, -9, 1, 2, 3 };
        List<int> l4 = new List<int>(){ 0, 0, 8, 6, 6, 0 };
        List<int> l5 = new List<int>(){ 0, 0, 0, -2, 0, 0 };
        List<int> l6 = new List<int>(){ 0, 0, 1, 2, 4, 0 };

        var lista = new List<List<int>>();

        lista.Add(l1);
        lista.Add(l2);
        lista.Add(l3);
        lista.Add(l4);
        lista.Add(l5);
        lista.Add(l6);

        Matriz(lista);
    }

    public static void Matriz(List<List<int>> arr)
    {
        int maiorSoma = -10000;
        
        int soma = 0;

        for(var linhaAtual = 0; linhaAtual < 4; linhaAtual++)
        {
            // Anda na lateral
            for(var l = 0; l < 4; l++)
            {
                // 1º Linha
                for(var i = l; i <= (l + 2); i++)
                {
                    soma += arr[linhaAtual][i];
                }

                // 2º Linha
                soma += arr[linhaAtual + 1][l + 1];

                // 3º Linha
                for(var i = l; i <= (l + 2); i++)
                {
                    soma += arr[linhaAtual + 2][i];
                }

                if(soma > maiorSoma)
                {
                    maiorSoma = soma;
                }

                soma = 0;
            }
        }

        Console.WriteLine(maiorSoma);
    }
