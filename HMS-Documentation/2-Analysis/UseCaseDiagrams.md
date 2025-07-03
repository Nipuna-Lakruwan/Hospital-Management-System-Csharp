# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the operations of a hospital. It provides functionalities for managing patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases to ensure a structured approach to the development process.

## 2. SDLC Phases

### 2.1. Requirement Analysis

#### 2.1.1. Functional Requirements
- **User Authentication**: Users must be able to log in to the system using a username and password.
- **Patient Management**: The system should allow users to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and cancel appointments.
- **Billing Management**: The system should generate bills for patients based on their treatments and appointments.
- **User Management**: Admin users can manage other users, including adding new users and resetting passwords.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be restricted based on user roles.
- **Usability**: The application should have an intuitive user interface that is easy to navigate.

### 2.2. System Design

#### 2.2.1. Architectural Design
- The application follows a layered architecture:
  - **Presentation Layer**: Windows Forms for user interaction.
  - **Business Logic Layer**: C# classes that handle business rules and data processing.
  - **Data Access Layer**: MySQL database for persistent storage.

#### 2.2.2. Database Design
- **Entities**:
  - **User**: Stores user credentials and roles.
  - **Patient**: Stores patient information such as name, age, and medical history.
  - **Appointment**: Stores appointment details including date, time, and patient ID.
  - **Billing**: Stores billing information related to treatments and appointments.

#### 2.2.3. User Interface Design
- The application features a user-friendly interface with forms for each functionality:
  - Login Page
  - Patient Management Form
  - Appointment Scheduling Form
  - Billing Form
  - User Management Form

### 2.3. Implementation

#### 2.3.1. Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

#### 2.3.2. Code Structure
- The project is organized into several classes and user controls:
  - **User Control Classes**: `recsearch`, `RecDash`, `manageUsers`, `loginPage`, `generatebills`, `docDash`, `DocApp`, `bookApp`, `appsearch`, `appDetails`, `Admin`, `addViewPatRec`, `addViewAppo`, `addViewApp2`, `addNewRec`, `addNewDoc`, `addDash`.
  - **Data Access Classes**: Classes that handle database connections and queries.

### 2.4. Testing

#### 2.4.1. Testing Strategy
- **Unit Testing**: Each class and method will be tested individually to ensure they function as expected.
- **Integration Testing**: The interaction between different modules will be tested.
- **User Acceptance Testing (UAT)**: End-users will test the application to ensure it meets their requirements.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials and are denied access with invalid credentials.
- **Patient Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling, viewing, and canceling appointments.
- **Billing**: Verify that bills are generated correctly based on appointments.

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

The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly application. By following the SDLC phases, the development team ensures that the system is robust, secure, and meets the needs of its users. Regular maintenance and updates will ensure the system remains effective and relevant in the long term.