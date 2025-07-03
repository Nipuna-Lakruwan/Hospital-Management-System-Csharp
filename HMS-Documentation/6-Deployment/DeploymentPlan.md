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
  - Streamline appointment scheduling.
  - Facilitate billing and payment processing.
  - Enhance user management for hospital staff.

### 2.2. Requirements Analysis

**Objective:** Gather and analyze requirements from stakeholders.

- **Functional Requirements:**
  - User authentication and authorization.
  - Patient registration and management.
  - Appointment scheduling and management.
  - Billing and invoice generation.
  - Reporting features for patient and appointment statistics.

- **Non-Functional Requirements:**
  - User-friendly interface.
  - Secure data handling and storage.
  - Performance efficiency for handling multiple users.

### 2.3. Design

**Objective:** Create the architecture and design of the system.

- **Architecture:**
  - The application follows a layered architecture, separating the presentation layer, business logic layer, and data access layer.

- **User Interface Design:**
  - The application features a Windows Forms interface with various user controls for different functionalities (e.g., patient management, appointment scheduling).

- **Database Design:**
  - A MySQL database is used to store patient records, appointments, billing information, and user data.

### 2.4. Implementation

**Objective:** Develop the application based on the design specifications.

- **Technologies Used:**
  - Programming Language: C#
  - Framework: .NET 8.0
  - Database: MySQL
  - UI Framework: Windows Forms

- **Key Components:**
  - **User Controls:**
    - `recsearch`: For searching patient records.
    - `RecDash`: Dashboard for displaying statistics.
    - `manageUsers`: For managing user accounts.
    - `generatebills`: For generating and printing bills.
    - `DocApp`: For managing doctor appointments.
    - `bookApp`: For booking appointments.
    - `appsearch`: For searching appointments.
    - `appDetails`: For viewing appointment details.
    - `addViewPatRec`: For viewing patient records.
    - `addViewAppo`: For viewing and managing appointments.
    - `addNewRec`: For adding new patient records.
    - `addNewDoc`: For adding new doctors.
    - `addDash`: For displaying dashboard statistics.

### 2.5. Testing

**Objective:** Validate the application against requirements.

- **Testing Strategies:**
  - Unit Testing: Individual components are tested for functionality.
  - Integration Testing: Ensures that different modules work together.
  - User Acceptance Testing (UAT): Conducted with stakeholders to validate the application meets their needs.

- **Test Cases:**
  - Verify user login functionality.
  - Validate patient registration and record retrieval.
  - Test appointment scheduling and cancellation.
  - Ensure billing calculations are accurate.

### 2.6. Deployment

**Objective:** Release the application to users.

- **Deployment Strategy:**
  - The application will be installed on hospital computers with necessary configurations.
  - User training sessions will be conducted to familiarize staff with the application.

### 2.7. Maintenance

**Objective:** Provide ongoing support and updates.

- **Maintenance Plan:**
  - Regular updates to fix bugs and improve functionality.
  - User feedback will be collected for future enhancements.
  - Technical support will be available for users experiencing issues.

## 3. Conclusion

The Hospital Management System aims to enhance the efficiency of hospital operations through a user-friendly application. By following the SDLC phases, the project ensures a structured approach to development, testing, and deployment, ultimately leading to a reliable and effective solution for hospital management. 

## 4. Appendices

### 4.1. References

- C# Programming Guide
- MySQL Documentation
- .NET Framework Documentation

### 4.2. Glossary

- **UI:** User Interface
- **UAT:** User Acceptance Testing
- **SDLC:** Software Development Life Cycle

---

This documentation provides a comprehensive overview of the Hospital Management System project, detailing each phase of the SDLC and ensuring clarity for stakeholders and developers alike.