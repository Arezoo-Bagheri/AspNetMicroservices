 <h1 >  ASP.NET Core Microservices Practice </h1>


<br/>
This repository includes an online store project designed with microservices such as Catalog, 
Basket, Discount and Ordering. Each service uses separate databases (MongoDB, Redis, PostgreSQL, 
SQL Server) and communicates with each other via RabbitMQ and gRPC. Additionally, Ocelot API Gateway is used to aggregate the services.


### Features :
- **Catalog.API** : This microservice facilitates efficient CRUD operations for product management and integrates MongoDB for data storage. It leverages the Repository Pattern to ensure scalability and maintainability and uses Docker Compose for efficient containerization, enabling streamlined deployment.
<br/>

- **Basket.API** : This microservice facilitates efficient CRUD operations for shopping basket management. It integrates Redis for high-performance in-memory storage and leverages the Repository Pattern to ensure scalability and maintainability. The service leverages Docker Compose for efficient containerization, enabling streamlined deployment.
<br/>

- **Discount** :  Implemented as a gRPC service with PostgreSQL.
- **Ordering** : Manages orders with SQL Server.
- **Communication** : RabbitMQ for event-driven messaging.
- **Docker Compose** : Using Docker Compose to set up all microservices and databases simultaneously in development and testing environments.


