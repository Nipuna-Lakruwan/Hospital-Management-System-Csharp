# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis
#### 2.1.1. Functional Requirements
- **User Authentication**: Users can log in to the system with a username and password.
- **Patient Management**: Users can add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments.
- **Billing Management**: Users can generate and manage bills for patients.
- **User Management**: Admin users can manage other users, including adding and resetting passwords.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be restricted based on user roles.
- **Usability**: The application should have an intuitive user interface that is easy to navigate.

### 2.2. Design
#### 2.2.1. Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: User interface components (Forms, UserControls).
- **Business Logic Layer**: Classes that handle business rules and data processing.
- **Data Access Layer**: Classes that interact with the database (using MySQL).

#### 2.2.2. User Interface Design
- **Login Page**: A form for user authentication.
- **Dashboard**: A main interface displaying key functionalities (appointments, patient records).
- **Patient Management**: Forms for adding and editing patient details.
- **Appointment Management**: A calendar view for scheduling and managing appointments.
- **Billing**: A form for generating and viewing bills.

### 2.3. Implementation
#### 2.3.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

#### 2.3.2. Code Structure
- **Main Entry Point**: `Program.cs` initializes the application and opens the login page.
- **User Controls**: Each functional area (e.g., `recsearch`, `DocApp`, `manageUsers`) is implemented as a UserControl.
- **Data Access**: MySQL commands are used to interact with the database for CRUD operations.

### 2.4. Testing
#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components and methods are tested for expected functionality.
- **Integration Testing**: Ensure that different modules work together as intended.
- **User Acceptance Testing (UAT)**: End-users test the application to ensure it meets their needs.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Ensure appointments can be scheduled and viewed correctly.
- **Billing Generation**: Validate that bills are generated accurately based on services rendered.

### 2.5. Deployment
#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital servers with access restricted to authorized personnel.
- A backup strategy will be implemented to ensure data integrity.

#### 2.5.2. User Training
- Training sessions will be conducted for hospital staff to familiarize them with the system.
- User manuals and documentation will be provided for reference.

### 2.6. Maintenance
#### 2.6.1. Maintenance Plan
- Regular updates will be scheduled to fix bugs and improve functionality.
- User feedback will be collected to identify areas for enhancement.

#### 2.6.2. Support
- A support team will be available to assist users with any issues or questions regarding the application.

## 3. Conclusion
The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly interface and robust functionality. This documentation outlines the SDLC phases, ensuring a structured approach to development and deployment. Future enhancements will be guided by user feedback and technological advancements.