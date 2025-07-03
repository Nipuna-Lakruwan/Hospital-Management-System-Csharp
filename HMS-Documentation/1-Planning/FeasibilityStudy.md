# Documentation for Hospital Management System (HMS)

## 1. Introduction

The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Planning

**Objective:** Define the scope and purpose of the project.

- **Project Name:** Hospital Management System (HMS)
- **Stakeholders:** Hospital administrators, doctors, nurses, and IT staff.
- **Goals:**
  - Improve patient record management.
  - Facilitate appointment scheduling.
  - Streamline billing processes.
  - Enhance user management for hospital staff.

### 2.2. Requirements Analysis

**Objective:** Gather and analyze requirements from stakeholders.

- **Functional Requirements:**
  - User authentication and authorization.
  - Patient registration and record management.
  - Appointment scheduling and management.
  - Billing and invoice generation.
  - Reporting features for hospital statistics.

- **Non-Functional Requirements:**
  - User-friendly interface.
  - High availability and reliability.
  - Data security and privacy compliance.
  - Performance optimization for quick data retrieval.

### 2.3. Design

**Objective:** Create a blueprint for the system architecture.

- **Architecture:**
  - Windows Forms application using C#.
  - MySQL database for data storage.
  - Layered architecture (Presentation Layer, Business Logic Layer, Data Access Layer).

- **User Interface Design:**
  - Main dashboard for navigation.
  - Forms for patient registration, appointment scheduling, and billing.
  - Data grids for displaying records.

- **Database Design:**
  - Tables for Users, Patients, Appointments, and Billing.
  - Relationships defined between tables for data integrity.

### 2.4. Implementation

**Objective:** Develop the application based on the design specifications.

- **Technologies Used:**
  - C# for application logic.
  - MySQL for database management.
  - Guna.UI2 for enhanced UI components.

- **Key Components:**
  - **User Control Classes:**
    - `recsearch`: For searching patient records.
    - `RecDash`: For displaying dashboard statistics.
    - `manageUsers`: For managing user accounts.
    - `generatebills`: For generating billing statements.
    - `DocApp`: For managing doctor appointments.
    - `bookApp`: For booking appointments.
    - `appsearch`: For searching appointments.
    - `appDetails`: For displaying appointment details.
    - `addNewRec`: For adding new patient records.
    - `addNewDoc`: For adding new doctor records.
    - `addDash`: For displaying dashboard metrics.

### 2.5. Testing

**Objective:** Validate the application against requirements.

- **Testing Strategies:**
  - Unit testing for individual components.
  - Integration testing for database interactions.
  - User acceptance testing (UAT) with stakeholders.

- **Test Cases:**
  - Verify user login functionality.
  - Validate patient registration and record retrieval.
  - Test appointment scheduling and conflict resolution.
  - Ensure billing calculations are accurate.

### 2.6. Deployment

**Objective:** Release the application to users.

- **Deployment Strategy:**
  - Installation package created for easy deployment.
  - User training sessions conducted for hospital staff.
  - Documentation provided for user guidance.

### 2.7. Maintenance

**Objective:** Ensure the application remains functional and up-to-date.

- **Maintenance Plan:**
  - Regular updates for bug fixes and feature enhancements.
  - User feedback collection for continuous improvement.
  - Scheduled backups of the database to prevent data loss.

## 3. Conclusion

The Hospital Management System (HMS) is designed to enhance the efficiency of hospital operations through a user-friendly interface and robust functionality. Following the SDLC phases ensures that the project is well-structured, meets stakeholder requirements, and is maintainable for future enhancements. 

## 4. Appendices

### 4.1. Glossary

- **SDLC:** Software Development Life Cycle
- **UAT:** User Acceptance Testing
- **UI:** User Interface

### 4.2. References

- C# Documentation: [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/)
- MySQL Documentation: [MySQL Docs](https://dev.mysql.com/doc/)
- Guna.UI2 Documentation: [Guna UI](https://www.guna.io/)

---

This documentation serves as a comprehensive guide for the development, deployment, and maintenance of the Hospital Management System, ensuring clarity and understanding for all stakeholders involved.