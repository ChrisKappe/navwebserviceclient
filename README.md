# navwebserviceclient
Dynamic NAV Web Service Client using dotnet core.
The example calls a NAV Codeunit 50079 exposed as a web service that runs a report and saves it as a PDF on the Server.
To create the web service:
1. Import the file COD50079.txt.
2. Publish the CodeUnit as a web service using the WebServices page in the NAV Client or using PowerShell.

To generate a service reference:
1. Download the WSDL from the NAV Web Service endpoint.
2. Run the command `dotnet svcutil Service.wsdl --namespace "*,NAVWS.Services"`

To run the app you need to provide the NavUserName credentials on the command line. 

