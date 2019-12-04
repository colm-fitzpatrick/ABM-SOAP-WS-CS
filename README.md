# ABM-SOAP-WS-CS
ABM Developer Technical Question 3. SOAP web service using C#.

# Requirements
* Windows
* Internet Information Services

# Deployment Instructions
Please follow the proceeding instructions to deploy the SOAP web service.

# Step 1
* Download this repository as ZIP and extract the contents.

# Step 2
* To run the web service we will need to use the Internet Information Services Windows feature.
* To enable this feature: search for "windows features" and select "Turn Windows features on and off".
![ScreenShot](ABM-SOAP-WS-CS/Data/soap-ws-cs-step1.png)
* Then navigate to Internet Information Services and select Web Management Tools and World Wide Web Services.
* Then navigate to World Wide Web Services/ Application Development Features and ensure ASP.NET 4.5 is selected, if not select it.
![ScreenShot](ABM-SOAP-WS-CS/Data/soap-ws-cs-step2.png)

# Step 3
* Open the Internet Information Services (IIS) Manager program.
* In the connections tab on the left side of screen, right click Default Web Site and select Add Application.
* For alias enter ABM-SOAP-WS-CS and application pool enter .NET v4.5.
* For the physical path browse to C:\inetpub\wwwroot, create a folder called ABM-SOAP-WS-CS and select it as the physical path.
* Click OK to add application.

# Step 4
* In the connections tab, right click the newly created ABM-SOAP-WS-CS application and select explore.
* Navigate to ABM-SOAP-WS-CS-master folder and copy and paste its contents into the ABM-SOAP-WS-CS folder in the wwwroot directory.

# Step 5
* Go to your internet browser and enter the URL http://localhost/ABM-SOAP-CS/WebService1.asmx


# Using the web service
* For ease of use I have included three XML files, one valid, one with an invalid command and one with an invalid site id. These can be found in the Data folder.
* To test the valid xml file, select the RunValid method in the web service. This should return 0.
* To test the invalid command xml file, select the RunInvalidCommand method. This should return -1.
* To test the invalid site id xml file, select the RunInvalidSiteID method. This should return -2.
