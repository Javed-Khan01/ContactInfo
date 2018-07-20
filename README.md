# ContactInfo
This is a sample contact information system for maintaining contacts.
There are three main projects added in solution
- ContactInfo.Web : is a mvc project which has UI and controllers
- ContactInfo.Service : is business layer
- ContactInfo.Data: data layer for accessing database using entity framework.

In ContactInfo.Web project there is App_Start folder have a Bootstrapper class which has dependencies registered using Autofac.

In ContactInfo.Service there are interfaces and its implementation.

In ContactInfo.Data have interfaces , implementations and generic repository for crud operation 

## Features
- List contacts 
- Sort contacts
- Add a contact 
- Edit contact
-Delete/Inactivate a contact

## Pre-requisites for running
The following nuget packages are required to run this project.
- .Net Framework version="4.5.2"
- EntityFramework version="6.1.3"
- Microsoft.AspNet.Mvc version="5.2.3" 
- Newtonsoft.Json version="6.0.4"
- Autofac version="4.8.1"
- Autofac.Mvc5 version="4.0.2"
- Sql server database (script are added in App_Data folder)

