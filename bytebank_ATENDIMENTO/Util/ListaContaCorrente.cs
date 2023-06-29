using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.Util;

public class ListaContaCorrente
{
    private ContaCorrente[] contas;
    private int proximaPosicao = 0;

    public ListaContaCorrente(int tamanho = 5)
    {
        contas = new ContaCorrente[tamanho];
    }

    public ContaCorrente this[int indice] => Detalhar(indice);
    public int Tamanho => proximaPosicao;

    public void Listar()
    {
        for (int i = 0; i < contas.Length; i++)
        {
            if (contas[i] != null)
            {
                Console.WriteLine($"Agência: {contas[i].Numero_agencia}, Conta: {contas[i].Conta}, Índice: {i}");
            }
        }
    }

    public ContaCorrente Detalhar(int indice)
    {
        if (indice < 0 || indice >= Tamanho)
        {
            throw new ArgumentOutOfRangeException("Índice informado não está presente na lista!");
        }

        return contas[indice];
    }

    public void Adicionar(ContaCorrente conta)
    {
        if (proximaPosicao > contas.Length - 1)
        {
            AumentarCapacidade(proximaPosicao * 2);
        }

        contas[proximaPosicao] = conta;
        proximaPosicao++;
    }

    public void Remover(ContaCorrente contaRemocao)
    {
        for (int i = 0; i < contas.Length; i++)
        {
            if (contas[i].Equals(contaRemocao))
            {
                for (int j = i; j < proximaPosicao; j++)
                {
                    Console.WriteLine("Entrou no loop interno");

                    contas[j] = contas[j + 1];
                }

                Console.WriteLine("Conta removida!");
                proximaPosicao--;
                break;
            }
        }
    }

    void AumentarCapacidade(int tamanho)
    {
        ContaCorrente[] novoArray = new ContaCorrente[tamanho];

        for (int i = 0; i < contas.Length; i++)
        {
            novoArray[i] = contas[i];
        }

        contas = novoArray;
    }
}
