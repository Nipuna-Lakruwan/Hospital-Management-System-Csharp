# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation follows the Software Development Life Cycle (SDLC) phases, providing a comprehensive overview of the project.

## 2. SDLC Phases

### 2.1. Planning
- **Objective**: To identify the need for a hospital management system to improve efficiency and patient care.
- **Stakeholders**: Hospital administrators, medical staff, IT department, and patients.
- **Scope**: The system will manage patient records, appointments, billing, and user roles (admin, doctor, receptionist).
- **Feasibility Study**: Conducted to assess technical, operational, and economic feasibility.

### 2.2. Requirements Gathering
- **Functional Requirements**:
  - User authentication and role management.
  - Patient registration and record management.
  - Appointment scheduling and management.
  - Billing and invoice generation.
  - Reporting features for patient statistics and financials.
  
- **Non-Functional Requirements**:
  - Usability: The application should be user-friendly.
  - Performance: The system should handle multiple users simultaneously.
  - Security: Sensitive patient data must be protected.

### 2.3. Design
- **Architecture**: The application follows a layered architecture with a clear separation of concerns.
- **User Interface Design**: 
  - Forms for user login, patient registration, appointment scheduling, and billing.
  - Use of panels and controls for a clean and intuitive layout.
  
- **Database Design**:
  - **Entities**: Patients, Appointments, Users, Billing.
  - **Relationships**: 
    - One-to-many relationship between Patients and Appointments.
    - One-to-many relationship between Users and Appointments.

### 2.4. Implementation
- **Technology Stack**:
  - Programming Language: C#
  - Database: MySQL
  - Framework: .NET Framework (Windows Forms)
  
- **Code Structure**:
  - Organized into different classes and user controls for modularity.
  - Key classes include:
    - `recsearch`: Handles patient search functionality.
    - `RecDash`: Dashboard for doctors.
    - `manageUsers`: User management interface.
    - `loginPage`: User authentication.
    - `generatebills`: Bill generation and printing.

### 2.5. Testing
- **Testing Strategy**:
  - Unit Testing: Individual components will be tested for functionality.
  - Integration Testing: Ensure that different modules work together seamlessly.
  - User Acceptance Testing (UAT): Conducted with stakeholders to validate the system against requirements.

- **Test Cases**:
  - Verify user login functionality.
  - Validate patient registration and record retrieval.
  - Test appointment scheduling and conflict resolution.
  - Check billing calculations and invoice generation.

### 2.6. Deployment
- **Deployment Strategy**:
  - The application will be deployed on hospital servers.
  - Installation instructions will be provided for IT staff.
  
- **User Training**:
  - Training sessions will be conducted for hospital staff to familiarize them with the system.

### 2.7. Maintenance
- **Support Plan**:
  - Ongoing support will be provided for bug fixes and updates.
  - Regular maintenance checks to ensure system performance and security.

- **Future Enhancements**:
  - Integration with external systems (e.g., insurance providers).
  - Mobile application development for patient access.

## 3. Conclusion
The Hospital Management System aims to enhance operational efficiency and improve patient care through a comprehensive management solution. This documentation outlines the SDLC phases, ensuring a structured approach to development and implementation. 

## 4. Appendices
- **Appendix A**: User Interface Mockups
- **Appendix B**: Database Schema Diagrams
- **Appendix C**: Test Case Documentation

---

This documentation serves as a guide for the development and maintenance of the Hospital Management System, ensuring all stakeholders are aligned with the project's objectives and requirements.