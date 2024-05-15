# Ecom Microservices 

## Overview

The Ecom Microservices Project is a collection of microservices designed to support various functionalities within a modern web application ecosystem. This project includes services for authentication, product management, shopping cart, coupon management, email notifications, and reward systems, among others. Each service is developed with scalability, maintainability, and high availability in mind.

## Services Overview

### Authentication Service
- Handles user registration, login, and token generation.
- Implements JWT-based authentication for securing APIs across different services.

### Product Management Service
- Manages products, categories, and inventory.
- Provides endpoints for CRUD operations on products.

### Shopping Cart Service
- Manages shopping carts for users.
- Supports adding items to the cart, updating quantities, and checkout processes.

### Coupon Management Service
- Manages promotional coupons and discounts.
- Allows administrators to create, update, and delete coupons.

### Email Notification Service
- Sends email notifications for various events (e.g., order confirmation, password resets).
- Integrates with external SMTP servers for sending emails.

### Reward System Service
- Manages rewards points for users.
- Tracks user activities and awards points accordingly.

### Gateway Solution
- Acts as a reverse proxy and API gateway for routing requests to appropriate services.
- Secures communication between clients and backend services.

## Getting Started

### Prerequisites

-.NET 6 SDK
- Docker (optional, for containerized deployment)

### Setup

1. Clone the repository to your local machine.
2. Navigate to the root directory of the project.
3. Run `dotnet restore` to restore dependencies.
4. Run `dotnet build` to build the solution.
5. Optionally, run `docker-compose up` to start the services in containers.

### Running the Application

- Use `dotnet run` from the root directory to start the application. Alternatively, use `docker-compose up` if you're using Docker.

## Configuration

Each service reads its configuration from environment variables or JSON configuration files. For production environments, it's recommended to use environment variables for security and flexibility.

## Contributing

Contributions to improve the functionality, performance, or documentation of the Mserve Microservices Project are welcome. Please submit pull requests for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.