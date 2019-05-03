		
		REPORT ON API AND PPOSTMAN, AND HOW TO IMPORT CODE 			ON C# (RESHARP) WITH SPECFLOW.

API stands for Application Programming Interface and is made up of a set of REST request.

REST stand for :* REpresentational
		* State
		* Transfert

Rest request is also made up of the following parts:
	- An HTTP verbs that describes what action should be taken. Those verbs are: GET, PUT, POST, PATCH, DELETE.
	- A Uniform Ressources Locator( URL) that define the location of the request.
	- HTTP HEADERS that provide information to the server about the request.
	- A REQUEST BODY that provides furtherdetails for the request(This can sometimes be emplty depending on the verb used in the request).

HTTP stand for: Hypertest Transfer Protocol.
		
			HTTP VERBS
	*GET Reads record from a database.
	*POST Create or Add a new record to a database
	*PUT Update/Replace a record with a new in a database
	*PATCH Update/Modify a record in a database with new information.
	*DELETE Delete/Removes a record from a database.


			HTTP HEADERS
	Information provided to the server are:
	
	*THE HOST will be the domain name or IP address and port number of the user making the request.
	*AUTHORIZATION will be the credential of the user making the request.
	*THE CONTENT-TYPE will be the format of the informationprovided in the body of the request.


N.B: The request body is used when making POST,PUT,or PATCH request. The body specifies exactly what information should be added to the database.
It is usually in Java Scrip Object Notation(JSON) or extensible Markup Language(XML).

Example of how a JSON request body might look like for doing a POST request that adds a customer to a database;
	{
		"firstName" : "Vian"
		"lastName" : "Smith"
		"emailAddress" : "VSmith@example.com"
	}

GET and DELETE doesn't have a body. The reason been for the body is when the user want to make and update of an information in the database.


	DIFFERENCE BETWEEN THE "REQUEST" AND THE "RESPONSE"

REQUEST is what you send out, and 
RESPONSE is what you get back.

The response to a REST request is the information that the server sends back after it has received and processed ther request. It will include : 

- HTTP headers that describes the response.

- A response code that describes the success or failure of the response. The most common response codes come in one of these categories:
		*200 levels responses indicates that the request was received. understood, and processed.
		*400 levels responses indicates that the request was received, but that there were an error from the client.
		*500 levels indicates that there was some sort of server error.
 
- A response body that includes requested or relevant information( this can be sometimes empty depending on the request.)

Example of API : https://www.example.com/customers/1


	HOW TO TEST API

API Testing is perform for the system which has a collection of API that ought to be tested.
API Testing requires and application to intereact with API. In order to test an API you will need to:
		* Use testing Tool to drive the API
		* Write your own code to ttest the API.
 There is different types of tools used to test API, for my report I will use POSTMAN.

POSTMAN is currently one of the popular tools used in API Testing.

			ABOUT POSTMAN
	There is 3 sections in POSTMAN: Header, Sidebar, Builder.

On the HEADER, you create:
	 your WORKSPACE(API Request)
		- Name your request
		- Description of the request
		- Create workspace.

	On NEW, you have your
		-Building Blocks where you can select your request, or your collection, or the environment to run your request.

The Workspace created appear On the SIDEBAR where you can continue to do some work. The collection also appear on the sidebar. When you click on collection a window displays.


On BUILDERlevel that is where the work is done.
At this level, you 
		- Set your HTTP request. For GET as an example, 
		- Enter the URL into the URL request field,
		- Click on send
		- On the body you have your answer.

The API example I mentioned above (https://www.example.com/customers/1) content:
	*URL = www.example.com
	*Endpoint = customers/1 which is the end of the URL.

The GET request here will be "I want to GET the FIRST record on the customers table"

In order to test the API, informations below needs to be provided by developers about the APIs under the Test:

- What are the endpoints?,
- What HTTP verbs can we use for those endpoints?
- Are any of the verbs limited by authorization?
- Which fiels are required in the requests?
- What response codes should I expect for a successful request?
- What response codes should I expect for an unsuccessful request?
- What sort of error messages will be returned in the body of an unsuccessful requests?.

As a tester, if yoourresponse include a body, there should be an ASSERTION on That. Your ASSERTION helps you to get the result and also know when he failled or passed.

After Performing the "HAPPY PATH",we also need to do "NEGATIF TEST".

		NEGATIF TEST CAN BE ON THE FORM OF:
	
	*Sending a request with the wrong HTTP verbs
	*Sending a request with the wrong endpoint
	*Sending a request with missing headers
	*Sending a request without a proper authorization
	*Requesting datafor a record that does not exist
	*Sending a request with a body that has missing required fields
	*Sending a request with a body that has invalid field values.

		
		TYPES OF BUGS EXPECTED WHILE TESTING API:

- Wrong Status codes
-API validations
-Components(modules) not interacting as expected(GET, PUT, DELETE)
-HTTP request are not working
-Delayed in API response time
-To verify when API doesn't return any response data
-Response data is not structured
-Difficulty in connecting and getting response from API
-Output response to be checked on the basis of provided input request
-Verification of the API whether it triggers some other event on request another API.
-Verification of the API whether it is updating any data stucture.



	HOW TO IMPORT CODE FROM POSTMAN ON C# (RESHARP) WITH SPECFLOW.

After 
	# Inputting your Endpoint and your parameter if there is any,
	# Provided the appropriate http verbs and 
	# Clicked on code, code snippets is generated.
	# Import that code using c# (Restsharp where the test will be performed) into the API Test class created in advance.
		* Create Feature Folder and name it API
		* From there add new item : APITest
		* Generate the StepDefinitions from the scripts written in a GIVEN, WHEN, THEN format.
	# To make it works install the nugets packages related : "Restharp".
	# Perform your Test.



















