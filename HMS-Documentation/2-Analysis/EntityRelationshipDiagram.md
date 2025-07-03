# Documentation for Hospital Management System (HMS)

## Table of Contents
1. Introduction
2. Requirements Analysis
3. Design
4. Implementation
5. Testing
6. Deployment
7. Maintenance
8. Conclusion

---

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. The application aims to improve efficiency, reduce errors, and enhance the overall patient experience.

## 2. Requirements Analysis
### 2.1 Functional Requirements
- **User Authentication**: Users must be able to log in to the system using a username and password.
- **Patient Management**: The system should allow users to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and cancel appointments.
- **Billing Management**: The system should generate bills for patients based on services rendered.
- **User Management**: Admin users can manage other users, including adding new users and resetting passwords.

### 2.2 Non-Functional Requirements
- **Performance**: The application should handle up to 100 concurrent users without significant performance degradation.
- **Security**: User data must be encrypted, and access should be restricted based on user roles.
- **Usability**: The application should have an intuitive user interface that is easy to navigate.

## 3. Design
### 3.1 Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Contains the core functionality and business rules.
- **Data Access Layer**: Manages database interactions using MySQL.

### 3.2 User Interface Design
- **Login Page**: A simple form for user authentication.
- **Dashboard**: A central hub for accessing various functionalities like patient management, appointment scheduling, and billing.
- **Forms**: Separate forms for adding/editing patient records, scheduling appointments, and managing users.

### 3.3 Database Design
- **Entities**: Patients, Appointments, Users, Bills.
- **Relationships**: 
  - One-to-many relationship between Patients and Appointments.
  - One-to-many relationship between Users and Appointments.

## 4. Implementation
### 4.1 Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

### 4.2 Code Structure
- **User Controls**: Each functional area (e.g., patient management, appointment scheduling) is implemented as a user control.
- **Event Handling**: Events are used to handle user interactions, such as button clicks and form loading.

### 4.3 Key Classes and Methods
- **recsearch.cs**: Handles patient search functionality.
- **RecDash.cs**: Manages the dashboard and displays relevant information.
- **manageUsers.cs**: Manages user accounts and permissions.

## 5. Testing
### 5.1 Testing Strategy
- **Unit Testing**: Individual components are tested for expected functionality.
- **Integration Testing**: Ensures that different modules work together as intended.
- **User Acceptance Testing (UAT)**: End-users test the application to ensure it meets their needs.

### 5.2 Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials and are denied access with invalid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Verify that appointments can be scheduled and canceled correctly.

## 6. Deployment
### 6.1 Deployment Strategy
- The application will be deployed on hospital computers running Windows.
- A setup installer will be created to facilitate easy installation.

### 6.2 User Training
- Training sessions will be conducted for hospital staff to familiarize them with the application.

## 7. Maintenance
### 7.1 Maintenance Plan
- Regular updates will be provided to fix bugs and add new features based on user feedback.
- A support team will be available to assist users with any issues.

## 8. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations and enhance patient care. By following the SDLC phases, the project aims to deliver a robust and user-friendly application that meets the needs of healthcare providers.

---

This documentation provides a comprehensive overview of the Hospital Management System project, covering all phases of the Software Development Life Cycle.