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
The purpose of this documentation is to provide a comprehensive overview of the HMS project, detailing each phase of the Software Development Life Cycle (SDLC) to ensure clarity and facilitate future development and maintenance.

### Scope
This document covers the requirements, design, implementation, testing, deployment, and maintenance of the HMS application.

---

## 2. Requirements Analysis

### Functional Requirements
- **User Authentication**: Users must be able to log in to the system using their credentials.
- **Patient Management**: The system should allow users to add, update, and delete patient records.
- **Appointment Scheduling**: Users should be able to schedule, view, and manage appointments.
- **Billing Management**: The system should handle billing and generate invoices for patients.
- **User Management**: Admin users should be able to manage other users, including adding and removing users.

### Non-Functional Requirements
- **Performance**: The application should respond to user actions within 2 seconds.
- **Usability**: The user interface should be intuitive and easy to navigate.
- **Security**: User data must be protected, and sensitive information should be encrypted.

---

## 3. Design

### Architectural Design
The HMS application follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Contains the core functionality and business rules.
- **Data Access Layer**: Manages database interactions using MySQL.

### User Interface Design
The application features a user-friendly interface with the following components:
- **Login Page**: For user authentication.
- **Dashboard**: Displays an overview of hospital operations.
- **Patient Records**: Interface for managing patient information.
- **Appointment Management**: Interface for scheduling and managing appointments.
- **Billing Section**: For handling billing and payments.

### Database Design
The database schema includes tables for:
- Users
- Patients
- Appointments
- Billing Records

---

## 4. Implementation

### Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Microsoft Visual Studio

### Code Structure
The code is organized into several classes and user controls, each responsible for specific functionalities:
- `loginPage.cs`: Handles user authentication.
- `recsearch.cs`: Manages patient record searches.
- `RecDash.cs`: Displays the dashboard with various statistics.
- `manageUsers.cs`: Manages user accounts and permissions.

### Key Classes and Methods
- **User Authentication**: Methods for validating user credentials.
- **Patient Management**: Methods for adding, updating, and deleting patient records.
- **Appointment Scheduling**: Methods for creating and managing appointments.

---

## 5. Testing

### Testing Strategy
The testing phase includes unit testing, integration testing, and user acceptance testing (UAT).

### Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials and are denied access with invalid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling and viewing appointments.

### Tools Used
- **Unit Testing Framework**: NUnit
- **Manual Testing**: Conducted by the QA team.

---

## 6. Deployment

### Deployment Strategy
The application will be deployed on hospital computers with the following steps:
1. Install the .NET framework if not already installed.
2. Install MySQL and set up the database.
3. Deploy the application executable and necessary files to the target machines.

### User Training
Training sessions will be conducted for hospital staff to familiarize them with the application.

---

## 7. Maintenance

### Maintenance Plan
Regular updates will be provided to fix bugs, improve performance, and add new features based on user feedback.

### Support
A support team will be available to assist users with any issues encountered while using the application.

---

## 8. Conclusion
The Hospital Management System is designed to enhance the efficiency of hospital operations. By following the SDLC phases, the project aims to deliver a robust and user-friendly application that meets the needs of healthcare providers and improves patient care. Future enhancements will focus on expanding functionalities and integrating with other healthcare systems.

--- 

This documentation serves as a comprehensive guide for the development, deployment, and maintenance of the Hospital Management System, ensuring that all stakeholders have a clear understanding of the project.