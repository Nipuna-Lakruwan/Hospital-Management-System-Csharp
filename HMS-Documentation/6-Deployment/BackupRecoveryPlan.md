# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis

#### 2.1.1. Functional Requirements
- **User Authentication**: Allow users to log in and manage their sessions.
- **Patient Management**: Add, update, and view patient details.
- **Appointment Scheduling**: Schedule, view, and manage patient appointments.
- **Billing Management**: Generate and manage bills for patients.
- **User Management**: Admin functionalities to manage users and their roles.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The application should handle multiple users simultaneously without significant delays.
- **Security**: User data must be protected, and sensitive information should be encrypted.
- **Usability**: The application should have an intuitive user interface for ease of use.

### 2.2. System Design

#### 2.2.1. Architecture
The HMS follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Handles business rules and logic.
- **Data Access Layer**: Interacts with the database using MySQL.

#### 2.2.2. Database Design
- **Entities**:
  - **Users**: Stores user credentials and roles.
  - **Patients**: Stores patient information.
  - **Appointments**: Stores appointment details.
  - **Bills**: Stores billing information.

#### 2.2.3. User Interface Design
- **Login Page**: For user authentication.
- **Dashboard**: Overview of hospital operations.
- **Patient Management**: Forms for adding and updating patient records.
- **Appointment Management**: Calendar view for scheduling appointments.
- **Billing Section**: Interface for generating and viewing bills.

### 2.3. Implementation

#### 2.3.1. Technologies Used
- **Programming Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Database**: MySQL
- **Libraries**: MySql.Data for database connectivity, Guna.UI2 for UI components.

#### 2.3.2. Code Structure
- **Main Entry Point**: `Program.cs` initializes the application.
- **User Controls**: Each feature (e.g., patient management, appointment scheduling) is implemented as a user control.
- **Data Access**: Database operations are encapsulated in methods within the respective classes.

### 2.4. Testing

#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components and methods are tested for correctness.
- **Integration Testing**: Ensures that different modules work together as expected.
- **User Acceptance Testing (UAT)**: End-users test the application to validate it meets their requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify valid and invalid login attempts.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling and viewing appointments.
- **Billing Generation**: Verify the accuracy of generated bills.

### 2.5. Deployment

#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital computers with Windows OS.
- A setup installer will be created for easy installation.

#### 2.5.2. Maintenance
- Regular updates will be provided to fix bugs and add new features based on user feedback.

### 2.6. Documentation

#### 2.6.1. User Documentation
- A user manual will be provided, detailing how to use each feature of the application.

#### 2.6.2. Technical Documentation
- Code comments and inline documentation will be maintained for future developers.

## 3. Conclusion

The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly interface and robust backend. Following the SDLC phases ensures that the project is well-structured, meets user requirements, and is maintainable in the long run.