# Login Automation with Selenium and .NET

## 📌 Project Overview
This project automates the login functionality of the **SauceDemo** website using **Selenium WebDriver** and **.NET**. It follows the Page Object Model (POM) pattern to separate test logic from page interactions.

## 🛠️ Technologies Used
- **C#**
- **.NET**
- **Selenium WebDriver**
- **xUnit** (for test execution)
- **WebDriverManager** (for managing browser drivers)

## 🚀 Setup Instructions
### 1️⃣ Prerequisites
Ensure you have the following installed:
- **.NET SDK** (latest version recommended)
- **Chrome Browser**
- **Visual Studio Code**

### 2️⃣ Clone the Repository
```sh
git clone https://github.com/darwinveras26/LoginAutomation.git
cd LoginAutomation
```

### 3️⃣ Install Dependencies
Run the following command to install required NuGet packages:
```sh
dotnet restore
```

### 4️⃣ Run the Tests
Execute tests using the .NET CLI:
```sh
dotnet test
```
Or run tests directly in Visual Studio’s Test Explorer.

## 🧪 Test Cases
| Test Case | Description |
|-----------|-------------|
| **InvalidLogin_WithEmptyCredentials** | Ensures login fails when both fields are empty |
| **InvalidLogin_WithEmptyPasswordCredential** | Ensures login fails when password is missing |
| **ValidLogin_WithValidCredentials** | Verifies successful login with correct credentials |

## 🔧 Troubleshooting
- **WebDriverManager issue?** Ensure `WebDriverManager` is installed correctly:
  ```sh
  dotnet add package WebDriverManager
  ```
- **ChromeDriver issue?** Update ChromeDriver manually if needed.

Happy Testing! 🚀

