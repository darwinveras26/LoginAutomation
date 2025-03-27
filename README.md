# Selenium C# Automated Login Tests

## Overview
This project contains automated UI tests for the login functionality of the **SauceDemo** website using **Selenium WebDriver** with **xUnit** in C#. The tests cover both **valid** and **invalid** login scenarios to ensure proper authentication behavior.

## Technologies Used
- **C#**
- **Selenium WebDriver**
- **xUnit** (for test execution)
- **Chrome, Firefox, Edge** (cross-browser testing)

## Test Cases
The following test cases are implemented:

1. **Invalid Login - Empty Credentials**
   - Attempts to log in with both username and password fields empty.
   - Asserts that an error message **"Username is required"** appears.

2. **Invalid Login - Empty Password**
   - Enters a valid username but leaves the password field empty.
   - Asserts that an error message **"Password is required"** appears.

3. **Valid Login - Correct Credentials**
   - Enters a valid username (`standard_user`) and valid password (`secret_sauce`).
   - Asserts that the user is successfully redirected to the home page and sees the title **"Swag Labs"**.

## Notes
- This test suite follows the **Page Object Model (POM)** to enhance maintainability.
- The `BaseTest.cs` class initializes the browser and provides setup/teardown methods.
- The tests run on **Chrome, Firefox, and Edge** for cross-browser compatibility.

## Author
🚀 Created by Darwin Vearstegui

