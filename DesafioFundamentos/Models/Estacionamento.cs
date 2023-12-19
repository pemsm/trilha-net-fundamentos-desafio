using System.Text.RegularExpressions; //Statement usado para o código aceitar expressõe regulares para validar placa

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        static bool ValidarModeloPlaca(string modeloPlaca)
        {
            // Expressão regular para validar o modelo da placa (Formato: ABC-1234)
            string padrao = @"^[A-Z]{3}-\d{4}$";

            // Compara se a placa digitada bate com o REGEX
            return Regex.IsMatch(modeloPlaca, padrao);
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            string placa = "";

            do // Faz com que o usuário digite novamente até inserir um modelo válido de placa
            {
                Console.WriteLine("Digite a placa do veí­culo para estacionar(Seguindo o modelo ABC-1234):");
                placa = Console.ReadLine();
            } while (ValidarModeloPlaca(placa.ToUpper()) == false);
            
            veiculos.Add(placa.ToUpper());
            
            
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veí­culo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veí­culo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veí­culo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veí­culo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                // TODO: Remover a placa digitada da lista de veí­culos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veí­culo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veí­culo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veí­culos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veí­culos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veí­culos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veí­culos estacionados.");
            }
        }
    }
}
