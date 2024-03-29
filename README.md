# SPA Management System

The SPA Management System is a Windows Forms application designed to streamline spa management operations, including user registration, service searching, booking, and availability tracking. The system comprises five forms, each serving a specific purpose in managing spa-related tasks.

## Forms Overview

### Form3: User Registration
- **Description**: Allows new users to create accounts by providing necessary details such as username, password, and email. Checks for username uniqueness and password strength.
- **Features**:
  - Validates user inputs for username, email, and password strength.
  - Inserts user information into the database upon successful registration.

### Form4: User Login
- **Description**: Enables existing users to log in to the system using their credentials (username and password). Performs authentication to grant access to the system.
- **Features**:
  - Authenticates user credentials against the database.
  - Grants access to authenticated users and displays Form1 upon successful login.

### Form1: Service Search and Booking
- **Description**: Allows users to search for spa services based on various criteria such as service name, location, employee, and availability status. Users can browse available services and initiate the booking process.
- **Features**:
  - Dynamic filtering of services based on user-selected criteria.
  - Displays search results in a DataGridView.
  - Provides options to clear search filters and book selected services.

### Form2: Service Booking Interface
- **Description**: Facilitates the booking of spa services by collecting customer information and selecting available service slots. Checks service availability before confirming the booking.
- **Features**:
  - Validates user inputs and ensures the selected service is available for booking.
  - Inserts booking information into the database and updates the availability status.

### Form5: Booking Management
- **Description**: Provides functionalities for managing existing bookings, including searching, editing, and deleting bookings.
- **Features**:
  - Allows searching for bookings by customer name.
  - Enables editing and updating of booking details directly within the DataGridView.
  - Supports deletion of bookings from the system.

## Database Connectivity
- The system utilizes Microsoft SQL Server for data storage and retrieval.
- Connection strings are configured within each form to establish database connections.

## Dependencies
- The system relies on the .NET Framework and Windows Forms for its graphical user interface (GUI) and functionality implementation.

## Getting Started
- To run the SPA Management System, ensure that the required dependencies are installed and configured.
- Open the solution file in Visual Studio or any compatible IDE.
- Build and run the solution to launch the application.
- Users can interact with the system through the various forms provided.
