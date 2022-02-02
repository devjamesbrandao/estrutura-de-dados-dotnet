using EDC.Filas;
namespace EDC_
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void FilaPrioridade()
        {
            var filaBanco = new FilaDePrioridade();

            filaBanco.EnqueueFilaPrioridade(1, 3);

            filaBanco.EnqueueFilaPrioridade(2, 2);

            filaBanco.EnqueueFilaPrioridade(7, 2);

            filaBanco.EnqueueFilaPrioridade(10, 1);

            filaBanco.DequeueFilaPrioridade();

            filaBanco.Print();
        }

        static void BatataQuente()
        {
            var jogo = new BatataQuente();

            jogo.JogarBatataQuente(new string[]{"James", "Rebeca"}, 2);
        }
    }
}
