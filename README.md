# SPA-NetCore-React-RBAC
SPA with .net Core3.1, ReactJs and IdentityServer with Role Based claim access

## Project:

This project represents a sample that can be used for SPA projects using .net core 3.1 and ReactJs 16 with identityServer4 for authorization and authentication.

## Specifications:

* The project is using a local sql lite as the database source.
* A token based authentication.
* A Role based authorisation.

## How it works:

1. Registering identity service and adding RoleManager in ```startup.cs```.
2. Creating and adding roles to identity with ``CreateRoles`` Task in ```Startup.cs``` (Amin, Manager, Member).
3. Adding the role to the token via the class ```ProfileService.cs``` and then calling the task ```CreateRoles``` in configure method in ```startup.cs```.
4. Scaffolding identity with codegenerator tool to generate the identityServer UI for customization, retriving list of roles from the databse to be selected by users to bind each user to a role in ```Register.cshtml.cs```.
5. Remove the registered services in ```IdentityHostingStartup.cs``` as it they are duplicated and the required services have been already registered in ```startup.cs```.
6. Adding rendering conditions in ```NavMenu.js``` to restrict tabs based on role claims.




