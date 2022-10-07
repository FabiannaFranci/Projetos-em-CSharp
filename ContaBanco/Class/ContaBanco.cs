using System;

namespace ContaBanco.Class
{
    public class ContaBanco1
    {    
        // Atributos e seus métodos especiais Get e Set    
        private string cpf = "";
        public string Cpf{
            get {return cpf;}
            set {cpf = value;}
        }
        protected string tipo = "";
        public string Tipo{
            get{return tipo;}
            set{tipo = value;}
        }
        private string dono = ""; 
        public string Dono {
            get {return dono;}
            set {dono = value;}
        }
        private double saldo = 0;
        public double Saldo{
            get {return saldo;}
            set {saldo = value;}
        } 
        private bool status = false;
        public bool Status{
            get{return status;}
            set{status = value;}
        }
        //Método para aparecer mensagem do 1
        public void MetodoMenu(){
            Console.WriteLine(@$"Text
            
Nome: {Dono}
CPF : {Cpf}
Tipo: {Tipo}
Saldo: R${Saldo}
Status: {Status} ");
        }
        

       // Método Construtor
        public ContaBanco1(){
            this.Status = false;
            this.Saldo = 0;
        }
        // Método onde mostrará com quanto você começara se for Conta Corrente ou Conta Poupança
        public void AbrirConta(){
            this.Status = true;
            if(this.Tipo == "CC"){
                this.Saldo = 50;
            
                   
            }
            else if(this.Tipo == "CP"){
                this.Saldo = 150;
                
            }
            else{
                this.Status = false;
            }
        }
        //Método para fechar a conta
        public void FecharConta(){
            if(this.Saldo < 0) {
                Console.WriteLine("Conta em débito");
            }
            if (this.Saldo > 0) {
                Console.WriteLine("Retire seu dinheiro");
                
            }
            else{
                this.Status = false;
                Console.WriteLine("Conta fechada com Sucesso");
            }
        }
        //Método para depositatr dinheiro
        public void Depositar(double valor){
            if(this.Status == true){
                this.Saldo += valor;
            }
            else{
                Console.WriteLine($"Abra a conta antes");
                
            }
        }
        //Método para sacar dinheiro
        public void Sacar(double valor){
            if (this.Status == true){
                if(Saldo >= valor ){
                    this.Saldo -= valor;
                }
                else{
                    Console.WriteLine("Saldo insuficiente");
                }
            }   
            else{
                Console.WriteLine($"Abra a conta antes");
            }
        }
        //Método para pagar mensalidade do banco
        public void PagarMensal(double vM){
            vM = 0;
            DateTime hora = DateTime.Now;
            if (this.Tipo == "CC"){
                vM = 12;
                
            }
            else if(this.Tipo == "CP"){
                vM = 20;
            }
                if (this.Status == true){
                    if (this.Saldo > vM){
                        this.Saldo -= vM;
                        Console.WriteLine($"Sua mensalidade de R${vM} foi paga no dia {hora}");
                        Console.WriteLine($"Saldo Atual: {this.Saldo}");
                    }
                    else{
                        Console.WriteLine($"Não há como pagar a mensalidade");
                    }
                }
            else{
                Console.WriteLine($"Abra a conta antes");
            }
           
        }
     
       

       

    


    }
} 

    
