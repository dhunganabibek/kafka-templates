using System;
using System.Threading.Tasks;
using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, Kafka!");

        // Creating a producer configuration
        var config = new ProducerConfig { BootstrapServers = "localhost:29092" };

        // Creating a producer
        using (var producer = new ProducerBuilder<string, string>(config).Build())
        {
            try
            {
                // Publishing a message
                var result = await producer.ProduceAsync("test-topic", new Message<string, string>
                {
                    Key = "my-key",
                    Value = "Hello, Kafka!"
                });

                Console.WriteLine($"Message sent to {result.TopicPartitionOffset}");
            }
            catch (ProduceException<string, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
            }
        }
    }
}