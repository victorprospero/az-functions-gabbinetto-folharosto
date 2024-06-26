using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FolhaRostoFunctionApp
{
    public class SendFileNameToQueue
    {
        private readonly ILogger _logger;

        public SendFileNameToQueue(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SendFileNameToQueue>();
        }

        [Function(nameof(SendFileNameToQueue))]
        public ProdutoPrecoUpdateFileQueue Run([BlobTrigger("folharosto-produto-preco-update/{name}", Connection = "sa-gabbinetto")] string myBlob, string name)
        {
            _logger.LogInformation(name);
            return new ProdutoPrecoUpdateFileQueue()
            {
                OutputEvent = name
            };
        }
    }
}
