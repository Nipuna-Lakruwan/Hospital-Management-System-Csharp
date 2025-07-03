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
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointment scheduling, billing, and user management. The application aims to enhance the efficiency of hospital staff and improve patient care through a user-friendly interface and robust backend.

## 2. Requirements Analysis
### Functional Requirements
- **User Authentication**: Users must log in to access the system.
- **Patient Management**: Ability to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments.
- **Billing System**: Generate and manage patient bills.
- **User Management**: Admins can manage user accounts and permissions.

### Non-Functional Requirements
- **Performance**: The application should handle multiple users simultaneously without significant delays.
- **Security**: Sensitive data must be encrypted, and user access should be controlled.
- **Usability**: The interface should be intuitive and easy to navigate.

## 3. Design
### Architecture
The HMS follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: Handles the core functionality and business rules.
- **Data Access Layer**: Interacts with the MySQL database for data storage and retrieval.

### User Interface Design
- **Login Page**: Allows users to authenticate.
- **Dashboard**: Displays key metrics and navigation options.
- **Patient Records**: A form for managing patient information.
- **Appointment Management**: A calendar view for scheduling and managing appointments.
- **Billing**: A section for generating and viewing bills.

### Database Design
- **Entities**: Patients, Appointments, Users, Bills.
- **Relationships**: 
  - One-to-Many between Patients and Appointments.
  - One-to-Many between Users and Appointments.

## 4. Implementation
### Development Environment
- **Programming Language**: C#
- **Framework**: .NET 8.0
- **Database**: MySQL
- **IDE**: Visual Studio

### Code Structure
- **User Controls**: Each feature (e.g., patient management, appointment scheduling) is implemented as a user control.
- **Data Access**: MySQL commands are used to interact with the database, encapsulated within repository classes.

### Key Classes and Methods
- **recsearch.cs**: Handles patient search functionality.
- **RecDash.cs**: Manages the dashboard and displays key metrics.
- **manageUsers.cs**: Manages user accounts and permissions.
- **generatebills.cs**: Generates and prints patient bills.

## 5. Testing
### Testing Strategy
- **Unit Testing**: Individual components are tested for correctness.
- **Integration Testing**: Ensures that different modules work together as expected.
- **User Acceptance Testing (UAT)**: End-users validate the application against requirements.

### Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Ensure appointments can be scheduled and viewed correctly.
- **Billing**: Validate that bills are generated accurately.

## 6. Deployment
### Deployment Strategy
- The application will be deployed on hospital computers running Windows.
- A setup installer will be created to simplify the installation process.

### Deployment Steps
1. Build the application in Release mode.
2. Create an installer package using Visual Studio Installer Projects.
3. Distribute the installer to hospital staff.

## 7. Maintenance
### Maintenance Plan
- **Bug Fixes**: Address any issues reported by users promptly.
- **Updates**: Regularly update the application to add new features and improve performance.
- **User Support**: Provide ongoing support to users for troubleshooting and training.

## 8. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations and enhance patient care. By following the SDLC phases, the project ensures a structured approach to development, leading to a robust and user-friendly application. Future enhancements will focus on expanding functionality and improving user experience based on feedback.

---

This documentation serves as a comprehensive guide for the development and maintenance of the Hospital Management System, ensuring that all stakeholders have a clear understanding of the project.