# ClearMechanic - Challenge
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

### Option 1 - Creation from the IDE (VsCode) + Extension Docker

From the IDE (VsCode) install the official Docker extension and then run the <b>Build image</b> about the file <b>"Dockerfile"</b>. </br></br>
<b>Note:</b> Please indicate the name of the image you want. Format suggestion <b>[USER_GIT_HUB]/[NAME_SERVER]:latest</b>

### Option 2 - By command line

From the terminal, go to the project folder and run the following command:
```
docker build . -t [USER_GIT_HUB]/[NAME_SERVER]:latest
```

<br>

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


![Captura de pantalla 2024-03-27 151648](https://github.com/fmonte2022/extendeal_server/assets/104769503/e71ae5e4-8677-4de7-bd48-bb6b11fba942)

[toc]: #content "Go to table of contents"
