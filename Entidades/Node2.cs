namespace estrutura_de_dados_dotnet.Entidades
{
    public class Node2 // Teste
    {
        public Node2(int elemento)
        {
            Elemento = elemento;
        }

        public int Elemento {get; set;}

        public Node2 Proximo {get; set;}

        public Node2 Anterior {get; set;}
    }
}