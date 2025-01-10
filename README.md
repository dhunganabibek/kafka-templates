# kafka-templates

templates for testing kafka snippets

## Kafka

pub sub model. Producer should not have any idea about consumer.

## Message Delivery

- At least once (at least once, but can send duplicates)
- At most once - just send once (even if it fails)
- exactly once.

## Topics and Partitions

