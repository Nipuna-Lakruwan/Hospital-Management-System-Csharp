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

### Purpose
The purpose of this documentation is to provide a comprehensive overview of the HMS project, detailing each phase of the Software Development Life Cycle (SDLC) and the decisions made throughout the development process.

### Scope
The HMS application will serve hospital staff, including doctors, administrators, and receptionists, allowing them to manage patient information, appointments, and billing processes effectively.

---

## 2. Requirements Analysis
### Functional Requirements
- **User Authentication**: Users must log in to access the system.
- **Patient Management**: Ability to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and cancel appointments.
- **Billing Management**: Generate and manage patient bills.
- **Reporting**: Generate reports for appointments, billing, and patient statistics.

### Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users without performance degradation.
- **Security**: User data must be encrypted, and access should be role-based.
- **Usability**: The application should have an intuitive user interface.

---

## 3. Design
### Architectural Design
The HMS application follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Handles business rules and data processing.
- **Data Access Layer**: Interacts with the database (MySQL).

### User Interface Design
The application features a user-friendly interface with the following components:
- Login Page
- Dashboard for administrators and doctors
- Patient records management
- Appointment scheduling interface
- Billing management interface

### Database Design
The database schema includes tables for:
- Users
- Patients
- Appointments
- Billing records

---

## 4. Implementation
### Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Visual Studio

### Code Structure
The code is organized into several classes and user controls, each responsible for specific functionalities:
- `loginPage.cs`: Handles user authentication.
- `recsearch.cs`: Manages patient record searches.
- `RecDash.cs`: Displays the dashboard for doctors.
- `manageUsers.cs`: Manages user accounts and permissions.

### Key Classes
- **recsearch**: Allows searching for patient records.
- **DocApp**: Manages doctor appointments.
- **bookApp**: Handles appointment booking.

---

## 5. Testing
### Testing Strategy
The testing phase includes unit testing, integration testing, and user acceptance testing (UAT).

### Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Ensure appointments can be scheduled and canceled correctly.
- **Billing Generation**: Validate that bills are generated accurately.

### Testing Tools
- **Unit Testing Framework**: NUnit
- **Manual Testing**: Performed by QA team members.

---

## 6. Deployment
### Deployment Strategy
The application will be deployed on hospital servers with the following steps:
1. Install the .NET framework and MySQL server.
2. Deploy the application files to the server.
3. Configure the database connection strings.
4. Conduct a final round of testing in the production environment.

### User Training
Training sessions will be conducted for hospital staff to familiarize them with the application.

---

## 7. Maintenance
### Maintenance Plan
Post-deployment, the HMS will require regular maintenance, including:
- Bug fixes
- Feature enhancements based on user feedback
- Regular updates to the database schema as needed

### Support
A support team will be available to assist users with any issues encountered while using the application.

---

## 8. Conclusion
The Hospital Management System is designed to enhance the efficiency of hospital operations through a user-friendly interface and robust functionality. This documentation serves as a guide for understanding the project and its components, ensuring that all stakeholders are aligned with the system's objectives and functionalities.

---

This documentation provides a structured overview of the Hospital Management System project, following the SDLC guidelines. Each phase is detailed to ensure clarity and understanding for future reference and development.