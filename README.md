# ClearMechanic - Challenge - Server
This document will detail the steps for installing the server.

#### Content

- [Docker Installation](#docker-instalation)
- [Creating the server docker image](#creating-the-server-docker-image)
- [Creating the Docker container using the created image](#creating_the_docker_container_using_the_created_image)
- [Installation completion](#installation_completion)
  
<br>

## [Docker Installation][toc]

In case the Docker engine is not installed, it must be installed using the following link: https://docs.docker.com/engine/install/

<br>

## [Creating the server docker image][toc]

### Step 1 - By command line

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


## [Creating the Docker container using the created image][toc]

From the terminal run the command: 
```\
docker run -d -p [PORT]:3001 [IMAGE_NAME]
```
</br>
<b>Note:</b> As <b>PORT</b> you can use 3001 which is the default value, but if the port is occupied by another application you could change it.

<br>

## [Installation completion][toc]

Once the container is running you can validate from your browser that the URL: http://localhost:[PORT]/ is running correctly, where you should see the following resources: </br>

### `/movies`
###  `/actors`
###  `/genders`
###  `/users`

Where: 
* <b>Movies:</b> List of movies.
* <b>Actors:</b>  List of actors.
* <b>Genders:</b>  List of genders.
* <b>Users:</b> List of users.

<img width="1363" alt="Captura de pantalla 2024-09-02 a las 19 39 13" src="https://github.com/user-attachments/assets/0e768287-d407-4103-935c-d313d8eb0656">

[toc]: #content "Go to table of contents"
