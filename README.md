SafeVault Security Project
Overview

SafeVault is a secure application designed to demonstrate best practices in secure software development. The project focuses on protecting sensitive user data by implementing security mechanisms such as input validation, SQL injection prevention, authentication, authorization, and vulnerability testing.

This project was developed as part of a security-focused assignment to practice building secure applications using modern development tools and best practices.

Features

The SafeVault application includes several security-focused features:

Secure input validation

SQL injection prevention

Authentication and login verification

Role-Based Access Control (RBAC)

Cross-Site Scripting (XSS) protection

Security testing and vulnerability fixes

These features help ensure that sensitive data remains protected and that unauthorized access is prevented.

Technologies Used

C#

.NET / ASP.NET

SQL Database

GitHub

Microsoft Copilot

Microsoft Copilot was used during development to assist with generating secure code patterns and identifying potential vulnerabilities.

Security Implementations
Input Validation

All user inputs are validated before processing to prevent malicious data from entering the system. Validation ensures that only properly formatted data is accepted.

Example:

if(string.IsNullOrWhiteSpace(username))
{
    throw new ArgumentException("Username cannot be empty");
}
SQL Injection Prevention

Parameterized queries were used to prevent SQL injection attacks. This ensures that user input is treated as data rather than executable SQL code.

Example:

using (SqlCommand cmd = new SqlCommand(
"SELECT * FROM Users WHERE Username = @username", connection))
{
    cmd.Parameters.AddWithValue("@username", username);
}
Authentication

Users must log in with valid credentials before accessing the application.

Authentication verifies user identity and ensures that only registered users can access protected resources.

Authorization (RBAC)

Role-Based Access Control was implemented to restrict access based on user roles.

Roles implemented:

Admin

Manage users

Manage vault records

Full system access

User

Access personal data

Limited system permissions

This ensures that users only access resources appropriate to their role.

Cross-Site Scripting (XSS) Protection

User inputs displayed in the application are sanitized and encoded to prevent malicious scripts from executing in the browser.

Example:

HttpUtility.HtmlEncode(userInput);
Security Testing

Several tests were performed to verify the application's security mechanisms.

Test scenarios included:

SQL injection attempts in login forms

Invalid user input

Unauthorized access to restricted resources

XSS script injection attempts

The results confirmed that the implemented protections successfully prevented these attacks.

Vulnerabilities Identified and Fixed
Vulnerability	Fix Applied
SQL Injection	Replaced dynamic SQL with parameterized queries
Cross-Site Scripting (XSS)	Encoded and sanitized user inputs
Unauthorized Access	Implemented RBAC role checks
Weak Input Validation	Added strict validation rules

These improvements strengthened the security of the SafeVault application.

How Microsoft Copilot Helped

Microsoft Copilot assisted during development by:

Generating secure coding examples

Suggesting input validation logic

Identifying potential SQL injection vulnerabilities

Recommending authentication and RBAC implementation

Assisting with debugging security issues

Copilot significantly improved development efficiency and helped enforce secure coding practices.

How to Run the Project

Clone the repository

git clone https://github.com/yourusername/safevault-security-project

Open the project in Visual Studio

Build the project

Run the application

GitHub Repository

Project repository:

https://github.com/yourusername/safevault-security-project
Author

Student Security Project Submission
SafeVault Application
