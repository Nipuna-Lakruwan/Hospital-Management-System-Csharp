# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation outlines the phases of the Software Development Life Cycle (SDLC) followed during the development of the HMS.

## 2. SDLC Phases

### 2.1. Requirement Analysis
**Objective:** Gather and analyze the requirements of the system.

- **Stakeholders:** Hospital administrators, doctors, nurses, and administrative staff.
- **Functional Requirements:**
  - User authentication and authorization.
  - Patient registration and management.
  - Appointment scheduling and management.
  - Billing and invoicing functionalities.
  - Reporting features for patient records and appointments.
- **Non-Functional Requirements:**
  - Performance: The system should handle multiple users simultaneously.
  - Security: Sensitive patient data must be protected.
  - Usability: The interface should be user-friendly and intuitive.

### 2.2. System Design
**Objective:** Define the architecture and design of the system.

- **Architecture:** The application follows a layered architecture consisting of:
  - Presentation Layer: User interface components (Windows Forms).
  - Business Logic Layer: Handles the core functionalities and business rules.
  - Data Access Layer: Manages database interactions using MySQL.
- **User Interface Design:** 
  - User-friendly forms for patient management, appointment scheduling, and billing.
  - Use of controls such as DataGridView for displaying records, ComboBox for selections, and Buttons for actions.

### 2.3. Implementation
**Objective:** Develop the application based on the design specifications.

- **Technologies Used:**
  - Programming Language: C#
  - Database: MySQL
  - Framework: .NET Framework (Windows Forms)
- **Key Components:**
  - **User Controls:** 
    - `recsearch`: For searching patient records.
    - `RecDash`: Dashboard for displaying statistics.
    - `manageUsers`: For managing user accounts.
    - `generatebills`: For generating bills for patients.
    - `DocApp`: For managing doctor appointments.
  - **Database Interaction:** 
    - Utilizes MySQL.Data library for database operations.
    - Connection strings and queries are managed in a centralized manner.

### 2.4. Testing
**Objective:** Ensure the application meets the specified requirements and is free of defects.

- **Testing Strategies:**
  - Unit Testing: Individual components are tested for functionality.
  - Integration Testing: Ensures that different modules work together as expected.
  - User Acceptance Testing (UAT): Conducted with stakeholders to validate the system against requirements.
- **Test Cases:**
  - Verify user login functionality.
  - Validate patient registration and record retrieval.
  - Test appointment scheduling and billing processes.

### 2.5. Deployment
**Objective:** Release the application to the end-users.

- **Deployment Strategy:**
  - The application is packaged and installed on hospital computers.
  - User training sessions are conducted to familiarize staff with the system.
- **Installation Instructions:**
  - Ensure .NET Framework is installed on the target machine.
  - Run the installer and follow the prompts to complete the installation.

### 2.6. Maintenance
**Objective:** Provide ongoing support and updates for the application.

- **Maintenance Activities:**
  - Bug fixes and performance enhancements based on user feedback.
  - Regular updates to ensure compatibility with new operating systems and database versions.
  - User support through a helpdesk system.

## 3. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations through a user-friendly interface and robust functionality. Following the SDLC phases ensures that the application meets the needs of its users while maintaining high standards of quality and performance.

## 4. Appendices
- **Appendix A:** User Manual
- **Appendix B:** Technical Documentation
- **Appendix C:** Change Log

---

This documentation serves as a comprehensive guide for the Hospital Management System, detailing each phase of the SDLC and providing insights into the design and functionality of the application.