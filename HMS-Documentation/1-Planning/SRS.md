# Software Requirements Specification (SRS)
# Hospital Management System (HMS)

## 1. Introduction

### 1.1 Purpose
This Software Requirements Specification (SRS) document provides a detailed description of the Hospital Management System (HMS). It outlines the functional and non-functional requirements, constraints, and specifications necessary for the development and implementation of the system.

### 1.2 Scope
The Hospital Management System is designed to automate and streamline hospital operations, including patient management, appointment scheduling, doctor management, billing, and administrative tasks. The system aims to improve operational efficiency, enhance patient care, and facilitate better resource management within healthcare facilities.

### 1.3 Definitions, Acronyms, and Abbreviations
- **HMS**: Hospital Management System
- **UI**: User Interface
- **CRUD**: Create, Read, Update, Delete
- **NIC**: National Identity Card
- **UAT**: User Acceptance Testing

### 1.4 References
- Project Charter
- System Design Documents
- Database Schema

### 1.5 Overview
The remaining sections of this document provide a detailed description of the HMS functionalities, constraints, assumptions, and dependencies. Section 2 outlines a general description of the system, Section 3 details specific requirements, and subsequent sections cover interface requirements, performance requirements, and other constraints.

## 2. Overall Description

### 2.1 Product Perspective
The HMS is a standalone Windows application that interfaces with a MySQL database for data storage and retrieval. It operates within a hospital or healthcare facility's internal network environment and does not directly interact with external systems.

### 2.2 Product Functions
The primary functions of the HMS include:
- User authentication and authorization
- Patient registration and record management
- Appointment scheduling and management
- Doctor management and scheduling
- Medical record management
- Billing and payment processing
- Administrative functions (user management, reporting)

### 2.3 User Classes and Characteristics
The system accommodates three main user categories:

1. **Administrative Staff**:
   - System administrators with full access to all functions
   - Responsible for user management, system configuration, and reporting

2. **Reception Staff**:
   - Handle patient registration and appointment scheduling
   - Manage billing and payment collection
   - Access to limited patient data

3. **Medical Staff (Doctors)**:
   - Access to patient medical records and history
   - Manage appointments and consultations
   - Record diagnoses, prescriptions, and treatment plans

### 2.4 Operating Environment
- **Hardware**: Standard desktop/laptop computers
- **Operating System**: Windows 10/11
- **Framework**: .NET Framework 4.7 or higher
- **Database**: MySQL Server
- **Minimum Display Resolution**: 1366x768

### 2.5 Design and Implementation Constraints
- The system must be developed using C# and .NET Framework
- MySQL must be used for database management
- The application must run on Windows operating systems
- The system must comply with healthcare data security standards
- User interface must follow modern design principles and be accessible

### 2.6 User Documentation
The following user documentation will be provided:
- Installation and setup guide
- User manuals for each user type (admin, reception, doctor)
- Training materials and quick reference guides
- Database backup and recovery procedures

### 2.7 Assumptions and Dependencies
- A stable network connection is available within the healthcare facility
- Users have basic computer literacy
- MySQL database server is properly installed and configured
- The system operates within a secure environment with appropriate access controls

## 3. Specific Requirements

### 3.1 External Interface Requirements

#### 3.1.1 User Interfaces
1. **Login Screen**:
   - Username and password fields
   - Role-based access control

2. **Admin Dashboard**:
   - Statistical overview of system activities
   - Quick access to management functions
   - Calendar view

3. **Doctor Dashboard**:
   - Appointment schedule
   - Patient list
   - Medical record access

4. **Reception Dashboard**:
   - Patient registration
   - Appointment booking
   - Billing management

#### 3.1.2 Hardware Interfaces
- Compatible with standard input devices (keyboard, mouse)
- Support for standard printers for report generation and bill printing
- Compatible with barcode scanners for patient identification (optional)

#### 3.1.3 Software Interfaces
- MySQL Database (Version 8.0 or higher)
- .NET Framework 4.7 or higher
- Windows Operating System
- PDF generation capability for reports and bills

### 3.2 Functional Requirements

#### 3.2.1 User Authentication and Management

1. **User Login**
   - The system shall authenticate users based on username and password
   - The system shall enforce password complexity requirements
   - The system shall provide password reset functionality

2. **User Management**
   - Administrators shall be able to create new user accounts
   - The system shall support different user roles (admin, doctor, reception)
   - Administrators shall be able to modify user details and permissions
   - The system shall allow deactivation of user accounts

#### 3.2.2 Patient Management

1. **Patient Registration**
   - The system shall allow the creation of new patient records
   - Required patient information includes name, contact details, NIC, gender, and date of birth
   - The system shall generate a unique patient ID for each patient
   - The system shall validate patient information for completeness

2. **Patient Record Management**
   - The system shall allow searching for patients by name, ID, or NIC
   - Authorized users shall be able to view and update patient records
   - The system shall maintain a history of changes to patient records
   - The system shall store patient medical history

3. **Patient History**
   - The system shall maintain comprehensive patient medical history
   - Authorized users shall be able to view previous diagnoses, prescriptions, and treatments
   - The system shall allow filtering of medical history by date and type

#### 3.2.3 Appointment Management

1. **Appointment Scheduling**
   - The system shall allow booking appointments with specific doctors
   - The system shall prevent double-booking of doctors
   - The system shall record the purpose of the appointment
   - The system shall send appointment confirmations (if email/SMS integration is available)

2. **Appointment Viewing and Management**
   - The system shall display all upcoming appointments
   - Users shall be able to search appointments by date, doctor, or patient
   - The system shall allow rescheduling or cancellation of appointments
   - The system shall track appointment status (scheduled, completed, canceled)

#### 3.2.4 Doctor Management

1. **Doctor Registration**
   - Administrators shall be able to add new doctors to the system
   - The system shall record doctor specialization, contact information, and availability
   - Each doctor shall have a unique identification within the system

2. **Doctor Schedule Management**
   - The system shall maintain doctor availability schedules
   - The system shall prevent scheduling conflicts
   - Doctors shall be able to view their appointment schedule

#### 3.2.5 Diagnosis and Treatment

1. **Patient Consultation**
   - Doctors shall be able to record consultation notes
   - The system shall allow entry of diagnosis, prescription, and treatment plans
   - The system shall associate medical records with specific appointments

2. **Prescription Management**
   - Doctors shall be able to create and record prescriptions
   - The system shall store prescription history for each patient
   - The system shall allow printing of prescriptions

#### 3.2.6 Billing and Payment

1. **Bill Generation**
   - The system shall generate bills based on services provided
   - Bills shall include itemized charges (consultation, medications, procedures)
   - The system shall calculate total charges automatically

2. **Payment Processing**
   - The system shall record payment information
   - The system shall support multiple payment methods
   - The system shall generate receipts for payments
   - The system shall track payment status (pending, completed)

#### 3.2.7 Reporting

1. **Administrative Reports**
   - The system shall generate reports on patient statistics
   - The system shall provide revenue reports
   - The system shall support appointment analytics

2. **Medical Reports**
   - The system shall generate medical reports for patients
   - Reports shall be printable and exportable to PDF

### 3.3 Non-functional Requirements

#### 3.3.1 Performance Requirements
- The system shall support at least 50 concurrent users without performance degradation
- Database operations shall complete within 3 seconds
- The system shall handle a minimum of 10,000 patient records
- Search operations shall return results within 2 seconds

#### 3.3.2 Security Requirements
- All user passwords shall be stored in encrypted form
- User authentication shall be required for all system operations
- The system shall implement role-based access control
- The system shall maintain an audit trail of critical operations
- Patient data shall be protected according to healthcare privacy standards

#### 3.3.3 Usability Requirements
- The user interface shall be intuitive and require minimal training
- Error messages shall be clear and provide guidance for resolution
- The system shall provide contextual help where appropriate
- The interface shall be consistent across all modules

#### 3.3.4 Reliability Requirements
- The system shall have an uptime of at least 99.5%
- The system shall include data backup and recovery mechanisms
- The system shall validate all input data to prevent corruption

#### 3.3.5 Availability Requirements
- The system shall be available 24/7
- Scheduled maintenance shall be conducted during off-peak hours

#### 3.3.6 Scalability Requirements
- The system shall accommodate a growing number of users and patients
- The database shall be designed to efficiently handle increasing data volumes

## 4. System Features and Use Cases

### 4.1 User Authentication

#### 4.1.1 Description
Users must authenticate themselves before accessing the system.

#### 4.1.2 Use Case
1. User enters username and password
2. System validates credentials
3. System grants access based on user role
4. System redirects to appropriate dashboard

### 4.2 Patient Registration

#### 4.2.1 Description
Reception staff register new patients in the system.

#### 4.2.2 Use Case
1. Reception staff selects "Register New Patient"
2. System displays patient registration form
3. Staff enters patient details (name, contact, NIC, gender, DOB)
4. System validates the information
5. System creates a new patient record and generates unique ID
6. System confirms successful registration

### 4.3 Appointment Booking

#### 4.3.1 Description
Staff schedule appointments for patients with doctors.

#### 4.3.2 Use Case
1. Staff searches for and selects a patient
2. Staff selects "Book Appointment"
3. System displays available doctors and time slots
4. Staff selects doctor, date, and time
5. Staff enters appointment reason/notes
6. System checks for conflicts
7. System creates appointment and confirms booking

### 4.4 Doctor Consultation

#### 4.4.1 Description
Doctors review patient information and record consultation details.

#### 4.4.2 Use Case
1. Doctor logs in and views scheduled appointments
2. Doctor selects a patient appointment
3. System displays patient information and medical history
4. Doctor enters diagnosis, prescription, and treatment notes
5. Doctor sets consultation charges
6. System saves the medical record
7. System updates appointment status to "Completed"

### 4.5 Billing Process

#### 4.5.1 Description
Staff generate and process bills for services rendered.

#### 4.5.2 Use Case
1. Staff selects a completed appointment
2. Staff selects "Generate Bill"
3. System calculates charges based on services provided
4. Staff confirms bill details
5. System generates printable bill
6. Staff records payment information
7. System updates payment status

## 5. Data Management

### 5.1 Data Entities
1. **Users**: Admin, Doctor, Reception staff
2. **Patients**: Personal and contact information
3. **Appointments**: Scheduling information
4. **Medical Records**: Diagnoses, treatments, and prescriptions
5. **Bills**: Payment information

### 5.2 Data Relationships
- Users manage Patients and Appointments
- Patients have multiple Appointments and Medical Records
- Appointments are linked to specific Doctors
- Medical Records are associated with Appointments
- Bills are generated from Appointments and Medical Records

### 5.3 Data Integrity
- Referential integrity must be maintained across all related entities
- Data validation must be performed at both application and database levels
- Audit trails must track changes to critical data

## 6. System Quality Attributes

### 6.1 Usability
- Consistent UI design across all modules
- Intuitive navigation and workflow
- Clear error messages and feedback
- Context-sensitive help

### 6.2 Reliability
- Automatic data backup
- Error handling and recovery procedures
- Input validation to prevent data corruption

### 6.3 Performance
- Quick response times for common operations
- Efficient database queries
- Optimized resource usage

### 6.4 Security
- Role-based access control
- Encrypted storage of sensitive data
- Audit trails for critical operations
- Session management and timeout

### 6.5 Maintainability
- Modular design for easier updates
- Comprehensive documentation
- Consistent coding standards
- Separation of concerns (UI, business logic, data access)

## 7. Implementation Constraints

### 7.1 Development Environment
- Microsoft Visual Studio 2022
- .NET Framework 4.7 or higher
- MySQL Database Server
- Git for version control

### 7.2 Deployment Environment
- Windows 10/11 operating system
- MySQL Server installed and configured
- Minimum 8GB RAM
- 100GB storage for database growth

## 8. Appendices

### 8.1 Database Schema
The database will include tables for:
- users
- patients
- doctors
- appointments
- diagnosis
- receptionists
- bills

### 8.2 User Interface Mockups
Separate documentation includes mockups for:
- Login screen
- Admin dashboard
- Doctor dashboard
- Reception dashboard
- Patient registration form
- Appointment booking interface
- Billing screen

### 8.3 Glossary
- **Patient**: An individual receiving medical care
- **Appointment**: A scheduled meeting between a patient and doctor
- **Diagnosis**: Identification of a medical condition
- **Prescription**: Medicine or treatment ordered by a doctor
- **Bill**: Document showing charges for medical services

## 9. Approval

This Software Requirements Specification document requires approval from:
- Project Manager
- Lead Developer
- Client Representative
- Quality Assurance Lead

---

Document Version: 1.0
Last Updated: [Current Date]
