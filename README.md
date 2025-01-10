# kafka-templates

templates for testing kafka snippets

## Kafka

pub sub model. Producer should not have any idea about consumer.

## Message Delivery

- At least once (at least once, but can send duplicates)
- At most once - just send once (even if it fails)
- exactly once.

## Topics and Partitions

Topics - where messages are stored.  
Partitions - Topics are brokwn into multiple segment called partition.
offsert - unique identifier given to each record in each partitions.

## Running Kafka Locally

Start zookeeper server  
```bash
bin/zookeeper-server-start.sh config/zookeeper.properties
```

What does zookeeper do?

- Manage Broker Metadata
- Leader election in Partitions
- Configuration Management
- Cluster Coordination

start kakfa server/ broker

```bash
bin/kafka-server-start.sh config/server.properties 
```

What is broker?

- Each kafka broker is server.  
- each broker has unique id and listen to unique port.

Partitions

- A topic is divided into partition.
- Each partition is order sequence of records and immutable.
- Partitions are distributed across multiple broker.

Replication

- Kafka replicate partition across multiple broker for fault tolorence.
- Each partition have one leader (decided by zookeeper) and multiple followers.
- The leader handle read and write for the partition while followers replicate the data.
- Replication factor is used for replication

## creating a kafka Topics

```bash
kafka-topics.sh 
    --create 
    --topic test_topic
    --bootstrap-server localhost:9092 
    --partitions 10
    --replication-factor 1
```

## listing the kafka Topics

```bash
kafka-topics.sh --list --bootstrap-server localhost:9092
```

## Running Confluent Cloud Docker Image

Cloning the docker image

```bash
docker pull confluentinc/cp-kafka:latest
```

