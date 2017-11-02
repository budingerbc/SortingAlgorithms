Testing - Cuisines:
- Adding a cuisine to the database.
- Confirming

### User Story

| User Behavior | Input | Output |
|----|----|----|  
| User enters cuisine in homepage field and then is redirected to new cuisine confirmation page | Chinese | You created the Chinese cuisine |
| User presses button to go back to list of cuisines | Button Click | Homepage |
| User can click on a cuisine to add a restaurant to that cuisine and is presented with text that states that "No restaurants have been added to this cuisine" | Click on particular cuisine | Cuisine Id Page |
| User enters a restaurant in the specific cuisine page and then is redirected to new restaurant page | Chinese Garden | You created the Chinese Garden restaurant |
| User clicks a button to return to that specific cuisine page to see newly added restaurant to the restaurant list | Clicks "Back to cuisine" | Specific Cuisine Page|
| User can update cuisine name on homepage | User clicks update link| Redirected to edit cuisine page|
|User enters new name of cuisine in field on cuisine edit page| Authentic Chinese | Redirected to Homepage with updated cuisine - Authentic Chinese |
|User can delete a specific cuisine from homepage | User clicks on delete link/button | Redirected back to homepage |
|User can update restaurant name from specific cuisine page | Clicks update link | Redirected to edit restaurant page |
|User can delete restaurant name | Clicks delete button| Redirected to the specific cuisine page|
| User clicks on specific restaurant and is directed to a page with details about the restaurant | Click on specific restaurant | Goes to specific restaurant page|
|User click button to go back to cuisine page and/or homepage| Clicks| specific Cuisine page or homepage
|User searches for specific cuisine and if that cuisine exists then all the restaurant within that cuisine are returned| Chinese | Chinese Garden... etc|






### Technical Specs - each spec relates to a test method

| App Behavior | Expected | Actual |
|----|----|----|  
|  Save cuisine to database  |  Chinese  |  Chinese  |
|  Get a list of all cuisines from DB | List of all cuisines | List of all cuisines from DB |
|  Find cuisine by Id | Cuisine Id | Cuisine Id from DB |
| Save restaurant to database | Chinese Garden | Chinese Garden|
|  Find restaurant by Id | Restaurant Id | Restaurant Id from DB |
|  Displays list of all restaurants in cuisine category | List of all restaurants in cuisine category | All restaurants in cuisine category from DB |
| Update specific cuisine name | Authentic Chinese | Authentic Chinese|
| Delete specific cuisine name | Create 2 cuisines and delete one  | Create 2 cuisine instances in db and delete one|
| Update specific restaurant name | Chinese Palace | Chinese Palace|
| Delete specific restaurant name | Create 2 restaurant instances and delete one  | Create 2 restaurant instances in db and delete one|
| Search by Cuisine method | Chinese | Chinese Palace|




Notes:
- Homepage will list clickable cuisines and have a field to create a new cuisine.

- Once new cuisine is create have a confirmation page that the cuisine has been created with the id of that cuisine in the url and a button to go back to Home page.

- Once clicked on cuisine then it lists restaurants for that particular cuisine and have a field to add a restaurant to that cuisine type.

- After a restaurant is created user is directed to a confirmation page that list the newly created restaurant with the id in the url and buttons to back to that particular cuisine with a list of the restaurants and home page button.
