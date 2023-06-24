# Connect and Consume services - Azure API Management


## API Management

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


