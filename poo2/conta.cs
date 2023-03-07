using System;
using System.Collections.Generic;


class conta{
    public string CPF;
    public double saldo;
    public string nome;
    
    List<(string,double)> transacoes = new List<(string,double)>();
    public conta(){
        this.nome = "";
        this.CPF = "";
        this.saldo = 0;
    }
    
    public conta(string nome, string CPF, double saldo){
        this.nome = nome ;
        this.CPF = CPF ;
        this.saldo = saldo ;
        
    }
    
    public double Saldo (){
        return this.saldo;
    }
    
    public string GetNome (){
        return this.nome;
    }
    
    public string GetCPF (){
        return this.CPF;
    }
    
    public void Depositar (double x){
       this.saldo = this.saldo + x;
       transacoes.Add(("Depósito", x));
    }
    
    public void Sacar(double x){
        this.saldo = this.saldo - x;
        transacoes.Add(("Saque", x));
    }
    
    public void Extrato() {
        Console.WriteLine("Transações realizadas:\n");
        foreach (var transacao in transacoes) {
            Console.WriteLine($"{transacao.Item1}:\n R${transacao.Item2}\n");
        }
        Console.WriteLine($"Saldo atual: R${saldo}");
    }
}