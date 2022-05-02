# Warning
 The application contains NSFW content!
 
 =**NSFW Endpoints are not working due to nekos.life having API issues.**

# NekoForms
 Application that generates images of nekos so you can look at them! Is also generates images of dogs and cats! All images are provided by **nekos.life** API! If you enjoy the application don't hesistate to star it :)
 
# Features
 As of the latest NekoForms release the program has:
 * Log window - Contains information about what's happening at the moment.
 * Close all windows - Obviously, closes all opened windows.
 * Image profile - Stores all images generated during the session as well as information about the image such as name, width, height and time of creation.
 * Image preview - Previews the currently selected image in the **Image profile**  
   
 **Toggleable options below:**
 * Cleanup on exit - Cleans NekoForms assets (downloaded images) on exit.
 * Top most - NekoForms will be shown above all other windows.
 * Duplicate exclude - Excludes all duplicated images. They are not being shown at all. Some endpoints have small variety of images leading to more and more duplicated images being generated, keep that in mind!
 * Dynamic size - Opens the window with the original image size.
 * Fixed size - Opens the window with size given by you.

# Running NekoForms on Linux
 In order to run NekoForm on Linux you will have to install Wine as well as the Mono Package for Wine.
* Install NekoForms and save it somewhere easily accessible (preferably Desktop or Downloads folder)
* Installing Wine  
    * Open terminal and type `sudo apt install wine`   
* Installing Mono Package:  
    * Open [this link](https://dl.winehq.org/wine/wine-mono/) and click on version **7.0.0/** (or newer one if available) and download `wine-mono-7.0.0-x86.msi` 
* After Mono Package installation:  
    * Open the terminal and type `wine64 uninstaller`  
    * Press **Install** in the GUI and locate the package that you just downloaded then press **OK** ([Example](https://media.discordapp.net/attachments/933253043028393994/934240984919834634/Image_Example.png)). That's it!
 * Running NekoForms:  
    * Open the terminal and type `wine NekoFormsName.exe`  

<h3 align="center">NekoForms now runs on Linux!</h3>

<p align="center">
  <img src="https://media.discordapp.net/attachments/933253043028393994/934227391759396864/unknown.png" width="750" height="350">
  <img src="https://media.discordapp.net/attachments/933253043028393994/934228314191699968/unknown.png" width="750" height="350">
</p>

<h3 align="center">Images location</h3>
<p align="center">You have to enable hidden files to see the <b>.wine</b> folder!</p>
<p align="center">There is no change in the images directory. They are still being stored in the <b>C:\</b> directory!</p>


<p align="center">
 <img src="https://media.discordapp.net/attachments/933253043028393994/934233070188494938/Save_Location.png">
</p>

# Menu
 <p align="center">
  <img src="https://media.discordapp.net/attachments/933253043028393994/933253093024489502/NekoForms_-_MainTab.png">
  <img src="https://media.discordapp.net/attachments/933253043028393994/933253093502627900/NekoForms_-_SettingsTab.png">
  <img src="https://media.discordapp.net/attachments/933253043028393994/933253093842378842/NekoForms_-_ImageProfileTab.png">
 </p>

# Video example
 https://user-images.githubusercontent.com/69941441/150081518-1d2f6fe1-5c23-437e-9b1c-d9ef4afb467c.mp4  
 
 https://user-images.githubusercontent.com/69941441/150081538-9283c272-ccce-4f82-8563-99e62f5b4e90.mp4

# How does it work
 It creates the necessary directories (One main directory and couple subdirectories) under **C:\\** drive so we can store the images locally on the computer. The local download is necessary so we can grab the image information such as width and size. Don't worry, there is an option to delete the assets upon exiting the application!  
   
 Every **X** seconds a new form is being created containing the neko image. Since some of the images were extremely big I've made an option for **dynamic size (The image original width and height)** and **fixed size (Width and height given by you)**. Lazy to close all of the forms manually? There's a button for that too, don't worry!  
   
 Deleting the assets is made easy since there is a option to do so upon exiting the application. Keep in mind that it might require elevation to do so!  

# Folders and classes
**Program.cs** - Responsible for creating all of the necessary directories upon lauching the application.  

* **Abstraction** folder
    * **ICreate.cs** - Interface for abstraction.

<br>

* **Menu** folder
    * **Menu.cs** - The **master** class. Everything happens there (e.g. Button behaviour). We can't without it.
 
<br>

* **Utils** folder
    * **EndPoints.cs** - Contains all endpoints (image types) that I use in the program.
    
    <br>

    * **DuplicateCheck.cs** - Contains method for checking whether or not the currently parsed image is duplicate. It checks for matching width, height and file size.

    <br>
    
    * **FormCreation.cs** - The second **master** class. It contains important methods for getting the image link, downloading the image, getting the image dimensions, creating the image form properties etc.
        
    <br>
    
    * **ImageProfile.cs** - Contains properties and constructor with all the necessarry information about the image. It is used for creating an object for the image that later we can use in the program.
        
    <br>
    
    * **LogsMessage.cs** - Contains methods that returns a specific message and adds it to the log windows.
        
    <br>
    
    * **LogsWindow.cs** - Contains methods for working with the log window.

# NuGet packages
 **RealTaiizor** - https://www.nuget.org/packages/ReaLTaiizor/ (Components for creating the GUI)  
 **Material Skin** - https://www.nuget.org/packages/MaterialSkin.Updated/ (Components for creating the GUI)  
 **Newtonsoft.Json** - https://www.nuget.org/packages/Newtonsoft.Json/ (Helping with object deserialization so we can get the URL of the image)
