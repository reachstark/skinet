# skinet
a course project built using Angular, ASP.NET, SQL server.

## Description
Skinet is an e-commerce website, selling ski equipment.

## Requirement
1. VS Code (is preffered)
2. dotnet SDK 8.0+
3. Postman
4. Docker Desktop

## How to run the project
-------------------------------------------------------------------------------------------
In the terminal at the root of the project, type the following:

```cd API```

then you can run the following command:

```dotnet watch```

-------------------------------------------------------------------------------------------

[NOTE] If Docker is not initialized, open the terminal at the root of the project and run:

```docker compose up -d```

Expected result:

```Network skinet_default  Created
   Container skinet-sql-1  Started
```

[NOTE] If running the above command results in an error, run the following commands (as Admin):

```net stop winnat```
```net start winnat```

-------------------------------------------------------------------------------------------