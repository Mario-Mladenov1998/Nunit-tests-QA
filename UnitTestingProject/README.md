NUnit Tests – UtilityLibrary
📌 Overview

# This repository contains a C# utility library and a separate NUnit test project.

# The purpose of this project is to demonstrate:

# Writing structured unit tests

# Using [Test] and [TestCase]

# Covering boundary values and edge cases

# Separating business logic from test logic

# Working with .NET 8 and NUnit


UnitTestingProject/
│
├── UtilityLibrary/
│   ├── Calculate.cs
│   ├── Factorial.cs
│   ├── Grades.cs
│   ├── StringReverse.cs
│   ├── Triangle.cs
│   └── UtilityLibrary.csproj
│
└── UtilityLibrary.Tests/
    ├── CalculateTests.cs
    ├── FactorialTests.cs
    ├── GradesTests.cs
    ├── StringReverseTests.cs
    ├── TriangleTests.cs
    └── UtilityLibrary.Tests.csproj


    🧪 Covered Functionalities

✔ Basic arithmetic operations
✔ Factorial calculation (including negative input validation)
✔ Grade classification logic with boundary testing
✔ String reverse logic
✔ Triangle validation logic

🛠 Technologies Used

C#

.NET 8

NUnit

Visual Studio

🎯 Purpose

This project is part of my QA Automation learning path.
The focus is building strong fundamentals in unit testing and writing clean, maintainable test code.
