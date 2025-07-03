# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation outlines the phases of the Software Development Life Cycle (SDLC) followed during the development of the HMS.

## 2. SDLC Phases

### 2.1. Requirement Analysis
- **Objective**: Gather and analyze the requirements of the hospital management system.
- **Stakeholders**: Hospital administrators, doctors, nurses, and IT staff.
- **Requirements**:
  - Patient registration and management.
  - Appointment scheduling and management.
  - Billing and invoicing functionalities.
  - User management for hospital staff.
  - Reporting features for patient and appointment statistics.

### 2.2. System Design
- **Objective**: Design the architecture of the application based on the requirements gathered.
- **Design Components**:
  - **User Interface**: Windows Forms for user interaction.
  - **Database**: MySQL for data storage.
  - **Architecture**: Layered architecture with separation of concerns (UI, Business Logic, Data Access).
- **Key Classes**:
  - `recsearch`: For searching patient records.
  - `RecDash`: Dashboard for displaying statistics.
  - `manageUsers`: For managing user accounts.
  - `loginPage`: User authentication interface.
  - `generatebills`: For generating patient bills.

### 2.3. Implementation
- **Objective**: Develop the application based on the design specifications.
- **Technologies Used**:
  - C# as the programming language.
  - Windows Forms for the graphical user interface.
  - MySQL for the database management system.
- **Key Features Implemented**:
  - User authentication and role management.
  - Patient record management (CRUD operations).
  - Appointment scheduling and management.
  - Billing system for generating invoices.
  - Reporting features for tracking appointments and income.

### 2.4. Testing
- **Objective**: Ensure the application is free of defects and meets the specified requirements.
- **Testing Strategies**:
  - **Unit Testing**: Testing individual components for expected functionality.
  - **Integration Testing**: Testing the interaction between different modules.
  - **System Testing**: Testing the complete system for compliance with requirements.
  - **User Acceptance Testing (UAT)**: Conducted with stakeholders to validate the system meets their needs.
- **Tools Used**: Manual testing and automated testing frameworks (if applicable).

### 2.5. Deployment
- **Objective**: Deploy the application to the production environment.
- **Deployment Steps**:
  - Prepare the production environment (install necessary software).
  - Deploy the application files to the server.
  - Configure the database connection and other settings.
  - Conduct a smoke test to ensure the application is functioning as expected.

### 2.6. Maintenance
- **Objective**: Provide ongoing support and updates to the application.
- **Maintenance Activities**:
  - Bug fixes and patches.
  - Performance monitoring and optimization.
  - User feedback collection for future enhancements.
  - Regular updates to the application to add new features or improve existing ones.

## 3. Conclusion
The Hospital Management System (HMS) is designed to improve the efficiency of hospital operations through effective management of patient records, appointments, and billing. By following the SDLC phases, the project ensures a structured approach to software development, leading to a reliable and user-friendly application. Future enhancements will be guided by user feedback and evolving hospital needs. 

## 4. Appendices
- **Appendix A**: User Manual
- **Appendix B**: Technical Documentation
- **Appendix C**: Database Schema
- **Appendix D**: Source Code Repository Links

---

This documentation serves as a comprehensive guide for stakeholders involved in the Hospital Management System project, providing clarity on the development process and the functionalities of the application.