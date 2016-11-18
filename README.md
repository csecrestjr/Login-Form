# Login-Form
ASP.NET MVC project 

#Synopsis

Login Form Application

This project demonstrates a simple login form application constructed in C#
I have created a database with 6 columns (usernameID, username, password, name, surname, email),
and then created Entity data model from that database (ADO.NET). 
It also has a register form where you can insert new users into database and a datagrid view on starting 
form (login) and on the content form, where you can see what is in the database. 
I have entered 3 users in the database. Completed for Code Louisville's Fall 2016 session

#Web site features

* Bullet list Use this widget to enable local users to login from any page in application
* Bullet list A link to open a 'Forgot my password' page

#Configuration

* Bullet list Insert the widget in a page
* Bullet list Configure the properties

#Properties

* Nested bullet #Display

* Bullet list Username placeholder - Standard text to be displayed in username field
* Bullet list Password placeholder - Standard text to be displayed in password field
* Bullet list Username Label - Username label caption
* Bullet list Password Label - Password label caption
* Bullet list Login button caption - Text to be displayed on login button
* Bullet list Empty username/password message - Feedback message shown when a user didn't provide all credentials
* Bullet list Forgot password link text - Text to use in the Forgot password link

#Packages and frameworks

* Bullet list Developed in Visual Studio 2015 Community Edition
* Bullet list MVC 5, Entity Framework 6, .NET 4.5
* Bullet list MS SQL v.11.0

#To see it in action:

* Bullet list Install Visual Studio 2015 Community Edition
* Bullet list Clone or retrieve this Github project into a preferred folder
* Bullet list Locate and open the Login-Form solution in Visual Studio
* Bullet list Re-seed the database: In app.config explorer 
 1. A nested numbered list delete v.11.0 conection string and input local db (if no SQL exists)
* Bullet list Build and run the project on a preferred web browser
* Bullet list See .../LoginForm/Content/Test/... for additional test content

Known issues

* Bullet list The runtime returns no feedback about the existence of a username. 
* Bullet list This is by design if no SQL is installed you must connect to local db for connection string to run the app. 
* Sub-nested bullet etc <add name="Database1Entities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\mssqllocaldb;attachdbfilename=|DataDirectory|\Database1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

#Comments welcome to Calvin Secrest, clsecrest2@gmail.com
