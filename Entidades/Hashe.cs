namespace estrutura_de_dados_dotnet.Entidades
{
    public class Hashe
    {
        public Hashe(string chave, string valor)
        {
            this.chave = chave;
            this.valor = valor;
        }

        public string chave {get; set;}
        public string valor {get; set;}

        public override string ToString()
        {
            return "[" + chave + " - " + valor + "]";
        }
    }
}