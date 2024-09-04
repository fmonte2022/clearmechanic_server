# ClearMechanic - Challenge - Server
This document will detail the steps for installing the server.

#### Content

- [Docker Installation](#docker-instalation)
- [Creating the server docker image](#creating-the-server-docker-image)
- [Update connection strings](#update-connection-strings)
- [Creating the Database](#creating-the-database)
- [Installation completion](#installation_completion)
  
<br>

## [Docker Installation][toc]

In case the Docker engine is not installed, it must be installed using the following link: https://docs.docker.com/engine/install/

<br>

## [Creating the server docker image][toc]

### Step 1 - Creating the MA SQL docker image

From the terminal, run the following command:
```
docker pull mcr.microsoft.com/azure-sql-edge
```
<b>Official container images for Microsoft Azure SQL Edge for docker engine</b>

### Step 2 - Creating the Docker container

From the terminal, run the following command in order to create the docker container:
```
docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=[reallyStrongPwd123]" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge
```

## [Update connection strings][toc]

If you change the password used in the <b>Step 2</b> above should be changed the password on the ConnectionStrings of the API. For this open the Solution and then go the <b>appsettings.json</b> file.

```
 "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=ClearMechanicMovies;Trusted_Connection=false;User Id=sa;Password=<b>[reallyStrongPwd123]</b>;Persist Security Info=False;Encrypt=False"
 }
```

## [Creating the Database][toc]

From the terminal of the IDE (Vs) run the following command: 
```
 dotnet ef database update
```

<b>Note:</b> With this command should be created the database and executed the inserts by default.

<br>

## [Installation completion][toc]

Once the table is created run the API from the IDE </br>

<img width="1285" alt="Captura de pantalla 2024-09-04 a las 10 14 21" src="https://github.com/user-attachments/assets/e1e97fa4-0fe8-45e0-9497-468c660ca295">


[toc]: #content "Go to table of contents"
