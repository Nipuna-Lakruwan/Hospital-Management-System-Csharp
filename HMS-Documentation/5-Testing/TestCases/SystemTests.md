# Documentation for Hospital Management System (HMS)

## 1. Introduction
The Hospital Management System (HMS) is a Windows application designed to streamline the management of hospital operations, including patient records, appointments, billing, and user management. This documentation outlines the phases of the Software Development Life Cycle (SDLC) followed during the development of the HMS.

## 2. SDLC Phases

### 2.1. Requirement Analysis
#### 2.1.1. Purpose
To gather and analyze the requirements of the hospital management system from stakeholders, including hospital staff, doctors, and administrative personnel.

#### 2.1.2. Requirements
- **Functional Requirements:**
  - User authentication and authorization.
  - Patient registration and management.
  - Appointment scheduling and management.
  - Billing and invoicing.
  - Reporting features for patient records and financials.
  
- **Non-Functional Requirements:**
  - Performance: The system should handle multiple users simultaneously.
  - Security: Sensitive patient data must be protected.
  - Usability: The interface should be user-friendly and intuitive.

### 2.2. Design
#### 2.2.1. Architectural Design
The HMS follows a layered architecture:
- **Presentation Layer:** User interface components (Windows Forms).
- **Business Logic Layer:** Contains the core functionality and business rules.
- **Data Access Layer:** Manages database interactions using MySQL.

#### 2.2.2. User Interface Design
- The application features a main dashboard for navigation.
- Forms for patient management, appointment scheduling, and billing.
- Use of controls like DataGridView for displaying records and ComboBox for selection.

### 2.3. Implementation
#### 2.3.1. Development Environment
- **Programming Language:** C#
- **Framework:** .NET 8.0
- **Database:** MySQL
- **IDE:** Microsoft Visual Studio

#### 2.3.2. Code Structure
- The project is organized into multiple classes and user controls, each responsible for specific functionalities:
  - `recsearch.cs`: Handles patient search functionalities.
  - `RecDash.cs`: Manages the dashboard for doctors.
  - `manageUsers.cs`: Manages user accounts and permissions.
  - `generatebills.cs`: Handles billing and invoicing processes.
  
### 2.4. Testing
#### 2.4.1. Testing Strategy
- **Unit Testing:** Individual components and methods are tested for expected behavior.
- **Integration Testing:** Ensures that different modules work together as intended.
- **User Acceptance Testing (UAT):** Conducted with end-users to validate the system against requirements.

#### 2.4.2. Test Cases
- Test cases are created for each functional requirement, including:
  - User login/logout functionality.
  - Patient registration and retrieval.
  - Appointment booking and cancellation.
  - Billing calculations and invoice generation.

### 2.5. Deployment
#### 2.5.1. Deployment Strategy
- The application is deployed on hospital servers with access provided to authorized personnel.
- Installation packages are created for easy deployment on client machines.

#### 2.5.2. User Training
- Training sessions are conducted for hospital staff to familiarize them with the system.
- User manuals and documentation are provided for reference.

### 2.6. Maintenance
#### 2.6.1. Maintenance Plan
- Regular updates and patches will be provided to fix bugs and improve functionality.
- User feedback will be collected for future enhancements.

#### 2.6.2. Support
- A support team will be available to assist users with any issues or questions regarding the system.

## 3. Conclusion
The Hospital Management System is designed to improve the efficiency of hospital operations through effective management of patient records, appointments, and billing. By following the SDLC phases, the project aims to deliver a robust and user-friendly application that meets the needs of its users. 

## 4. Appendices
### 4.1. Code Snippets
- Example of a user control for patient search:
```csharp
public partial class recsearch : UserControl
{
    public recsearch()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Logic for searching patients
    }
}
```

### 4.2. Database Schema
- Tables include:
  - `Patients`: Stores patient information.
  - `Appointments`: Manages appointment details.
  - `Users`: Contains user account information.

### 4.3. References
- MySQL Documentation
- .NET Framework Documentation
- Visual Studio Documentation

This documentation serves as a comprehensive guide for the development, deployment, and maintenance of the Hospital Management System, ensuring that all stakeholders are informed and aligned throughout the project lifecycle.