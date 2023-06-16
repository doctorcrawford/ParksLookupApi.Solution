# Parks Lookup Api

#### An api providing endpoints to a database listing various parks.

#### By Kyle Crawford

## Technologies Used

* C#
* .NET
* SQL
* MySQL
* MySQL Workbench
* Entity Framework Core

## Description

An API that serves as database for various parks around the country. It utilizes token authentication to allow only users to access CRUD functionality. The API also returns error validation for all endpoints, as well as error messages for log in verification.

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

### Set Up and Use

#### Cloning

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ParksLookup".

#### AppSettings

1. Within the production directory "ParksLookup", create a new file called `appsettings.json`.
2. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. Also replace `YourSecret` with a random string of choice to be your JWT Secret.

```json
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=kyle_crawford;uid=[YourUserId];pwd=[YourPassword];"
  },
  "JWT": {
    "ValidAudience": "http://localhost:4200",
    "ValidIssuer": "http://localhost:5000",
    "Secret": "[YourSecret]"
  }
}
```
3. Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

#### Database
1. Navigate to ParksLookupAPI.Solution/ParksLookupAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParksLookupAPI.Solution/ParksLookupAPI`).
2. Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

#### Launch the API
1. Navigate to ParksLookupAPI.Solution/ParksLookupAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParksLookupApi.Solution/ParksLookup`).
2. Run the command `dotnet run` to have access to the API in Postman or browser.

## API Documentation
Explore the API endpoints in a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the ParksLookup API with Swagger, launch the project using `dotnet watch run` with the Terminal or Powershell, and input the following URL into your browser: `https://localhost:5001/swagger/index.html`

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/account/register`
* Add the following query to the request as raw data in the Body tab:
```
{
  "username": "user1",
  "email": "user1@example.com",
  "password": "String1!"
}
```
* Then, log in by creating another POST request using the URL: `http://localhost:5000/api/login`
* Add the following query to the request as raw data in the Body tab:
```
{
  "username": "user1",
  "password": "String1!"
}
```
* The token will be generated in the response. Copy and paste it as the Bearer Token paramenter in the Authorization tab.

..........................................................................................

### Endpoints
Base URL: `http://localhost:5000`

#### HTTP Request Structure
```
GET /api/parks
POST /api/parks
GET /api/parks/{id}
PUT /api/parks/{id}
DELETE /api/parks/{id}
```

#### Example Query
```
http://localhost:5000/api/park/3
```

#### Sample JSON Response
```
{
  "parkId": 3,
  "name": "Canyonlands",
  "type": "National",
  "state": "Utah",
  "featuredAnimal": "Desert Bighorn Sheep",
  "inceptionYear": 1964
}
```

#### Path Parameters
|   Parameter   |  Type  | Default | Required | Description                                                     |
|   :-------:   | :----: | :-----: | :------: | --------------------------------------------------------------- |
|     name      | string |  none   |  true   | Return matches by name.                                          |
|     type      | string |  none   |  true   | Return park matches with a specific type, ie. National, State... |
|     state     | string |  none   |  true   | Return park matches with a specific state.                       |
|featuredAnimal | string |  none   |  false  | Return park matches with a specific featred animal.              |
| inceptionYear |  int   |  none   |  true   | Return park matches with a specific year of inception.           |



------------------------------

## Known Bugs

* _Any known issues_
None

## License
[MIT](https://opensource.org/license/mit)

Copyright (c) 2023 Kyle Crawford