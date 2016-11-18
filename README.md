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

* Use this widget to enable local users to login from any page in application
* A link to open a 'Forgot my password' page

#Configuration

* Insert the widget in a page
* Configure the properties

#Properties

* #Display

* Username placeholder - Standard text to be displayed in username field
* Password placeholder - Standard text to be displayed in password field
* Username Label - Username label caption
* Password Label - Password label caption
* Login button caption - Text to be displayed on login button
* Empty username/password message - Feedback message shown when a user didn't provide all credentials
* Forgot password link text - Text to use in the Forgot password link

#Packages and frameworks

* Developed in Visual Studio 2015 Community Edition
* MVC 5, Entity Framework 6, .NET 4.5
* MS SQL v.11.0

#To see it in action:

* Install Visual Studio 2015 Community Edition
* Clone or retrieve this Github project into a preferred folder
* Locate and open the Login-Form solution in Visual Studio
* Re-seed the database: In app.config explorer 
 1. delete v.11.0 conection string and input local db (if no SQL exists)
* Open the app file Login 
* Build and run the project on a preferred web browser
* See .../LoginForm/Content/Test/... for additional test content

#Known issues

* The runtime returns no feedback about the existence of a username. 
* This is by design if no SQL is installed you must connect to local db for connection string to run the app. 
* <add name="Database1Entities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\mssqllocaldb;attachdbfilename=|DataDirectory|\Database1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

#Comments welcome to Calvin Secrest, clsecrest2@gmail.com
