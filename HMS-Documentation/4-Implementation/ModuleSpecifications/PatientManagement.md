# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases to provide a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis

#### 2.1.1. Functional Requirements
- **User Authentication**: Users can log in to the system with secure credentials.
- **Patient Management**: Ability to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments.
- **Billing Management**: Generate and manage bills for patients.
- **User Management**: Admins can manage user roles and permissions.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: Sensitive data must be encrypted, and user authentication should be robust.
- **Usability**: The application should have an intuitive user interface for ease of use.

### 2.2. Design

#### 2.2.1. Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: Contains the core functionality and business rules.
- **Data Access Layer**: Manages database connections and queries.

#### 2.2.2. User Interface Design
- **Login Page**: A form for user authentication.
- **Dashboard**: A central hub for navigating to different functionalities (appointments, patient records, etc.).
- **Forms**: Various forms for managing patients, appointments, and billing.

### 2.3. Implementation

#### 2.3.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

#### 2.3.2. Code Structure
- **User Controls**: Modular components for different functionalities (e.g., `recsearch`, `DocApp`, `addNewRec`).
- **Data Models**: Classes representing database entities (e.g., `Patient`, `Appointment`).
- **Database Access**: Use of `MySql.Data` for database operations.

### 2.4. Testing

#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components will be tested for functionality.
- **Integration Testing**: Ensure that different modules work together as expected.
- **User Acceptance Testing (UAT)**: End-users will validate the system against requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Ensure appointments can be scheduled and viewed correctly.

### 2.5. Deployment

#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital computers with Windows OS.
- A setup installer will be created for easy installation.

#### 2.5.2. User Training
- Training sessions will be conducted for hospital staff to familiarize them with the application.

### 2.6. Maintenance

#### 2.6.1. Maintenance Plan
- Regular updates will be provided to fix bugs and add new features based on user feedback.
- A support team will be available to assist users with any issues.

## 3. Conclusion

The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly application. By following the SDLC phases, we ensure that the system is well-designed, thoroughly tested, and ready for deployment. This documentation serves as a guide for developers, testers, and users involved in the project.