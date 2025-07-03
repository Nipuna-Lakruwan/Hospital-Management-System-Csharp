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
The Hospital Management System (HMS) is a Windows application designed to streamline the operations of a hospital. It provides functionalities for managing patient records, appointments, billing, and user management. The application aims to enhance the efficiency of hospital administration and improve patient care.

## 2. Requirements Analysis
### Functional Requirements
- **User Authentication**: Users must be able to log in to the system with a username and password.
- **Patient Management**: The system should allow users to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and manage appointments for patients.
- **Billing Management**: The system should facilitate the generation of bills for patients based on their treatments and services.
- **User Management**: Admin users can manage other users, including adding new users and resetting passwords.

### Non-Functional Requirements
- **Performance**: The application should respond to user actions within 2 seconds.
- **Usability**: The user interface should be intuitive and easy to navigate.
- **Security**: User data must be protected, and sensitive information should be encrypted.

## 3. Design
### Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer**: User interface components (Windows Forms).
- **Business Logic Layer**: Contains the logic for processing data and managing application flow.
- **Data Access Layer**: Interacts with the database to perform CRUD operations.

### User Interface Design
- **Login Page**: A form for user authentication.
- **Dashboard**: A central hub for navigating to different functionalities (patient management, appointment scheduling, etc.).
- **Patient Records**: A form for viewing and managing patient information.
- **Appointment Management**: A calendar view for scheduling and managing appointments.
- **Billing**: A form for generating and viewing bills.

### Database Design
- **Tables**:
  - `Users`: Stores user credentials and roles.
  - `Patients`: Stores patient information.
  - `Appointments`: Stores appointment details.
  - `Bills`: Stores billing information.

## 4. Implementation
The application is implemented using C# and Windows Forms. Key components include:
- **User Control Classes**: Each functionality (e.g., patient management, appointment scheduling) is encapsulated in user control classes.
- **Database Connection**: MySQL is used for data storage, with the `MySql.Data` library for database interactions.
- **Event Handling**: User actions (button clicks, form loads) are handled through event-driven programming.

### Code Structure
- **Main Program**: Entry point of the application (`Program.cs`).
- **User Controls**: Each feature is implemented in separate user control files (e.g., `recsearch.cs`, `DocApp.cs`).
- **Designer Files**: Each user control has an associated designer file for UI layout (e.g., `recsearch.Designer.cs`).

## 5. Testing
### Testing Strategy
- **Unit Testing**: Individual components are tested for functionality.
- **Integration Testing**: Ensure that different components work together as expected.
- **User Acceptance Testing**: End-users test the application to ensure it meets their needs.

### Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials and are denied access with invalid credentials.
- **Patient Management**: Test adding, updating, and deleting patient records.
- **Appointment Scheduling**: Test scheduling an appointment and checking for conflicts.
- **Billing**: Verify that bills are generated correctly based on services rendered.

## 6. Deployment
The application is packaged for deployment on Windows systems. The deployment process includes:
- **Installation**: Create an installer that sets up the application on the user's machine.
- **Database Setup**: Instructions for setting up the MySQL database and importing initial data.

## 7. Maintenance
### Maintenance Plan
- **Bug Fixes**: Regular updates to fix any identified bugs.
- **Feature Enhancements**: Based on user feedback, new features may be added in future releases.
- **Documentation Updates**: Keep user manuals and technical documentation up to date with changes.

## 8. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations and enhance patient care. By following the SDLC phases, the project ensures a structured approach to development, resulting in a robust and user-friendly application.

---

This documentation serves as a comprehensive guide for the development, testing, and maintenance of the Hospital Management System, ensuring that all stakeholders have a clear understanding of the project.