			MY PROJECT: BLUESKYWORK.
	How I have created the project
A- I have downloaded Visual Studio Community 2017 and installed it on my desktop.
	*Go to "Visual Studio microsoft.com"
	*Click on Download for Windows and on Community 2017
	*I got it downloaded and I have clicked on that to continue downloading
	* After downloading I got it installed.

B- I have integrated SpecFlow Extension with Visual Studio IDE
	For the extension, 
	*I click on Tools
	*Extension and Update
	*By default I am on Installed, I click on online( make sure you are online and have internet access)
	*on the search button, write SpecFlow it displays with a download button, if download button doesn't show up may be the SpecFlow is already extended to the IDE.
	*SpecFlow Extension for Visual Studio 2017 with a download button beside.
	*So, I clicked on download because I was extending it for the first time.
	*It has downloaded there is a message under the window saying that my changes will be scheduled meaning that is not yes effective.
	* I now close my visual studio and open it again.
	* A window popup asking me to modify my visual studio
	*Then I click on modify. (This step is done once, not for every project)
	*I open my visual studio again.
	* I checked my extension to see if it has been extended. Green thick is seeing beside.


		I- Now How I have created my Test Project: BUESKYWORK.

	I went on File -> New -> project.
	*New Project window opened, I clicked on Test(Test template) and I have selected Unit test project (.Net framework)
	* I have name the project "BLUESKYWORK" and Browse( Make sure that the directory for solution is ticked.)
	* I clicked ok, my solution is now created, and it is displayed in the Solution Explorer.
	* I delete the Unit test because I am not using it, so I have to clean my solution. To do so, 
	*I right click on my project in the solution explorer,
	*I click on Clean
	*I right click back on my project in the solution explorer
	* and I click on build the solution.

	A- I will now add NuGet Packages for the project.

	- I went on Tools >> NuGet Package Manager>> Manage NuGet packages for solution.
	- I browsed and started searching in the Search Box, the package to install.
	- I have added the following Packages for my Test:
	1.Nunit 
	2.Nunit.console
	3.Nunit.Runners
	4.Nunit3TestAdapter

	5. SpecFlow
	6.SpecFlow.Nunit

	7.Selenium.WebDriver
	8.Selenium Support
	9.Selenium.WebDriver.ChromDriver
	10.Selenium.Firefox.WebDriver
	11.Selenium.WebDriver.IEDriver

N.B At each installation, I confirm that the package has been installed by the green arrow down like an icon beside de package also i can check the output. Also make sure that we have only one UnitTestProvider, you will see it on the App Config.

	
	B- I will create Folder Structure

	1- Add Folder: Right click on the project name and,
	* Add new Folders (Features, StepDefinitions, PageObjects,Utilities)

At this point errors that I was always doing was to create my Folder at the solution level which brings me another element entirely such as "New Solution Folder"

what those folders are for:

-We are going to be creating our SpecFlow feature files and it will be stored in our Feature Folder.
-Once you create your PageObject for each of the page you are going to test, you will been storing them in the PageObject Folder and it will be different classes that you will create for each of the page that you are going to be inspecting
-After that, from my feature file I will be creating some steps and those steps will be going into the StepDefinitions
- The Utilities also call helper will be stored in the utilities folder.

	C - I will create my Feature File.
	*Right click on feature folder, 
	* Click on Add
	* Click on my new Item
Add New Item window opens
	* By default we are on Visual C# Items
	*Select SpecFlow Feature File
	*Name the Feature
	* Click on Add
	* The template is displayed in a Behaviour Development Driven 
 format (BDD) ( Given, When, Then) and I can write my scripts according to the feature. 

	D - From the scripts(Scenario) I generate my StepDefinitions 
		-right click on the scripts 
		-click on "Generate steps Definitions"
		-A window is displayed with steps that has any matching stepdefinitions already.
		-Untick the one you don't want to generate
		-set up the folder or file you want them stored in and
		-Click on "generate".  
N.B- A Test can have more than one scenario and each scenario will have a unique name.
N.B- If you want to add another steps on the steps Definitions already  created, what we need to do is to right click on that particular step newly written and click on "Go To Definition" a message will displayed asking you if you want to copy the step binding skeleton to the clipboard and you click on yes. On the StepDefinitons you paste what is copied.

	E - For the utilities, I create my Hooks that I will use for the project. I will now then:

	*Right click on Utilities Folder
	*Add new Item
	*Click on Hoos
	*and Add on.

	F - For the PageObject
	*Right click on add new item
	*Click on Class
	*Name your class and Add.

After Setting up my SpecFlow environment, my project is ready to be used.


	





















