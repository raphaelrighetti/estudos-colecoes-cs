﻿using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.Exceptions;
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

//ContaCorrente conta = new(123);
//ArrayList arrayList = new() { 1, conta, "João", true, 1.05f, 1.2564 };

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item.GetType());
//}

//que bizarro

#endregion

#region Testando List<>

//List<int> lista = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var outraLista = lista.GetRange(0, 3);

//foreach (int i in outraLista)
//{
//    Console.WriteLine(i);
//}

//List<ContaCorrente> contas = new()
//{
//    new ContaCorrente(123),
//    new ContaCorrente(321),
//    new ContaCorrente(234),
//    new ContaCorrente(456)
//};

//foreach (var conta in contas)
//{
//    Console.WriteLine(conta.Numero_agencia);
//}

//contas.Sort();

//Console.WriteLine();

//foreach (var conta in contas)
//{
//    Console.WriteLine(conta.Numero_agencia);
//}

List<int> numeros = new() { 1, 2, 3, 4, 5 };

var resultado = (from numero in numeros 
                    where numero == 2 
                    select numero).FirstOrDefault();

Console.WriteLine(resultado);

#endregion

#region Testando minha exceção

//try
//{
//    throw new ByteBankException("Deu pau.");
//}
//catch (ByteBankException ex)
//{
//    Console.WriteLine($"-> {ex.Message}");
//}

#endregion
