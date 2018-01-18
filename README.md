C# Console Application:  
 ShopApp 18.01.2018

Solution include: ShopApp project and ShopApp_v2 project
===============================================================

License:
========
Copyright 2018 Olga Kozhevnikova (Mercantec: House of Technology) 
All rights reserved. This program and its use are subject to a license agreement 
and are also subject to Copyright, trademark, patent and\or other laws.


Contacts:
=========
Voice: +45 20302252
E-mail:nimfaolya@mail.ru
GitHub: https://github.com/OOPProjectExam


ShopApp project summary:
===================================================================================
Consist from: Program.cs, Interface:IPerson, Classes: Shop, Employee, Customer, Order.

- Choose ShopApp project in the Startup Projects filed and run it.

Application represents MODEL OF SHOP.

It starts with showing title of the Shop and invites user to choose option with entering an equvivalent number of it.
 1. Create Customer: (implement of methods announced in IPerson interface)
  a) Makes an object of class Customer, filles it with  values and display information on console.
  b) Calls through delegate creation of object of class Order and implements method AddItem, by
       asking a user to enter price of item. User should enter "-1" to stop add items to cart and get to see: Sum of order, Discount and TotalSum.
PS.:Price of item should be only integer or double or: warning message would be shown and user would be thrown out from method to the main menu.

 2.Create Employee: (similar to Customer) (implement of methods announced in IPerson interface)
  a) Makes an object of class Employee, filles it with  values and display information on console.
  b) Calls through delegate creation of object of class Order and implements method AddItem, by
       asking a user to enter price of item. User should enter "-1" to stop add items to cart and get to see: Sum of order, Discount and TotalSum.
PS.:Price of item should be only integer or double or: warning message would be shown and user would be thrown out from method to the main menu.
 
3.Show existed employees
 a) Creates an array of 5 employees and filles them with some data
 b) Sort them by Employee status (implementation IComparable interface )
 c)Display information about them on console.(by overridng ToString method)
 
 4.Show orders - this option are not implemented but represented in ShopApp_v2 as different project.

 5.Close Shop - closes the application.

ShopApp_v2 project summary: 
===================================================================================
  - Choose ShopApp_v2 project in the Startup Projects filed and run it.

Consists from: Program.cs, Class:Order

Starts with showing Shop Title and also invites user to make an choice from menu options.
Collection of objects List and one separate object of Class Order would be created.

1. Buy something
- with this option user is buying something for 5$(i've set this default price as example) - using method of Class Order to increment current sum with value of price.
- warning message is appears (message is a result om implementation delegate and lambda expression)

2. Delete something
- with this option user is deleting  some item from order for 5$(i've set this default price as example) - using method of Class Order to decrement current sum with value of price.
- warning message is appears (message is a result om implementation delegate and lambda expression)

3. Count Total Sum
- Set discount depending of customer type
- Counts Total sum  with discount

4. Show existed orders
-Represents status of current order
-Represents data collected in List of objects of Class Order

5. Close Shop

GENERAL USAGE NOTES
===================

Language: Microsoft Visual C# 2017.

REQUIREMENTS:
   - Administrator rights are required to install Visual Studio.
   - Microsoft Visual Studio 2017 Version 15.4.1.
   - Microsoft .NET Framework Version 4.7.02046 or higher version (Appropriate version will be installed during setup).
   
   - Download files from GitHub  GitHub: https://github.com/NimfaOlechka/SimpleCalculator.git (you can also copy code from there).
   
Supported Operation Systems:
   - Windows 10 version 1507 or higher(LTSB and S are not supported);
   - Windows Server 2016;
   - Windows 8.1.
   
Hardware:
- 1.8 GHz or faster processor. Dual-core or better recommended
- 2 GB of RAM; 4 GB of RAM recommended (2.5 GB minimum if running on a virtual machine)
- Hard disk space: up to 130 GB of available space, depending on features installed; typical installations require 20-50 GB of free space.
- Hard disk speed: to improve performance, install Windows and Visual Studio on a solid state drive (SSD).
- Video card that supports a minimum display resolution of 720p (1280 by 720); Visual Studio will work best at a resolution of WXGA (1366 by 768) or higher.

Additional Information:
=======================

- Visual Studio 2017 for MAC Product Family System Requirements:
For installing Visual Studio on MAC OS, please, visit original supplier web page:
https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-mac

Quick Usage Guide:
==================

1. Start Visual Studio 2017.
2. On the menu bar, choose File, New, Project.
3. Expand Installed, expand Templates, expand Visual C#, 
and then choose Console Application.
4. In the name box, specify a name for your project (fex.:ShopApp), and then choose the OK button
5. if Program.cs isn't open in the Code Editor, open the shortcut 
menu for Program.cs in Solution Explorer, and then choose View Code.
6. Download files ShopApp Program.cs from GitHub and open it with NotePad or any other text reductor.
7. Replace the contents of Program.cs of your new project with code from downloaded Program.cs
8. Choose the F5 key to run the project. You can also choose a Build Solution 
option in Build menubefore choosing Run for to be sure that you copied code without 
any mistakes A Command Prompt window appears and Program will start.