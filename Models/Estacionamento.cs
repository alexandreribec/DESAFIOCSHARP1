using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOCSHARP1.Models
{
    public class Estacionamento
    {
        decimal precoIni = 0;
        decimal precoHora = 0;
        decimal valorTotal = 0;
        List<string> placaVeiculo = new List<string>();
        int horaPermanencia = 0;
        

        public Estacionamento(decimal precoIni, decimal precoHora) {
            this.precoIni = precoIni;
            this.precoHora = precoHora;
        }

        public void CadastrarVeiculo() {           
            Console.Write("Digite a placa do Veículo: ");
            placaVeiculo.Add(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("Veículo cadastrado com sucesso!");
            Console.WriteLine("------------------------------");
        }

        public void BuscarVeiculo() {
            if(placaVeiculo.Any()) {
                foreach(string item in placaVeiculo) {
                    Console.WriteLine($"{item}");
                    Console.WriteLine("------------------------------");
                }
            }
            
        }

        public void DeletarVeiculo() {
            Console.Write("Digite a placa do Veículo: ");
            string placa = Console.ReadLine();
            if(placaVeiculo.Any(x => x.ToUpper() == placa.ToUpper())) {

                Console.Write("Quantas horas o veículo permaneceu no estacionamento?: ");
                horaPermanencia = Convert.ToInt32(Console.ReadLine());
                valorTotal = horaPermanencia * precoHora + precoIni;
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Valor a pagar: R${valorTotal}");
                Console.WriteLine("------------------------------");
            }

            else {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Veículo não encontrado!");
                Console.WriteLine("------------------------------");
            }
            
        }
    }
}