# RabbitMQ Boilerplate 

This repository contains a .NET API (Producer) and a Console App (Consumer) for demonstrating RabbitMQ message queuing.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [RabbitMQ](https://www.rabbitmq.com/download.html)
- [Docker](https://www.docker.com/products/docker-desktop) (optional, for running RabbitMQ in a container)

## How to run

Go to the root

```
docker compose up
```

Run both cosole app and the web api
```
dotnet run
```

go to localhost:15672 to see the rabbitMQ gui

