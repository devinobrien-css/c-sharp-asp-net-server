# c-sharp-asp-net-server

C# ASP.NET Server Example

## Table of Contents

- [Dependencies](#dependencies)
- [Setup Instructions](#setup-instructions)

## Dependencies

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine
- [Visual Studio Code](https://code.visualstudio.com/) or any other code editor of your choice

## Setup Instructions

### Configure User Secrets

- Once the repository is cloned, navigate to the root directory of the project in the terminal.

- Run the following command to set up user secrets:

```bash
    dotnet user-secrets set "ConnectionStrings:SqlConnection" "Server=localhost;Database=sqlserver;User Id=sa;Password=YourStrong@Passw0rd;"
```

> Note: this secret is dependent on running a local MSSQL instance. An example can used by following the ReadMe [from this repo](https://github.com/devinobrien-css/docker-sqlserver-sample)

### Build and Run the Project

1. Open the project in Visual Studio Code.

2. Restore NuGet packages and build the server by running the following:

```bash
    dotnet build
```

3. Once the project is built successfully, run the following command to start the application:

```bash
    dotnet run
```

Congrats! The project should now be accessible through [localhost:5077](http://localhost:5077). Open in browser to verify the healthcheck endpoint is hit!
