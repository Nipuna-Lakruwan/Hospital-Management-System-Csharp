# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases to provide a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis
#### 2.1.1. Functional Requirements
- **User Authentication**: Users can log in to the system with a username and password.
- **Patient Management**: Ability to add, update, delete, and view patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments.
- **Billing System**: Generate and manage bills for patients.
- **User Management**: Admin can manage user roles and permissions.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be role-based.
- **Usability**: The application should have an intuitive user interface.

### 2.2. Design
#### 2.2.1. Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: C# classes to handle business rules and data processing.
- **Data Access Layer**: MySQL database for persistent storage.

#### 2.2.2. User Interface Design
- **Login Page**: A form for user authentication.
- **Dashboard**: A main interface displaying key functionalities like patient management, appointment scheduling, and billing.
- **Forms**: Various forms for adding and editing patient records, appointments, and billing information.

### 2.3. Implementation
#### 2.3.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Visual Studio 2022

#### 2.3.2. Code Structure
- **User Controls**: Each functionality is encapsulated in user controls (e.g., `recsearch`, `DocApp`, `addNewRec`).
- **Data Access**: MySQL commands are used to interact with the database.

### 2.4. Testing
#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components are tested for functionality.
- **Integration Testing**: Ensures that different modules work together as expected.
- **User Acceptance Testing (UAT)**: End-users test the application to validate it meets their requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Ensure appointments can be scheduled and viewed correctly.

### 2.5. Deployment
#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital computers with Windows OS.
- A setup installer will be created for easy installation.

#### 2.5.2. User Training
- Training sessions will be conducted for hospital staff to familiarize them with the system.

### 2.6. Maintenance
#### 2.6.1. Maintenance Plan
- Regular updates will be provided to fix bugs and add new features based on user feedback.
- A support team will be available to assist users with any issues.

## 3. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations. By following the SDLC phases, the project aims to deliver a robust and user-friendly application that meets the needs of healthcare providers and patients alike.

## 4. Appendices
### 4.1. Code Snippets
- **Login Functionality**:
    ```csharp
    private void buttonLogin_Click(object sender, EventArgs e)
    {
        // Logic for user authentication
    }
    ```

### 4.2. Database Schema
- **Patient Table**:
    - `PatientID` (int, Primary Key)
    - `Name` (varchar)
    - `DOB` (date)
    - `NIC` (varchar)

### 4.3. References
- MySQL Documentation
- .NET Framework Documentation
- Visual Studio Documentation

This documentation serves as a comprehensive guide for the development, implementation, and maintenance of the Hospital Management System, ensuring all stakeholders are aligned with the project goals and processes.