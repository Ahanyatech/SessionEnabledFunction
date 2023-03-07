using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SessionEnabledFunction
{
    public class SessionEnabledFunction
    {
        [FunctionName("SessionEnabledFunction")]
        public void Run([ServiceBusTrigger("%QueueName%", Connection = "ServiceBusConString", IsSessionsEnabled = true)]string myQueueItem, ILogger log)
        {
            log.LogInformation("This is the message:" + $"{myQueueItem}");
        }
    }
}
