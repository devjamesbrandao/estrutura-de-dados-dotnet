namespace estrutura_de_dados_dotnet.Entidades
{
    public class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} - {Next}";
        }
    }
}