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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            // Envia mensagem para o console.
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // Lê e armazena a informação digitada na variavel "Veiculo".
            string veiculo = Convert.ToString(Console.ReadLine());
            // Tranfere a informação da variavel veiculo p/ a lista de veiculos.
            veiculos.Add(veiculo);
            Console.WriteLine($"Veiculo: {veiculo} adicionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            //envia uma mensagem para o console solicitando o veiculo.
            Console.WriteLine("Digite a placa do veículo para remover:");
          
            // Pedir para o usuário digitar a placa e armazenar na variável placa   
            // Le o console e armazena a informação digitada na variavel placa.
            string placa = Convert.ToString(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {  
                //Solicita o tempo que o veiculo ficou estacionado.
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //armazena a quantidade de horas informadas pelo usuario.
                int horas = Convert.ToInt32(Console.ReadLine());
                
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal 
                // calcula o valor total devido.
                decimal valorTotal = precoInicial + (precoPorHora * horas);       
               
                // TODO: Remover a placa digitada da lista de veículos              
                // *IMPLEMENTE AQUI*
                  veiculos.Remove(placa);

                Console.WriteLine($"O veículo: {placa} foi removido e o preço total foi de: R$ {valorTotal} reais");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(var veiculo in veiculos){
                    Console.WriteLine($"foi localizada a placa {veiculo}");
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
