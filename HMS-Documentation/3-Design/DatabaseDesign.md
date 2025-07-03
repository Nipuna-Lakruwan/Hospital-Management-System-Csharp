# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Requirement Analysis
#### 2.1.1. Functional Requirements
- **User Authentication**: Users can log in to the system with a username and password.
- **Patient Management**: Ability to add, update, and delete patient records.
- **Appointment Scheduling**: Users can schedule, view, and cancel appointments.
- **Billing Management**: Generate and manage patient bills.
- **User Management**: Admins can manage user accounts and permissions.

#### 2.1.2. Non-Functional Requirements
- **Performance**: The system should handle up to 100 concurrent users.
- **Security**: User data must be encrypted, and access should be role-based.
- **Usability**: The application should have an intuitive user interface.

### 2.2. System Design
#### 2.2.1. Architecture
The HMS follows a layered architecture:
- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic Layer**: C# classes handling business rules.
- **Data Access Layer**: MySQL database for data storage.

#### 2.2.2. Database Design
- **Entities**:
  - **Users**: Stores user credentials and roles.
  - **Patients**: Stores patient information.
  - **Appointments**: Stores appointment details.
  - **Bills**: Stores billing information.

- **Relationships**:
  - One-to-many relationship between Users and Appointments.
  - One-to-many relationship between Patients and Appointments.

### 2.3. Implementation
#### 2.3.1. Development Environment
- **IDE**: Microsoft Visual Studio
- **Language**: C#
- **Database**: MySQL
- **Framework**: .NET 8.0

#### 2.3.2. Code Structure
- **User Controls**: Each feature (e.g., patient management, appointment scheduling) is implemented as a user control.
- **Form Classes**: Main forms for user interaction (e.g., login, admin dashboard).
- **Data Access Classes**: Classes for database operations (CRUD operations).

### 2.4. Testing
#### 2.4.1. Testing Strategy
- **Unit Testing**: Test individual components for expected functionality.
- **Integration Testing**: Test interactions between components.
- **User Acceptance Testing (UAT)**: Validate the system with end-users.

#### 2.4.2. Test Cases
- **Login Functionality**: Verify that users can log in with valid credentials.
- **Patient Record Management**: Ensure that records can be added, updated, and deleted.
- **Appointment Scheduling**: Check that appointments can be scheduled and canceled correctly.

### 2.5. Deployment
#### 2.5.1. Deployment Strategy
- **Installation Package**: Create an installer for easy deployment on user machines.
- **Database Setup**: Provide scripts for database creation and initial data population.

#### 2.5.2. User Training
- **Documentation**: Provide user manuals and online help.
- **Training Sessions**: Conduct training for hospital staff on using the system.

### 2.6. Maintenance
#### 2.6.1. Maintenance Plan
- **Bug Fixes**: Regular updates to fix identified bugs.
- **Feature Enhancements**: Gather user feedback for future improvements.
- **Performance Monitoring**: Regularly monitor system performance and optimize as needed.

## 3. Conclusion
The Hospital Management System aims to improve the efficiency of hospital operations through a user-friendly interface and robust functionality. This documentation serves as a guide for the development, deployment, and maintenance of the application, ensuring that all stakeholders have a clear understanding of the system's capabilities and requirements.