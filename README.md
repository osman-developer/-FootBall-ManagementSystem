# -FootBall-ManagementSystem
 this is a Football Management System written in Angular8, Asp.Net Core WebAPI and SQL server as the database.
This application allows you to enter information about courts, reservations and people. 
It's an easy way to organize the reservations of the courts.
first of all, when you download the angular application, navigate inside the folder using the CLI and hit npm install ( ofcourse you should have nodejs installed with the npm,
also you should have angularCLI installed on your machine.) the npm install downloads all the packages that you need in order to run the application.
The API is written in C# and cut into N layers ( best practices ) in which I did a DALC (data access layer) that connects the app to the DataBase, the BLC(business logic layer)
it contains the logic ( ordering in asc. , remove courts in specific city etc..) and the WebAPI which is dummy, its role is to deliver data to the interface.
The database contains procedures and indexing. Here is the backup of the Database all what you have to do is to restore it. SQL instance 2019 if your version is lower than 2019 it will not work
contact me i can send you a generated script of the database, a script will work.
make sure to change the connection string to the DataBase from the WebApi/appsettings.json file.
For more information please feel free to contact me.
