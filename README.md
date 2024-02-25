# Online Hotel Reservation System

## Overview
The Online Hotel Reservation System is designed with Clean Architecture principles to create a scalable, maintainable, and adaptable platform for users to book hotel rooms. Clean Architecture aims to separate concerns, making the system independent of frameworks, UI, database, and any external agency.

## Features
- **User Experience**: Intuitive booking process, searching, and management of reservations.
- **Security**: Robust authentication and authorization for users and admins.
- **Admin Panel**: Manage hotel data and reservations.
- **Responsive Design**: Compatible with various devices and screen sizes.

## Clean Architecture Layers
The system is structured into the following layers, with each having distinct responsibilities:

- **Domain**: Contains all entities, enums, exceptions, interfaces, types, and logic specific to the domain layer.
- **Application**: Houses the application logic and defines the interfaces that are implemented by the outside layers. It contains commands, queries, validators, and DTOs.
- **Infrastructure**: Implements persistence and data access logic. It interacts with databases and external resources.
- **Presentation**: Focuses on delivering the UI, which could be an API, a web application, or a mobile app. In our case, it's a web application using React.
- **Cross-Cutting Concerns**: Such as logging, caching, and security, are implemented throughout the layers as needed.

## Getting Started

### Prerequisites
List of software and tools needed.

### Setup
Step-by-step setup instructions.

## Running the Tests
Instructions on running automated tests.

## Deployment
Guidance on how to deploy the application.

## Built With
- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) - Backend API
- [React](https://reactjs.org/) - Frontend Web Application
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - Data Access
- [MediatR](https://github.com/jbogard/MediatR) - Mediator Pattern Implementation
- [AutoMapper](https://automapper.org/) - Object Mapping

## Contributing
Contribution guidelines.

## Versioning
Versioning information.

## Authors
- **Your Name**

## License
License details.

## Acknowledgments
Credits and acknowledgments.
