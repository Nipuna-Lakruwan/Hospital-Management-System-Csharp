# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the operations of a hospital. It provides functionalities for managing patient records, appointments, billing, and user management. This documentation outlines the phases of the Software Development Life Cycle (SDLC) followed during the development of the HMS.

## 2. SDLC Phases

### 2.1. Requirement Analysis

#### 2.1.1. Purpose
To gather and analyze the requirements of the hospital management system from stakeholders, including hospital staff, doctors, and administrative personnel.

#### 2.1.2. Requirements
- **User Management**: Ability to add, edit, and delete user accounts.
- **Patient Management**: Manage patient records, including personal details, medical history, and appointments.
- **Appointment Scheduling**: Schedule, view, and manage patient appointments.
- **Billing System**: Generate and manage bills for patients.
- **Reporting**: Generate reports for appointments, billing, and patient statistics.

### 2.2. Design

#### 2.2.1. Architectural Design
The application follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Handles the business rules and logic.
- **Data Access Layer**: Interacts with the database to perform CRUD operations.

#### 2.2.2. User Interface Design
- **Login Page**: For user authentication.
- **Dashboard**: Overview of hospital operations.
- **Patient Management**: Forms for adding and editing patient records.
- **Appointment Management**: Interface for scheduling and viewing appointments.
- **Billing**: Interface for generating and managing bills.

### 2.3. Implementation

#### 2.3.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

#### 2.3.2. Code Structure
The project is organized into several classes and user controls:
- **User Controls**: `recsearch`, `RecDash`, `manageUsers`, `loginPage`, `generatebills`, `docDash`, `DocApp`, `bookApp`, `appsearch`, `appDetails`, `Admin`, `addViewPatRec`, `addViewAppo`, `addNewRec`, `addNewDoc`, `addDash`.
- **Data Access**: Classes for handling database connections and queries.

### 2.4. Testing

#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components and methods are tested for expected functionality.
- **Integration Testing**: Ensure that different modules work together as intended.
- **User Acceptance Testing (UAT)**: Conducted with end-users to validate the system against requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Test adding, editing, and deleting patient records.
- **Appointment Scheduling**: Ensure appointments can be scheduled and viewed correctly.
- **Billing Process**: Validate the generation of bills and payment processing.

### 2.5. Deployment

#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital computers with Windows OS.
- Installation packages will be created for easy deployment.

#### 2.5.2. User Training
- Training sessions will be conducted for hospital staff to familiarize them with the system.

### 2.6. Maintenance

#### 2.6.1. Maintenance Plan
- Regular updates will be provided to fix bugs and add new features based on user feedback.
- A support team will be available to assist users with any issues.

## 3. Conclusion

The Hospital Management System is designed to improve the efficiency of hospital operations. By following the SDLC phases, the project aims to deliver a robust and user-friendly application that meets the needs of its users. Continuous feedback and updates will ensure that the system remains relevant and effective in managing hospital activities.