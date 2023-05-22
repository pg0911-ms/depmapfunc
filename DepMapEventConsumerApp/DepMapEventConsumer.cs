using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DepMapEventConsumerApp
{
    public class DepMapEventConsumer
    {
        [FunctionName("DepMapEventConsumer")]
        public void Run([BlobTrigger("depmap-blobs/{name}", Source = BlobTriggerSource.EventGrid, Connection = "StorageAccountConnectionAppSetting")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
