# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases to provide a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis
#### 2.1.1. Functional Requirements
- **User Authentication**: Users can log in to the system with valid credentials.
- **Patient Management**: Users can add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments.
- **Billing Management**: Users can generate and manage bills for patients.
- **User Management**: Admin users can manage other users, including adding and resetting passwords.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be controlled based on user roles.
- **Usability**: The application should have an intuitive user interface that is easy to navigate.

### 2.2. System Design
#### 2.2.1. Architecture
The HMS follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: C# classes that handle business rules and data processing.
- **Data Access Layer**: MySQL database for persistent storage.

#### 2.2.2. User Interface Design
- **Login Page**: A form for user authentication.
- **Dashboard**: A central hub for navigating to different functionalities (appointments, patient records, billing).
- **Patient Records**: A form for managing patient information.
- **Appointment Management**: A form for scheduling and viewing appointments.
- **Billing**: A form for generating and managing bills.

### 2.3. Implementation
#### 2.3.1. Technologies Used
- **Programming Language**: C#
- **Database**: MySQL
- **Framework**: .NET Framework for Windows Forms applications
- **Libraries**: MySql.Data for database connectivity, Guna.UI2 for UI components.

#### 2.3.2. Code Structure
- **Main Entry Point**: `Program.cs` initializes the application and opens the login page.
- **User Controls**: Each functionality (e.g., `recsearch`, `DocApp`, `addNewRec`) is implemented as a user control for modularity.
- **Data Access**: Database operations are encapsulated in methods that utilize MySQL commands and connections.

### 2.4. Testing
#### 2.4.1. Testing Strategy
- **Unit Testing**: Individual components (e.g., data access methods) are tested for correctness.
- **Integration Testing**: The interaction between different modules (e.g., patient management and appointment scheduling) is tested.
- **User Acceptance Testing (UAT)**: End-users test the application to ensure it meets their requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that valid credentials allow access and invalid credentials do not.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling an appointment and checking for conflicts.

### 2.5. Deployment
#### 2.5.1. Deployment Strategy
- The application will be deployed on hospital computers with Windows OS.
- A setup installer will be created to simplify the installation process.

#### 2.5.2. Maintenance
- Regular updates will be provided to fix bugs and add new features based on user feedback.
- A support system will be established for users to report issues and request assistance.

### 2.6. Documentation
#### 2.6.1. User Documentation
- A user manual will be provided to guide users on how to navigate and use the application effectively.

#### 2.6.2. Technical Documentation
- Code comments and inline documentation will be maintained for future developers.
- A technical manual will be created to explain the architecture, design decisions, and setup instructions.

## 3. Conclusion
The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly interface and robust functionality. Following the SDLC phases ensures that the project is well-structured, meets user needs, and is maintainable in the long term.