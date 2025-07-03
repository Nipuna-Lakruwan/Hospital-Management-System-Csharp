# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, detailing the requirements, design, implementation, testing, deployment, and maintenance of the application.

## 2. Requirements Analysis
### 2.1 Functional Requirements
- **User Authentication**: Users must be able to log in with a username and password.
- **Patient Management**: The system should allow users to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage patient appointments.
- **Billing Management**: The system should generate bills for patients based on services rendered.
- **User Management**: Admin users can manage other users, including adding new users and resetting passwords.

### 2.2 Non-Functional Requirements
- **Performance**: The application should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be controlled based on user roles.
- **Usability**: The application should have an intuitive user interface that is easy to navigate.

## 3. System Design
### 3.1 Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Contains the logic for managing patient records, appointments, and billing.
- **Data Access Layer**: Interacts with the MySQL database to perform CRUD operations.

### 3.2 Database Design
The database schema includes the following tables:
- **Users**: Stores user credentials and roles.
- **Patients**: Contains patient information such as name, age, and medical history.
- **Appointments**: Records appointment details, including patient ID, date, and time.
- **Bills**: Stores billing information related to services provided to patients.

### 3.3 User Interface Design
The application features a user-friendly interface with the following forms:
- **Login Page**: For user authentication.
- **Dashboard**: Displays an overview of hospital operations.
- **Patient Management**: For adding, updating, and viewing patient records.
- **Appointment Management**: For scheduling and managing appointments.
- **Billing**: For generating and viewing patient bills.

## 4. Implementation
### 4.1 Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

### 4.2 Code Structure
The project is organized into several classes and user controls:
- **User Control Classes**: `recsearch`, `RecDash`, `manageUsers`, `loginPage`, etc.
- **Data Access Classes**: Classes responsible for database interactions.
- **Business Logic Classes**: Classes that implement the core functionality of the application.

### 4.3 Key Code Snippets
- **Database Connection**:
    ```csharp
    using (MySqlConnection conn = new MySqlConnection(conString))
    {
        conn.Open();
        // Execute queries
    }
    ```

- **User Authentication**:
    ```csharp
    private void Login()
    {
        // Validate user credentials
    }
    ```

## 5. Testing
### 5.1 Testing Strategy
- **Unit Testing**: Individual components are tested for correctness.
- **Integration Testing**: Ensures that different modules work together as expected.
- **User Acceptance Testing (UAT)**: End-users test the application to ensure it meets their requirements.

### 5.2 Test Cases
- **Login Functionality**: Test valid and invalid login attempts.
- **Patient Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling and viewing appointments.

## 6. Deployment
### 6.1 Deployment Strategy
The application will be deployed on hospital computers with the following steps:
1. Install the .NET runtime and MySQL database.
2. Deploy the application executable and necessary files.
3. Configure database connection settings.

### 6.2 User Training
Training sessions will be conducted for hospital staff to familiarize them with the application.

## 7. Maintenance
### 7.1 Maintenance Plan
- **Bug Fixes**: Regular updates to fix any identified bugs.
- **Feature Enhancements**: Based on user feedback, new features will be added.
- **Database Maintenance**: Regular backups and performance tuning of the database.

### 7.2 Support
A support team will be available to assist users with any issues they encounter while using the application.

## 8. Conclusion
The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly application. This documentation provides a comprehensive overview of the project, following the SDLC phases to ensure a structured approach to development and deployment.