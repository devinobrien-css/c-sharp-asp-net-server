# c-sharp-asp-net-server

C# ASP.NET Server Example

## Table of Contents

- [OpenAPI](#open-api-specifications)
- [Dependencies](#dependencies)
- [Setup Instructions](#setup-instructions)
- [Testing](#testing)

## Open API Specifications

To view the endpoint specs for this server, please refer to the [OpenAPI yaml](openapi.yaml). To view them neatly,
copy and paste the content into the [Swagger IO editor](https://editor.swagger.io/)

## Dependencies

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine
- [Visual Studio Code](https://code.visualstudio.com/) or any other code editor of your choice

## Setup Instructions

### Microsoft SQL Server

1. Clone the `docker-sqlserver-sample` repository to your local machine:

    ```bash
    $ git clone https://github.com/devinobrien-css/docker-sqlserver-sample.git
    ...
    ```

2. Follow the instructions provided in that repository's README to launch the instance.

> Note: this repo is dependent on running a local MSSQL instance. An example can used by following the ReadMe [from this repo](https://github.com/devinobrien-css/docker-sqlserver-sample) as stated above.

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

## Testing

A [postman collection](postman-testing.json) has been included for convenient testing

> A fair example [can be found here](https://github.com/cornflourblue/dotnet-6-crud-api/tree/master)
