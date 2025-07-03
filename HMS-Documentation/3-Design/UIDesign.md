# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Planning

#### 2.1.1. Objectives
- To develop a user-friendly application for managing hospital operations.
- To ensure secure handling of patient data and appointments.
- To provide an efficient billing system for patients.

#### 2.1.2. Scope
- Patient management (registration, details, and history).
- Appointment scheduling and management.
- Billing and invoicing functionalities.
- User management for hospital staff.

### 2.2. Requirements Analysis

#### 2.2.1. Functional Requirements
- **User Authentication**: Login functionality for different user roles (admin, doctor, receptionist).
- **Patient Management**: Add, update, delete, and view patient records.
- **Appointment Management**: Schedule, reschedule, and cancel appointments.
- **Billing**: Generate bills and manage payments.
- **Reporting**: Generate reports for patient visits, billing, and appointments.

#### 2.2.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: Data encryption for sensitive information and secure user authentication.
- **Usability**: Intuitive user interface for ease of use by hospital staff.

### 2.3. Design

#### 2.3.1. Architecture
The application follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: C# classes handling business rules and data processing.
- **Data Access Layer**: MySQL database for persistent data storage.

#### 2.3.2. User Interface Design
- **Login Page**: User authentication interface.
- **Dashboard**: Main interface displaying key functionalities (appointments, patient records, billing).
- **Patient Management**: Forms for adding and editing patient details.
- **Appointment Management**: Calendar view for scheduling.

### 2.4. Implementation

#### 2.4.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Visual Studio 2022

#### 2.4.2. Code Structure
- **User Controls**: Modular design using user controls for different functionalities (e.g., `recsearch`, `DocApp`, `addNewRec`).
- **Data Access**: Use of MySQL.Data library for database interactions.

### 2.5. Testing

#### 2.5.1. Testing Strategy
- **Unit Testing**: Individual components will be tested for functionality.
- **Integration Testing**: Ensure that different modules work together seamlessly.
- **User Acceptance Testing (UAT)**: End-users will validate the application against requirements.

#### 2.5.2. Test Cases
- **Login Functionality**: Test valid and invalid login attempts.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling and canceling appointments.

### 2.6. Deployment

#### 2.6.1. Deployment Strategy
- The application will be deployed on hospital servers with access for authorized personnel.
- Installation packages will be created for easy deployment on client machines.

#### 2.6.2. User Training
- Training sessions will be conducted for hospital staff to familiarize them with the application.

### 2.7. Maintenance

#### 2.7.1. Maintenance Plan
- Regular updates will be provided to fix bugs and improve functionality.
- User feedback will be collected for future enhancements.

#### 2.7.2. Support
- A support team will be available to assist users with any issues encountered.

## 3. Conclusion

The Hospital Management System aims to improve the efficiency of hospital operations through a comprehensive software solution. By following the SDLC phases, the project ensures a structured approach to development, leading to a robust and user-friendly application.