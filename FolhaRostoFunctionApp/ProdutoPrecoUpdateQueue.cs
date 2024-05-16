using Microsoft.Azure.Functions.Worker;

namespace FolhaRostoFunctionApp
{
    
    public class ProdutoPrecoUpdateFileQueue
    {
        [ServiceBusOutput("folharosto-produto-preco-update-file", Connection = "sb-gabbinetto")]
        public string OutputEvent { get; set; }
    }
}
