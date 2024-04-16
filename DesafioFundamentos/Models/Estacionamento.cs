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
            //Envia mensagem para o console.
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            //Lê e armazena a informação digitada na variavel "Veiculo".
            string veiculo = Convert.ToString(Console.ReadLine());
            //Tranfere a informação da variavel veiculo p/ a lista de veiculos.
            veiculos.Add(veiculo);
            Console.WriteLine($"Veiculo: {veiculo} adicionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            //Envia uma mensagem para o console solicitando o veiculo.
            Console.WriteLine("Digite a placa do veículo para remover:");          
            
            //Le o console e armazena a informação digitada na variavel placa.
            string placa = Convert.ToString(Console.ReadLine());

            //Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {  
                //Solicita o tempo que o veiculo ficou estacionado.                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //Armazena a quantidade de horas informadas pelo usuario.
                int horas = Convert.ToInt32(Console.ReadLine());                
                
                //Calcula o valor total devido.
                decimal valorTotal = precoInicial + (precoPorHora * horas);    
                //Remove a placa da lista.
                veiculos.Remove(placa);
                //Informa o usuario que a placa foi removida e o valor final.
                Console.WriteLine($"O veículo: {placa} foi removido e o preço total foi de: R$ {valorTotal} reais");
            }
            else
            {
                //Informa ao usuario que a placa informada não existe no sistema.
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            //Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //Informa ao usuario os veículos registrados em sistema.
                Console.WriteLine("Os veículos estacionados são:");                
                foreach(var veiculo in veiculos){
                    Console.WriteLine($"foi localizada a placa {veiculo}");
                }
                
            }
            else
            {
                //Informa ao usuario que não existe veiculos registrados no sistema.
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
