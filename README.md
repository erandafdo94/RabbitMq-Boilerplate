# RabbitMQ Boilerplate Codebase

This repository contains a .NET API (Producer) and a Console App (Consumer) for demonstrating RabbitMQ message queuing.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [RabbitMQ](https://www.rabbitmq.com/download.html)
- [Docker](https://www.docker.com/products/docker-desktop) (optional, for running RabbitMQ in a container)

## RabbitMQ Setup

If you are using Docker, you can start RabbitMQ with the following command:

```yaml
version: "3.8"
services:
  rabbitmq:
    container_name: "rabbitmq"
    image: rabbitmq:3.8-management-alpine
    environment:
      - RABBITMQ_DEFAULT_USER=user
      - RABBITMQ_DEFAULT_PASS=mypass
    ports:
      - "5672:5672"   # RabbitMQ instance
      - "15672:15672" # Web interface
