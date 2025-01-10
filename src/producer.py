from confluent_kafka import Producer

conf = {
    'bootstrap.servers': "localhost:29092",
}

producer = Producer(conf)

producer.produce("test-topics", key="key", value="This is my first message published to kafka")

producer.flush()