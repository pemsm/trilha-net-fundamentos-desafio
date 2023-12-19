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

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuÃ¡rio digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            
            Console.WriteLine("Digite a placa do veÃ­culo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veÃ­culo para remover:");

            // Pedir para o usuÃ¡rio digitar a placa e armazenar na variÃ¡vel placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veÃ­culo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veÃ­culo permaneceu estacionado:");

                // TODO: Pedir para o usuÃ¡rio digitar a quantidade de horas que o veÃ­culo permaneceu estacionado,
                // TODO: Realizar o seguinte cÃ¡lculo: "precoInicial + precoPorHora * horas" para a variÃ¡vel valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                // TODO: Remover a placa digitada da lista de veÃ­culos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veÃ­culo {placa} foi removido e o preÃ§o total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veÃ­culo nÃ£o estÃ¡ estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se hÃ¡ veÃ­culos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veÃ­culos estacionados sÃ£o:");
                // TODO: Realizar um laÃ§o de repetiÃ§Ã£o, exibindo os veÃ­culos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("NÃ£o hÃ¡ veÃ­culos estacionados.");
            }
        }
    }
}
