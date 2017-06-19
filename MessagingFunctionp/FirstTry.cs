using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;

namespace MessagingFunctionp
{
    public static class FirstTry
    {
        [FunctionName("ServiceBusTopicTriggerCSharpLight")]
        public static void Run([ServiceBusTrigger("TopicName", "SubscriptionName")]BrokeredMessage message, TraceWriter log)
        {
            log.Info($"PROPERTIES READ: {message.Properties.Count}");
        }
    }
}