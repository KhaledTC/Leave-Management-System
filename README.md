1.	About: Simple management system to manage employees leaving process.
2.	How to use: 
    - for the first time you need to add a migration to create the AppDB database, you can do that by:
        1. in visual studio click view -> other windows -> package manager console
        2. then enter those two commands 
            - add-migration hello
            - update-database
        3. and you are done!
    - The system starts with admin user (Username: admin, Password: admin).
    - With admin, you can add/delete, or even change roles of users.
    - There are two roles for users, Employee and Manager.
    - Create employees and managers and try using the app, waiting for your feedback!
3.	Feature: Every department have employees and managers, for employees, they can only submit a leave request to the managers of their department to approve or reject, and for the managers, they can only see and manage the employees in their department.
4.	Requirements:
    - Latest version of [Visual Studio](https://visualstudio.microsoft.com/).
    - The lastest version of [.Net SDK](https://dotnet.microsoft.com/download).
6.	Technologies used: ASP.Net Core, signalR, AJAX, Razor, SQL, MVC Design pattern, HTML, Bootstrap, jQuery.

