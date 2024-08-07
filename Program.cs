using DESAFIOCSHARP1.Models;

decimal precoIni = 0, precoHora = 0, valorTotal = 0;
int horaPermanencia = 0;


Console.WriteLine("Bem vindo!");
Console.Write("Informe o preço inicial: ");
precoIni = Convert.ToDecimal(Console.ReadLine());
Console.Write("Informe o preço por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estaciona = new Estacionamento(precoIni, precoHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu) {
    Console.WriteLine("Digite uma opção: ");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Buscar Veículo");
    Console.WriteLine("3 - Deletar Veículo");
    Console.WriteLine("4 - Encerrar");
    switch(Console.ReadLine()) {
        case "1":
            estaciona.CadastrarVeiculo();
            break;
        case "2":
            estaciona.BuscarVeiculo();
            break;
        case "3":
            estaciona.DeletarVeiculo();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}