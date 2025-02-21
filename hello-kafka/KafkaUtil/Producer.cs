using System;
using Confluent.Kafka;


namespace KafkaUtil;

public class KafkaProducer
{

    public KafkaProducer()
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        var producer = new ProducerBuilder<string, string>(config).Build();
    }
}