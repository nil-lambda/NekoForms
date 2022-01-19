# NekoForms
 Application that generates images of nekos so you can look at them! Is also generates images of dogs and cats! All images are provided by **nekos.life** API! If you enjoy the application don't hesistate to star it :)

# Warning
 The application contains NSFW content!

# Menu
 ![Main Tab](https://media.discordapp.net/attachments/933253043028393994/933253093024489502/NekoForms_-_MainTab.png)
 ![Settings Tab](https://media.discordapp.net/attachments/933253043028393994/933253093502627900/NekoForms_-_SettingsTab.png)
 ![Image Profile Tab](https://media.discordapp.net/attachments/933253043028393994/933253093842378842/NekoForms_-_ImageProfileTab.png)

# Video example
 https://user-images.githubusercontent.com/69941441/150081518-1d2f6fe1-5c23-437e-9b1c-d9ef4afb467c.mp4  
 
 https://user-images.githubusercontent.com/69941441/150081538-9283c272-ccce-4f82-8563-99e62f5b4e90.mp4

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
