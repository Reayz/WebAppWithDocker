
# Steps to deploy a docker image on the Render website

1. Add Dockerfile to your web application.
2. Move/copy the Dockerfile to the one directory above from the .csproj file.
3. Build a docker image with the following command: <br>
``` docker build -t webapp:v2.0 . ``` <br>
-t for tag and give an image name <br>
webapp the given image name <br>
:v2.0 the given tag name(default will be latest) <br>
. means run the command on the current directory <br>

5. We can check the docker image with "docker images" command. 
6. We can run the image from the desktop docker specifying a port number or we can run the following command to run a docker image: <br>
``` docker run -it --rm -p 3000:80 --name webappcont webapp:v2.0 ``` <br>
-it (optional) stands for "interactive" and "tty" (terminal). It allows you to interact with the container's shell. <br>
--rm (optional) This flag removes the container automatically once it exits. <br>
-p 3000:80 This flag maps port 3000 on your local machine to port 80 on the container. <br>
--name (optional) gives a container name <br>
then the image name, which we want to run. <br>
then the app can be found on http://localhost:3000/ <br>

8. To upload any image into the docker hub, login to https://hub.docker.com/
9. Generate Personal Access Token(PAT) from My Account > Security
10. Run the following command to login (then give the PAT)
```
docker login -u reayz77
***PAT***
```

9. To upload an image first tag an existing image with the following command: <br>
``` docker tag webapp:v2.0 reayz77/webapp:v2.0 ``` <br>
first tag the existing image <br>
second tag is the new tag name including the user account  

10. Then run the following command to upload the image into docker hub <br>
``` docker push reayz77/webapp:v2.0 ```

11. We can run the folllowing command to get an image from the docker hub <br>
``` docker pull reayz77/webapp:v2.0 ```

12. The URL for the uploaded image will be **docker.io/reayz77/webapp:v2.0**

13. In Render.com select Create a new Web Service.
14. Then give the image url (eg. **docker.io/reayz77/webapp:v2.0**).
15. Then we can give any environment variable like a connection string.  
