using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Testando minha lista
//ContaCorrente contaRemocao = new(456);

//ListaContaCorrente lista = new();

//lista.Adicionar(new ContaCorrente(123));
//lista.Adicionar(new ContaCorrente(321));
//lista.Adicionar(contaRemocao);
//lista.Adicionar(new ContaCorrente(123));
//lista.Adicionar(new ContaCorrente(123));
//lista.Adicionar(new ContaCorrente(123));
//lista.Adicionar(new ContaCorrente(123));
//lista.Adicionar(new ContaCorrente(321));

//lista.Remover(contaRemocao);

//lista.Adicionar(new ContaCorrente(789));

//lista.Listar();

//Console.WriteLine(lista[1]);
#endregion

#region Testando ArrayList

ContaCorrente conta = new(123);
ArrayList arrayList = new() { 1, conta, "João", true, 1.05f, 1.2564 };

foreach (var item in arrayList)
{
    Console.WriteLine(item.GetType());
}

//que bizarro

#endregion
