# Student Management System using Dapper ORM, jQuery Datatables, and .NET MVC

## Overview
Welcome to the documentation for the Student Management System project. This project was developed during my internship as a learning experience to implement advanced technologies in a practical scenario. The system focuses on utilizing the Dapper ORM for seamless SQL server interactions, combined with jQuery Datatables for enhanced table functionality, within a .NET MVC web application environment.

## Project Scope
The Student Management System is designed to handle the basic CRUD operations (Create, Read, Update, Delete) for student records. The application allows the user to:
- __Add__ new students with their details.
- __View__ a list of all students using a paginated and searchable table.
- __Update__ existing student information.
- __Delete__ student records when necessary.

## Technologies Used
- __Dapper ORM__: Simplifies SQL interactions and database operations.
- __jQuery Datatables__: Enhances HTML tables with pagination, sorting, and searching capabilities.
- __.NET MVC__: Adopts a structured approach for building web applications.
- __Microsoft SQL Server__: Backend database management system.
- __jQuery__: JavaScript library for frontend interactivity.
- __HTML/CSS__: Responsible for page structure and styling.
- __Bootstrap 5__: The project utilizes the Bootstrap framework for responsive and visually appealing user interface elements.

## Structure
The project adheres to the MVC architectural pattern, with the following components:
- __Models__: Classes representing database tables.
  - __Student__ for student records.
- __Views__: User interface pages including:
  - __AddStudent.cshtml__ a form for adding new student information.
  - __UpdateStudent.cshtml__ a form for updating student details.
  - __ViewAllStudents.cshtml__ displays a paginated and searchable table of students.
- __Controllers__: Manages HTTP requests, interacts with the model, and renders views.
  - __StudentController__ handles student-related actions.
- __StudentRepo__: Encapsulates data access logic, handling CRUD operations with the database.

## Usage
- __Add Student__: Visit "Add Student," provide information, and submit the form to add a new student record.
- __Update Student__: Go to "Update Student," select a student, edit details, and save changes.
- __View Students__: Access "View All Students" for a paginated table with sorting and searching features.
- __Delete Student__: In the "View All Students" table, each row has a delete button for removing records.
