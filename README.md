# Connect and Consume services - Azure API Management


## API Management Basics

### Create the API

- create a web app in a resource location

- create an *API Management Service* in a different location than the web app
<img src="/pictures/api_management.png" title="api management"  width="500">

- create an empty .NET Core project

- create a storage account that will contain the course data. Create a container *data* and upload *courses.json*.

- run the app and see the courses
<img src="/pictures/api_management2.png" title="api management"  width="900">
<img src="/pictures/api_management3.png" title="api management"  width="900">

- publish the web api to the web app previously built
<img src="/pictures/api_management4.png" title="api management"  width="900">

- you can now use it to create new courses
<img src="/pictures/api_management5.png" title="api management"  width="900">

### Add the API to API Management

- choose HTTP API
<img src="/pictures/http_api.png" title="http api"  width="900">

- add a frontend operation
<img src="/pictures/http_api2.png" title="http api"  width="900">

- use the API in Postman
<img src="/pictures/http_api3.png" title="http api"  width="900">

- add an operation to retrieve a courseId
<img src="/pictures/http_api4.png" title="http api"  width="900">

- use it again in Postman
<img src="/pictures/http_api5.png" title="http api"  width="900">

- add an operation to post a course
<img src="/pictures/http_api6.png" title="http api"  width="900">

- use it again in Postman
<img src="/pictures/http_api7.png" title="http api"  width="900">


## API Management Advanced

### Limit access to the Web App

It doesn't make sense to be able to access the API through the *API Management* as well as the *Web App*. Let's restrict that.

- in the networking section, go to *Access Restriction*
<img src="/pictures/limit_access.png" title="limit access"  width="900">

- add a rule to deny all trafic
<img src="/pictures/limit_access2.png" title="limit access"  width="900">

- add a rule to allow acces from *API Management*. Grab the ip address in the overall section
<img src="/pictures/limit_access3.png" title="limit access"  width="900">

- we now have forbidden access to the web app, but we still have access from the *API Management* 
<img src="/pictures/limit_access4.png" title="limit access"  width="900">

### Virtual Network Connectivity

- create a VM
<img src="/pictures/virtual_network_connectivity.png" title="virtual network connectivity"  width="900">


