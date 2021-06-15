# Animal Shelter API

#### _Animal Shelter API Database, 6/11/2021_

#### By _**Tiffany Greathead**_

## Description

An API that stores animal information for the pets available at an animal shelter. This project was created using C#.NET API using RESTful principles and utilizes full CRUD fucntionality.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to set up and run the project
- MySQL 8.0.19, following [these pinned installation instructions](https://web.archive.org/web/20210521163651/https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
- A web browser to view and interact with the project
- [Postman](https://www.postman.com)

### Installation

1. Clone the repository: `$ git clone https://github.com/TorchAblaze/AnimalShelter.Solution.git`
2. Navigate to the `Shelter` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `Shelter` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
    {
      "Logging": {
        "LogLevel": {
        "Default": "Warning",
        "System": "Information",
        "Microsoft": "Information"
        }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=shelter_api;uid=root;pwd=YourMySQLPasswordHere;"
      }
    }
   ```
5. To serve the local web app:
- Navigate to `Shelter.Solution/Shelter` in your command line
- Run the command: `dotnet ef database update`
- Finally, run the command `dotnet run` to run the project!
6. Visit the application via web browser at: `localhost:5000/`

## API Documentation
Use Postman to test POST, PUT, DELETE functionality for the API endpoints


## Endpoints
Base URL: `https://localhost:5000`

### HTTP Requests
- GET `/api/animals`: returns all animals in the database
- GET `/api/animals/{id}`: returns the animal with the matching ID, if applicable
- POST `/api/animals`: creates a new instance of the animal class
- PUT `/api/animals`: updates or edits an animal instance
- DELETE `/api/animals`: deletes an animal 

## Known Bugs

_No known bugs_ :bug:

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

- C#
- .NET 5 SDK
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- HTML5 with Razor syntax
- Postman

### License

<details>
<summary><a href="https://opensource.org/licenses/MIT"><strong>MIT</strong></a></summary>
<pre>
MIT License

Copyright (c) 2021 Tiffany Greathead

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

</pre>
</details>
