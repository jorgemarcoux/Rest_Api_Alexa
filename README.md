
# Week 14 New Endpoints

/api/elevator/inactive/list  - To get a list of all non-operational elevators
/api/employees/fin/email - To find an employee by his or her email



# Rocket Elevator Foundation Week 9

## How to know and to mapiuplate the status of all the relevant entities of the operational database
### Here's a link to the collection of the requests in **[Postman](https://www.getpostman.com/collections/66accb0d5744e80f1086)**. If you prefer, you can do it manually with the walkthrough below. (If for some reason the post link doesn't work, we had some problem last week with it I added a json file with the necessary informations)

1- Returns all fields of all Service Request records that do not have a start date and are in "Pending" status:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Intervention/Pending
    SEND
    
2- Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp)

    PUT 
    https://rest-api-foundation.azurewebsites.net/api/Intervention/InProgress/1	[1 = intervention ID]
    Select:	 Body
                Raw
                JSON
    In the text field, enter: { "status": "InProgress" } 
    SEND
    You can verify if it worked by retrieving infos of the specific intervention (STEP 4)

3- Change the status of the request for action to "Completed" and add an end date and time (Timestamp)

    PUT 
    https://rest-api-foundation.azurewebsites.net/api/Intervention/Completed/1	[1 = intervention ID]
    Select:	 Body
                Raw
                JSON
    In the text field, enter: { "status": "Completed" } 
    SEND
    You can verify if it worked by retrieving infos of the specific intervention (STEP 4).
    
 4- Retrieving the current status of a specific Intervention:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Intervention/1 [1 = intervention ID]
    SEND

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


# Rocket_Elevator_Rest_API
## Members of the team
- **[Loïc Rico](https://github.com/ricoloic)**

- **[Anthony Pageau](https://github.com/ricoloic)**

- **[Jean-Francois Taillefer](https://github.com/ricoloic)**

- **[Louis-Felix Beland](https://github.com/ricoloic)**

- **[Alimourana Balde](https://github.com/alimourana)**

## How to know and to mapiuplate the status of all the relevant entities of the operational database
### Here's a link to the collection of the requests in **[Postman](https://github.com/ricoloic/Rocket_Elevators_API/blob/master/Offer_Services_on_the_Internet.postman_collection.json/)**. If you prefer, you can do it manually with the walkthrough below.

1- Retrieving the current status of a specific Battery:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Battery/1	[1 = battery ID]
    SEND
    
2- Changing the status of a specific Battery:

    PUT 
    https://rest-api-foundation.azurewebsites.net/api/Battery/1	[1 = battery ID]
    Select:	 Body
                Raw
                JSON
    In the text field, enter: { "battery_status": "ACTIVE" or "Inactive" or "Intervention" } 
    SEND
    You can verify if it worked by retrieving the current status of the specific battery (STEP 1).
    
3- Retrieving the current status of a specific Column:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Column/1 [1 = column ID]
    SEND
    
4- Changing the status of a specific Column:

    PUT 
    https://rest-api-foundation.azurewebsites.net/api/Column/1 [1 = column ID]
    Select:  Body
                Raw
                JSON
    In the text field, enter: { "column_status": "ACTIVE" or "Inactive" or "Intervention" } 
    SEND
    You can verify if it worked by retrieving the current status of the specific column (STEP 3).
    
5- Retrieving the current status of a specific Elevator:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Elevator/1 [1 = elevator ID]
    SEND
    
6- Changing the status of a specific Elevator:

    PUT 
    https://rest-api-foundation.azurewebsites.net/api/Elevator/1 [1 = elevator ID]
    Select:  Body
                Raw
                JSON
    In the text field, enter: { "elevator_status": "ACTIVE" or "Inactive" or "Intervention" }
    SEND
    You can verify if it worked by retrieving the current status of the specific elevator (STEP 5).
    
7- Retrieving a list of Elevators that are not in operation at the time of the request:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Elevator
    SEND
    
8- Retrieving a list of Buildings that contain at least one battery, column or elevator requiring intervention:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Building
    SEND
    
9- Retrieving a list of Leads created in the last 30 days who have not yet become customers:

    GET 
    https://rest-api-foundation.azurewebsites.net/api/Lead
    SEND 


