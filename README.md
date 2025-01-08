 <h1 >  ASP.NET Core Microservices Practice </h1>


<br/>
This repository includes an online store project designed with microservices such as Catalog, 
Basket, Discount and Ordering. Each service uses separate databases (MongoDB, Redis, PostgreSQL, 
SQL Server) and communicates with each other via RabbitMQ and gRPC. Additionally, Ocelot API Gateway is used to aggregate the services.


### Features :
- **Catalog** : ASP.NET Core Web API with CRUD operations.
- **Basket** : Uses Redis for caching and storage.
- **Discount** :  Implemented as a gRPC service with PostgreSQL.
- **Ordering** : Manages orders with SQL Server.
- **Communication** : RabbitMQ for event-driven messaging.
- **Docker Compose** : Using Docker Compose to simultaneously set up all microservices and databases in development and testing environments.


