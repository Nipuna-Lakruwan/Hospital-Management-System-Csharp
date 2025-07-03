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
The HMS application will cover the following functionalities:
- Patient registration and management
- Appointment scheduling
- Billing and invoicing
- User management (doctors, nurses, and administrative staff)
- Reporting and analytics

---

## 2. Requirements Analysis
### Functional Requirements
- **User Authentication**: Users must log in to access the system.
- **Patient Management**: Ability to add, update, and delete patient records.
- **Appointment Management**: Schedule, reschedule, and cancel appointments.
- **Billing System**: Generate bills and manage payments.
- **User Roles**: Different access levels for doctors, nurses, and admin staff.

### Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users.
- **Usability**: The interface should be user-friendly and intuitive.
- **Security**: Sensitive data must be encrypted and access controlled.

### Tools and Technologies
- **Programming Language**: C#
- **Database**: MySQL
- **Framework**: .NET Framework
- **Development Environment**: Visual Studio

---

## 3. Design
### Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Handles business rules and data processing.
- **Data Access Layer**: Interacts with the MySQL database.

### User Interface Design
The application features a clean and intuitive UI, with separate forms for different functionalities:
- Login Page
- Dashboard
- Patient Management
- Appointment Management
- Billing

### Database Design
The database schema includes tables for:
- Users
- Patients
- Appointments
- Billing Records

---

## 4. Implementation
### Development Environment Setup
- Visual Studio was used for development, with the .NET Framework installed.
- MySQL database was set up locally for testing.

### Code Structure
The project is organized into several classes and user controls, each responsible for specific functionalities:
- **User Control Classes**: `recsearch`, `DocApp`, `addNewRec`, etc.
- **Data Access Classes**: Classes that handle database connections and queries.

### Key Classes
- **recsearch.cs**: Manages patient search functionality.
- **DocApp.cs**: Handles doctor-related operations.
- **addNewRec.cs**: Facilitates the addition of new patient records.

---

## 5. Testing
### Testing Strategy
- **Unit Testing**: Individual components were tested for functionality.
- **Integration Testing**: Ensured that different modules work together seamlessly.
- **User Acceptance Testing (UAT)**: Conducted with end-users to validate the application meets requirements.

### Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Registration**: Ensure that new patients can be added successfully.
- **Appointment Scheduling**: Test the ability to schedule and cancel appointments.

---

## 6. Deployment
### Deployment Strategy
The application was deployed on local machines within the hospital network. Installation instructions were provided to the IT department for setup.

### User Training
Training sessions were conducted for hospital staff to familiarize them with the application and its features.

---

## 7. Maintenance
### Maintenance Plan
- **Bug Fixes**: Regular updates will be provided to fix any identified bugs.
- **Feature Enhancements**: Future versions may include additional features based on user feedback.
- **Database Maintenance**: Regular backups and performance checks will be conducted.

---

## 8. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations and enhance patient care. This documentation outlines the SDLC phases, providing a clear understanding of the project’s development process. Continuous feedback and updates will ensure the system remains effective and user-friendly.

---

### Appendices
- **Appendix A**: Code Snippets
- **Appendix B**: User Manuals
- **Appendix C**: Test Reports

This documentation serves as a reference for developers, users, and stakeholders involved in the Hospital Management System project.