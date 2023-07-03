#-- UC1:// Creating payrollService Database --

CREATE DATABASE payroll_service;
USE payroll_service;

#-- UC2: // Create table employee_payroll--
CREATE TABLE employee_payroll (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(20),
    Salary FLOAT,
    StartDate DATE
);

#-- UC3:// Inserting new records in the existing table--
INSERT INTO employee_payroll (name, Salary, StartDate)
VALUES ('priyanka', 35000, '2020-02-20'), sairam
       ('sai', 38000, '2020-03-07'), mahesh
       ('priya', 43000, '2022-05-16');; santhosh

#-- UC4: // Retrieving data from table --
SELECT * FROM employee_payroll;

#-- UC5: // View Data --
SELECT Salary FROM employee_payroll WHERE name = 'priyanka';
SELECT * FROM employee_payroll WHERE StartDate BETWEEN CAST('2020-02-20' AS DATE) AND GETDATE();

#-- UC6: // Alter and Update --
SELECT * FROM employee_payroll;
ALTER TABLE employee_payroll ADD Gender CHAR(1);
UPDATE employee_payroll SET Gender = 'F';

#-- UC7: // Basic operations--
SELECT * FROM employee_payroll;
SELECT SUM(Salary) AS TotalSalary FROM employee_payroll;
SELECT MAX(Salary) AS Maximum FROM employee_payroll;
SELECT MIN(Salary) AS Minimum FROM employee_payroll;
SELECT AVG(Salary) AS AverageSalary FROM employee_payroll;
SELECT COUNT(Salary) AS NumOfEmployees FROM employee_payroll;
SELECT COUNT(Salary) AS NumberOfEmployee, Gender FROM employee_payroll GROUP BY Gender;

#-- UC8: // Ability to extend data to store information like employee phone, address, and department--
ALTER TABLE employee_payroll ADD Phone BIGINT;
SELECT * FROM employee_payroll;
ALTER TABLE employee_payroll ADD Address VARCHAR(250);
ALTER TABLE employee_payroll ADD Department VARCHAR(250);

#-- UC9:// Ability to extend employee payroll table to have basic pay, deductions, taxable pay, income tax, net pay --
ALTER TABLE employee_payroll ADD Deduction BIGINT, Taxable_Pay FLOAT, Income_Tax FLOAT, Net_Pay FLOAT;
SELECT * FROM employee_payroll;
