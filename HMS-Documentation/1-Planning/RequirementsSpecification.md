# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis

#### 2.1.1. Functional Requirements
- **User Authentication**: Users must be able to log in to the system using a username and password.
- **Patient Management**: The system should allow users to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments for patients.
- **Billing Management**: The system should facilitate the generation and management of bills for patients.
- **User Management**: Admin users can manage other users, including adding new users and resetting passwords.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be restricted based on user roles.
- **Usability**: The application should have an intuitive user interface that is easy to navigate.

### 2.2. Design

#### 2.2.1. Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: C# classes that handle business rules and data processing.
- **Data Access Layer**: MySQL database for persistent storage of data.

#### 2.2.2. User Interface Design
- **Login Page**: A form for user authentication.
- **Dashboard**: A central interface for navigating to different modules (patient management, appointment scheduling, etc.).
- **Forms**: Various forms for managing patients, appointments, and billing.

### 2.3. Implementation

#### 2.3.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

#### 2.3.2. Code Structure
The project is organized into several classes and user controls:
- **User Controls**: `recsearch`, `RecDash`, `manageUsers`, `loginPage`, `generatebills`, `docDash`, `DocApp`, `bookApp`, `appsearch`, `appDetails`, `Admin`, `addViewPatRec`, `addViewAppo`, `addNewRec`, `addNewDoc`, `addDash`.
- **Data Access**: Classes that handle database connections and queries.

### 2.4. Testing

#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components will be tested for functionality.
- **Integration Testing**: Ensure that different modules work together as expected.
- **User Acceptance Testing (UAT)**: End-users will validate the system against requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials and are denied access with invalid credentials.
- **Patient Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test the ability to schedule and view appointments.

### 2.5. Deployment

#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital computers with Windows OS.
- A setup installer will be created for easy installation.

#### 2.5.2. User Training
- Training sessions will be conducted for hospital staff to familiarize them with the system.

### 2.6. Maintenance

#### 2.6.1. Maintenance Plan
- Regular updates will be provided to fix bugs and improve functionality.
- User feedback will be collected for future enhancements.

#### 2.6.2. Support
- A support team will be available to assist users with any issues they encounter.

## 3. Conclusion

The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly application. By following the SDLC phases, the project ensures that all requirements are met, and the system is robust, secure, and maintainable. 

## 4. Appendices

### 4.1. Glossary
- **HMS**: Hospital Management System
- **UAT**: User Acceptance Testing
- **SDLC**: Software Development Life Cycle

### 4.2. References
- Microsoft Documentation for C# and .NET
- MySQL Documentation for database management

---

This documentation provides a structured overview of the Hospital Management System project, ensuring clarity and comprehensiveness for all stakeholders involved in the development and use of the application.