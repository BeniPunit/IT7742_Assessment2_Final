Customer System App and Bank App Tests
 
1. Overview

This project has two small parts that work together:

1.1 Customer System App (WinForms MVC)

This app helps manage customer information.

It follows the Model–View–Controller (MVC) pattern.

You can add, edit, delete, and view customer records.

1.2 Bank App (Account and Tests)

This part has account classes like Account, OmniAccount, and InvestmentAccount.

It also has unit tests that check deposits, withdrawals, interest, and errors.

The tests are written using MSTest in Visual Studio.

Both parts are connected to show how to design and test object-oriented programs in C#.

2. Requirements

Before running this project, make sure these tools are ready on your computer:

Windows 10 or higher

Visual Studio 2022 or later (Community Edition is fine)

.NET SDK 8.0 (comes with Visual Studio)

MSTest Framework (included with Visual Studio)

3. Setup and Build Steps
3.1. Download or Clone

3.2  Save the project folder on your computer and open in Visual Studio

3.3 Go to File > Open > Project/Solution & Select the file CustomerApp.sln.

3.4 
You will now see two projects inside Solution Explorer:

CustomerSystemApp

BankAppTests

Run the Application

In Solution Explorer, right-click CustomerSystemApp.

Choose Set as Startup Project.

Click the Start (green triangle) button on the top bar.

A form will open — you can add, edit, and delete customers.

3.5 Run the Tests

Open Test Explorer in Visual Studio.
Go to Test > Test Explorer 

Click Run All Tests.

The system will show all test names and results.

Green means passed.

Red means failed (you can double-click to see why).

4. Troubleshooting

If the build fails, click Build > Clean Solution, then Build > Rebuild Solution.

Make sure all .csproj files are inside the right folders (CustomerSystemApp and BankAppTests).

If tests don’t show, close and reopen Visual Studio once.
