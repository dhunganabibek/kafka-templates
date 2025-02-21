from confluent_kafka.admin import AdminClient

conf = {
    'bootstrap.servers': "localhost:29092",
}

admin_client = AdminClient(conf)

# Get the list of topics
topic_metadata = admin_client.list_topics(timeout=10)

# Print the topic names
for topic in topic_metadata.topics:
    print(topic)