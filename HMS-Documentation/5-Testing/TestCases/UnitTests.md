# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation outlines the phases of the Software Development Life Cycle (SDLC) followed during the development of the HMS.

## 2. SDLC Phases

### 2.1. Requirement Analysis
- **Objective**: Gather and analyze the requirements of the hospital management system.
- **Stakeholders**: Hospital administrators, doctors, nurses, and IT staff.
- **Requirements**:
  - User authentication and role management (admin, doctor, nurse).
  - Patient registration and management.
  - Appointment scheduling and management.
  - Billing and invoicing system.
  - Reporting features for patient records and financials.
  - User-friendly interface for ease of use.

### 2.2. System Design
- **Objective**: Design the architecture and user interface of the application.
- **Architecture**: 
  - The application follows a layered architecture with a clear separation of concerns:
    - **Presentation Layer**: User interface components (Windows Forms).
    - **Business Logic Layer**: Handles business rules and data processing.
    - **Data Access Layer**: Interacts with the database (MySQL).
- **User Interface Design**:
  - User-friendly forms for patient management, appointment scheduling, and billing.
  - Use of controls such as DataGridView, ComboBox, and TextBox for data entry and display.

### 2.3. Implementation
- **Objective**: Develop the application based on the design specifications.
- **Technologies Used**:
  - Programming Language: C#
  - Database: MySQL
  - Framework: .NET Framework (Windows Forms)
- **Key Components**:
  - **User Authentication**: LoginPage.cs handles user login and role validation.
  - **Patient Management**: recsearch.cs and manageUsers.cs manage patient records and user roles.
  - **Appointment Management**: appsearch.cs and DocApp.cs handle appointment scheduling and viewing.
  - **Billing**: generatebills.cs manages the billing process and printing invoices.

### 2.4. Testing
- **Objective**: Ensure the application is free of defects and meets the specified requirements.
- **Testing Strategies**:
  - Unit Testing: Individual components (e.g., methods in recsearch.cs) were tested for functionality.
  - Integration Testing: Ensured that different modules (e.g., user management and appointment scheduling) work together seamlessly.
  - User Acceptance Testing (UAT): Conducted with stakeholders to validate the application against requirements.
- **Test Cases**: Documented test cases for each functionality, including expected outcomes and actual results.

### 2.5. Deployment
- **Objective**: Deploy the application to the hospital environment.
- **Deployment Steps**:
  - Installation of the application on hospital computers.
  - Configuration of the MySQL database and connection strings.
  - Training sessions for users on how to navigate and use the application.
- **Deployment Environment**: Windows operating system with .NET Framework installed.

### 2.6. Maintenance
- **Objective**: Provide ongoing support and updates to the application.
- **Maintenance Activities**:
  - Bug fixes and performance enhancements based on user feedback.
  - Regular updates to accommodate changes in hospital policies or regulations.
  - Backup and recovery procedures for data integrity.

## 3. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations through effective management of patient records, appointments, and billing. By following the SDLC phases, the project was successfully developed, tested, and deployed, ensuring that it meets the needs of its users. Ongoing maintenance will ensure the system remains functional and relevant in the dynamic healthcare environment. 

## 4. Appendices
- **Appendix A**: User Manual
- **Appendix B**: Technical Documentation
- **Appendix C**: Test Case Documentation
- **Appendix D**: Change Log

This documentation serves as a comprehensive guide for understanding the development process and functionality of the Hospital Management System.