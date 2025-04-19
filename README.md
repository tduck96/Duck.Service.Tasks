# 🦆 Duck.Service.Tasks

`Dumb simple microservice for handling the most mundane dev task ever: tracking tasks that need to get done.`

Just a humble to-do list service — built with the kind of architecture you'd normally reserve for, well, not a to-do list.

Built with .NET, MongoDB, RabbitMQ, and Docker Compose. Frontend coming soon in Angular.

## 💡 Why This Exists
Because I wanted to:

Build something simple but structured

Practice event-driven design using RabbitMQ

Use MongoDB for quick document modeling

Containerize everything with Docker Compose

Hook up an Angular frontend just for fun

Show off some architecture chops in a portfolio-friendly package

### 🧱 Architecture
[Angular UI] <---> [Duck.Service.Tasks (.NET API)] ---> [RabbitMQ] ---> [Other Services - TBD]
                                  |
                              [MongoDB]

.NET API for managing task CRUD

Emits events (task.created, task.updated, etc.) via RabbitMQ

MongoDB stores the tasks

Angular frontend connects to the API (WIP)

