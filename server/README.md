# ClearMechanic - Challenge
En este documento se detallará los pasos para la instalación del server.

#### Contenido

- [Instalación de Docker](#instalación-de-docker)
- [Creación de la imagen docker del Server](#creación-de-la-imagen-docker-del-server)
- [Creación de la imagen docker del Server](#creación-de-la-imagen-docker-del-server)
- [Creación del contenedor de Docker utilizando la imagen creada](#creación-del-contenedor-de-docker-utilizando-la-imagen-creada)
- [Finalización de instalación](#finalización-de-instalación)
  
<br>

## [Instalación de Docker][toc]

En el caso que no se tenga instalado el motor de Docker se debe instalar usando el siguiente link: https://docs.docker.com/engine/install/

<br>

## [Creación de la imagen docker del Server][toc]

### Opción 1 - Creación desde el IDE (VsCode) + Extensión Docker

Desde el IDE (VsCode) instalar la extensión oficial de Docker y luego ejecutar el <b>Build image</b> sobre el archivo <b>"Dockerfile"</b>. </br></br>
<b>Nota:</b> Indicar el nombre de imagen que deseen. Sugerencia de formato <b>[USER_GIT_HUB]/[NAME_SERVER]:latest</b>

### Opción 2 - Por linea de comando

Desde la terminal, ir a la carpeta del proyecto y ejecutar el siguiente comando:
```
docker build . -t [USER_GIT_HUB]/[NAME_SERVER]:latest
```

<br>

## [Creación del contenedor de Docker utilizando la imagen creada][toc]

Desde la terminal ejecutar el comando: 
```\
docker run -d -p [PORT]:3001 [IMAGE_NAME]
```
</br>
<b>Nota:</b> Como <b>PORT</b> pueden utilizar 3001 que es el valor por default, pero si el puerto se tiene ocupado por otra aplicación podrían cambiarlo.

<br>

## [Finalización de instalación][toc]

Una vez que el contenedor este corriendo se podrá validar desde su navegador que la URL: http://localhost:[PORT]/ se este ejecutando correctamente, donde deberá visualizar los siguientes recursos: </br>

### `/movies`
###  `/actors`
###  `/users`

Donde: 
* <b>Peliculas:</b> Listado de peliculas
* <b>Actores:</b>  Actores pertenecientes a las peliculas.
* <b>Usuarios:</b> Usuarios permitidos por la aplicación


![Captura de pantalla 2024-03-27 151648](https://github.com/fmonte2022/extendeal_server/assets/104769503/e71ae5e4-8677-4de7-bd48-bb6b11fba942)

[toc]: #contenido "Ir a la tabla de contenidos"
