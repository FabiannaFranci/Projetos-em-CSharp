ContaBanco.Class.ContaBanco1 cb = new ContaBanco.Class.ContaBanco1();
cb.Tipo = "CC";
cb.Dono = "Fabianna Franci";
cb.Cpf = "387.774.234-47";
cb.AbrirConta();


Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
ContaBanco.Class.Util.MetodoTempo("Iniciando", 5, 500);
Console.ResetColor();
Console.Clear();
string? opcao;
do 
{ Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(@$"
==============================
|         Menu Banco         |
|       1 - Meus Dados       |
|       2 - Depositar        |
|       3 - Sacar            |
|       4 - Mensalidade      |
|       5 - Fechar Conta     |
|       0 - Sair             |
==============================
");
Console.ResetColor();
opcao = Console.ReadLine();
Thread.Sleep(500);
Console.Clear();
    switch (opcao)
    {
        case ("1"):
cb.MetodoMenu();
        break;

        case ("2"):
        Console.Write("Digite um valor para depósito: R$");
        double valorD = Convert.ToDouble(Console.ReadLine());
        cb.Depositar(valorD);
        Console.WriteLine(@$"
Foi depositado: R${valorD} 
Saldo Atual: R${cb.Saldo}");
        break;

        case ("3"):
        Console.Write("Digite um valor para sacar: R$");
        double valorS = Convert.ToDouble(Console.ReadLine());
        cb.Sacar(valorS);
        Console.WriteLine(@$"
Saldo Atual: R${cb.Saldo}");
        break;

        case ("4"):
        cb.PagarMensal(0);
        break;

        case ("5"):
        cb.FecharConta();
        break;

        case ("0"):
        Console.WriteLine($"Obrigada por fazer parte do Banco NewCity");
        break;

        default:
        Console.WriteLine($"Opção inválida, digite novamente.");
        break;
    }
Console.WriteLine($"Aperte ENTER para continuar");
Console.ReadLine();  
Console.Clear();  
}while (opcao != "0");
Console.ForegroundColor = ConsoleColor.Green;
ContaBanco.Class.Util.MetodoTempo("Finalizando", 5, 500);
Console.ResetColor();


