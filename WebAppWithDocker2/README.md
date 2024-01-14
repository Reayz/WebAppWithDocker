
Steps to deploy a docker image on render website

1. Add Dockerfile on your web application
2. Move/copy the Dockerfile to the one directory above from .csproj file
3. Build docker image with the following command 
docker build -t webapp:v2.0 .
-t for tag and give a image name
webapp the given image name
:v2.0 the given tag name(default will be latest)
. means run the command on the current directory

4. We can check the docker image with "docker images" command. 
5. We can run the image from the desktop docker specifying a port number or we can run the follwing command to run a docker image
docker run -it --rm -p 3000:80 --name webappcont webapp:v2.0
-it (optional) stands for "interactive" and "tty" (terminal). It allows you to interact with the container's shell.
--rm (optional) this flag removes the container automatically once it exits.
-p 3000:80 this flag maps port 3000 on your local machine to port 80 on the container. 
--name (optional) give a container name
then the image name, which I want to run.
then app can be found on http://localhost:3000/

6. For upload any image into docker hub, login into https://hub.docker.com/
7. Generate Personal Access Token(PAT) from My Account > Security
8. Run the follwing command to login (then give the PAT)
docker login -u reayz77
*******

9. For upload a image at first tag an existing image with following command
docker tag webapp:v2.0 reayz77/webapp:v2.0
- first tag the existing image 
- second tag is the new tag name including the user account  

10. Then run the following command to upload the image into docker hub
docker push reayz77/webapp:v2.0

11. We can run the folllowing command to get a image from the docker hub
docker pull reayz77/webapp:v2.0

12. The url for the uploaded image will be
docker.io/reayz77/webapp:v2.0


13. In Render.com select Create a new Web Service
14. Then give the image url (eg. docker.io/reayz77/webapp:v2.0)
15. Then we can give any environment variable like connection string.  
