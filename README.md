# NekoForms
 Application that generates images of nekos so you can look at them! Is also generates images of dogs and cats! All images are provided by **nekos.life** API! If you enjoy the application don't hesistate to star it :)

# Warning
 The application contains NSFW content!

# Menu
 ![Main Tab](https://cdn.discordapp.com/attachments/916391368480415744/928431336233009203/unknown.png)
 ![Settings Tab](https://cdn.discordapp.com/attachments/916391368480415744/928431382483566632/unknown.png)

# Video example
 https://user-images.githubusercontent.com/69941441/148308479-fb75f636-43a2-4ddd-85c2-e4a3dd1cf653.mp4  
 
 https://user-images.githubusercontent.com/69941441/148308483-2b0ac54a-e878-453d-8fe5-4f1461501dd7.mp4

# How does it work
 It creates the necessary directories (One main directory and couple subdirectories) under **C:\\** drive so we can store the images locally on the computer. The local download is necessary so we can grab the image information such as width and size. Don't worry, there is an option to delete the assets upon exiting the application!  
   
 Every **X** seconds a new form is being created containing the neko image. Since some of the images were extremely big I've made an option for **dynamic size (The image original width and height)** and **fixed size (Width and height given by you)**. Lazy to close all of the forms manually? There's a button for that too, don't worry!  
   
 Deleting the assets is made easy since there is a option to do so upon exiting the application. Keep in mind that it might require elevation to do so!  

# Classes 
 **Program.cs** is responsible for creating all of the necessary directories upon lauching the application.  

 **FormCreation.cs** is the most important class which contains the method that handles the creation of the form (width, height, items, item placement, etc.) and one nested class **ImageInformation.cs** that contains some methods for grabbing the image information after it gets downloaded on your PC.  

 **EndPoints.cs** is a enum used to store all of the endpoints I am using in the application. It makes it way easier than declaring them as *string*.  

 **ICreate.cs** is a interface for abstraction.

# NuGet packages
 **RealTaiizor** - https://www.nuget.org/packages/ReaLTaiizor/ (Components for creating the GUI)  
 **Material Skin** - https://www.nuget.org/packages/MaterialSkin.Updated/ (Components for creating the GUI)  
 **Newtonsoft.Json** - https://www.nuget.org/packages/Newtonsoft.Json/ (Helping with object deserialization so we can get the URL of the image)
