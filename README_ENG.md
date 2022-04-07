# :car: Car Rental Web Application :car:

## TLDR:
An ASP.NET Core Blazor Server car rental web application that allows both business and car fleet management.

## My motivation: 
This application was born as a final project for one of the subjects at a university.
It is an attempt to improve an existing system that I had the pleasure of using during my work as a car rental agent in one of the local car rental companies. As an employee, I had a chance to see all the strengths and weaknesses of the app used by the company, and I focused on addressing them the best I could.

## The purpose of this app:
Streamlining the flow of information and process automation to save the time of both customers and employees.

## Technologies used:
- ASP.NET Core Blazor Server
- ASP.NET Identity
- Entity Framework Core
- Swagger

## What did I learn?
- API creation and testing with Swagger.
- ASP.NET Identity for authorization and authentication, basics of User Claims.
- Basics of EF Core => creating custom Business Models, CRUD operations and defining Relationships between database tables.
- Basics of asynchronous tasks.
- Basics of unit testing.

## Features:
- 4 types of registered Users with different User Claims: 
  - Admin - can create new Employee accounts and add information to the Business Database.
  - Logistician - can create new confirmed Reservations and confirm ones added by the Customers.
  - Agent - can see the list of Tasks assigned to them.
  - Customer - can add new Reservations and modify their personal information.
- 2 databases: User Database, Business Database.
- Customized account creation:
  - Default account creation process has been modified to automatically add a User Claim for Customers to the User Database.
  - Employee creation has been moved to a separate method, accessible only via the admin panel. It too, adds a User Claim adequate to the position of Employee associated with the User account. 
  - User in the User Database and Employee/Customer in the Business Database is linked via a common GUID.
  - If necessary, the GUID of the currently signed-in user is taken from the HTTP Context. Then the necessary information related to this user is downloaded from the Business Database.

## TODO:
- [ ] Seed database with users
- [ ] Add instructions to README - how to run and use this app
- [ ] Beautify the README - add some screenshots, icons, etc.
