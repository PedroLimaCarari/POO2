using System;
using System.Collections.Generic;
using System.Text;

class ContaBanco {
static void Main() {
    Boolean flag = true;
    int menu; 
    string nome ;
    string CPF ;
    double saldo ;
    
    do{
            Console.WriteLine("Digite o seu CPF para criação da conta: \n");
            CPF = Console.ReadLine();
            Console.Clear();
            if(CPF.Length != 11){
                Console.WriteLine("Preencha o CPF com 11 valores.\n");
            }
    }while(CPF.Length != 11);
    
    Console.WriteLine("Digite o seu Nome para criação da conta: \n");         
    nome = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Bônus de criação de conta: R$1000,00 \n");         
    saldo = 1000;                        
    conta pedro  = new conta(nome, CPF, saldo);
    
    while (flag == true){
        do{
            Console.WriteLine("Escolha sua operação:\n0-Informação do login\n1-Operações\n2-Extrato\n3-Encerrar\n");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(menu < 0 || menu > 3){
                Console.WriteLine("Escolha uma operação correspondente as indicadas acima.\n");
            }
        }while(menu < 0 || menu > 3);
        
        switch (menu){
            case 0:
                Console.WriteLine("Nome do titular: " + pedro.GetNome() );
                Console.WriteLine("CPF do titular: " + pedro.GetCPF() );
                Console.WriteLine("Saldo do titular:R$ " + pedro.Saldo() );
                Console.WriteLine("\n");
            break;
            case 1:
                Console.WriteLine("Escolha sua operação:\n0-Saldo\n1-Sacar\n2-Depositar\n3-Sair\n");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu){
                    case 0:
                        Console.WriteLine("Saldo atual:R$ " + pedro.Saldo() );
                        Console.WriteLine("\n");
                    break;
                    case 1:
                        double valor;
                        Console.WriteLine("Digite o valor a ser sacado:R$ ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        if(valor < 0 || valor > pedro.Saldo()){
                            Console.WriteLine("Esta operação não pode ser realizada");
                            Console.WriteLine("\n");
                        } 
                        else{
                            pedro.Sacar(valor);
                            Console.WriteLine("O valor Atual na conta é de:R$ " + pedro.Saldo());
                            Console.WriteLine("\n");
                        }    
                    break;
                    case 2:
                        double deposito;
                        Console.WriteLine("Digite o valor a ser depositado: ");
                        deposito = Convert.ToDouble(Console.ReadLine());
                        pedro.Depositar(deposito);
                        Console.WriteLine("O valor Atual na conta é de:R$ " + pedro.Saldo());
                        Console.WriteLine("\n");
                    break;
                    case 3:
                        
                    break;    
                }
            break;
            case 2:
                pedro.Extrato();
            break;
            case 3:
                Console.WriteLine("Obrigado, Volte sempre");
                flag = false;
            break;
       }
    }
  }
}