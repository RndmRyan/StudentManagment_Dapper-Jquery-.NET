CREATE database SchoolManagment;
USE SchoolManagment;

CREATE TABLE Students (
	student_id INT PRIMARY KEY IDENTITY,
	firstName VARCHAR(25) NOT NULL,
	lastName VARCHAR(25) NOT NULL,
	dob	DATE NOT NULL,
	email VARCHAR(100) NOT NULL,
	phone VARCHAR (11) NOT NULL,
);

INSERT INTO Students (firstName, lastName, dob, email, phone) VALUES
    ('John', 'Doe', '2000-05-15', 'john.doe@uni.edu', '03012345601'),
    ('Jane', 'Smith', '1999-09-30', 'jane.smith@uni.edu', '03098765402'),
    ('Michael', 'Johnson', '2001-02-10', 'michael.johnson@uni.edu', '03055512303'),
    ('Emily', 'Brown', '1998-11-20', 'emily.brown@uni.edu', '03022298704'),
    ('William', 'Miller', '2002-07-05', 'william.miller@uni.edu', '03078955505'),
    ('Olivia', 'Davis', '2000-12-03', 'olivia.davis@uni.edu', '03045622206'),
    ('James', 'Martinez', '1999-04-25', 'james.martinez@uni.edu', '03032178907'),
    ('Sophia', 'Johnson', '2001-09-18', 'sophia.johnson@uni.edu', '03065445608'),
    ('Alexander', 'Smith', '2003-03-08', 'alexander.smith@uni.edu', '03098732109'),
    ('Ava', 'Garcia', '1998-08-12', 'ava.garcia@uni.edu', '03012365410');

SELECT * FROM Students;


-------------    CRUD OPERATIONS IN PROCEDURES
------CREATE
CREATE PROCEDURE InsertStudent
    (@firstName VARCHAR(25), @lastName VARCHAR(25), @dob DATE,
    @email VARCHAR(100), @phone VARCHAR(11))
AS
BEGIN
    INSERT INTO Students (firstName, lastName, dob, email, phone)
    VALUES (@firstName, @lastName, @dob, @email, @phone);
END;

-----READ
CREATE PROCEDURE GetStudent (@student_id INT)
AS
BEGIN
    SELECT * FROM Students WHERE student_id = @student_id;
END;

CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * FROM Students;
END;

------UPDATE
CREATE PROCEDURE UpdateStudent
    (@student_id INT, @firstName VARCHAR(25), @lastName VARCHAR(25),
    @dob DATE, @email VARCHAR(100), @phone VARCHAR(11))
AS
BEGIN
    UPDATE Students
    SET firstName = @firstName, lastName = @lastName,
        dob = @dob, email = @email, phone = @phone
    WHERE student_id = @student_id;
END;

-----DELETE
CREATE PROCEDURE DeleteStudent (@student_id INT)
AS
BEGIN
    DELETE FROM Students WHERE student_id = @student_id;
END;