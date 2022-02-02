namespace estrutura_de_dados_dotnet.Entidades
{
    public class FilaPrioridade
    {
        public FilaPrioridade(int elemento, int prioridade)
        {
            Elemento = elemento;
            Prioridade = prioridade;
        }

        public int Elemento {get; set;}
        public int Prioridade {get; set;}
    }
}