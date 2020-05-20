

# Project Obi
This repository will hold all of the designs, sketches, mock-ups and diagrams for my project LuLuHobby

**Obi**
**Description**\
The idea is to connect people through shared hobbies using digital media, such as short videos, and image posts. With Obi, you will have a personal profile to showcase all of your personal hobbies. You can see all fellow hobbyists in your local area by looking at a local feed. You may sort and filter your feed to be specific hobbies , or you may also use the explore option to see all hobbies participated in your local area.

To preview the current prototype please click here: https://zhangw31.github.io/Project-LuLuHobby/  

To view my current work in progress prototype with Figma:  
[View my Figma Prototype](https://www.figma.com/proto/qiMsWkyacvO1lRhfuE2Su2/Figma-Test?node-id=2%3A7&scaling=min-zoom)

Technologies used in this project:

React Class Library with Typescript
Axios
MobX
React Router
ASP.NET Core
Entity Framework Core


Table of Contents

- **[LuLuHobby Entity Relation Diagram](#luluhobby-entity-relation-diagram)**<br>
- **[Initial Database Diagram](#initial-database-diagram)**<br>
- **[Initial Wireframe Sketches](#initial-wireframe-sketches)**<br>
- **[Requirements](#requirements)**<br>
- **[User Stories](#user-stories)**<br>
- **[Use Cases](#use-cases)**<br>
- **[Requirements Table](#requirements-table)**<br>
- **[Test Table](#test-table)**<br>
- **[Prototypes](#prototypes)**<br>
- **[Upcoming updates](#upcoming-updates)**<br>



## LuLuHobby Entity Relation Diagram

![LuLuHobby ERD](https://github.com/ZHANGW31/LuLu-Hobby-Design/blob/master/LLH%20ERD.PNG)

## Initial Database Diagram

![DatabaseDiagram](https://github.com/ZHANGW31/Project-LuLuHobby/blob/master/Initial%20Database%20Diagram.PNG)

## Initial Wireframe Sketches

![LuLuHobby WireFrame Sketch](https://github.com/ZHANGW31/LuLu-Hobby-Design/blob/master/LuLuHobby%20First%20WireFrame.jpg)

![LuLuHobby WireFrame Sketch](https://github.com/ZHANGW31/LuLu-Hobby-Design/blob/master/LuLuHobby%20Second%20WireFrame.jpg)



## Requirements

## User Stories  
|ID |User Stories                                                                                                                    |   
|---|:-------------------------------------------------------------------------------------------------------------------------------|
|1.1| As a user of LuLuHobby, I want create posts with digital media such as photos, and images so that I can showcase my interests.
|1.2| As a user, I want to have a personal profile to showcase all of my hobbies.
|1.3| As a user, I want to be able to see everyone in my local area that share the same hobbies as me.
|1.4| As a user, I want to be able to filter and search for specific hobbies in my local area to see what interests me.
|1.5| As a user, I want to communicate with other users, and add friends so I can connect with like minded people.
|1.6| As a user, I want to be able to send friend requests to connect with others so that I can see what they do and share posts.
|1.7| As a user, I want to be able to modify how my account looks, such as profile photo, cover photo, bio, and listing my hobbies to         personalize my page.
|1.8| As a user, I want to be able to modify my account settings to set preferences.
|1.9| As a user, I want to have customize options for my profile visual appeal.
|1.10| As a user, I want to be able to make certain posts private for privacy.
|1.11| As a user, I want to be able to add and remove hobbies to my hobby list at will so that I can expand or lessen results.

## Use-Cases
|ID |Use Cases                                                                                                                     |
|---|:-----------------------------------------------------------------------------------------------------------------------------|
|2.1| Given user action, when they click upload digital media, then an option to upload from desktop appears.
|2.2| Given user action, when they first login the website, then they are shown the homepage and the digital media is shown.
|2.3| Given user action, when they scroll down on the homepage, new digital media is loaded.
|2.4| Given user action, when they select filter, then a dropdown list appears to allow the user to filter through the media.
|2.5| Given user action, when they click on a media, then it will be brought into a larger view.
|2.6| Given user action, when they click on like, comment, or share, then the corresponding actions will be applied. Like will add a           thumbs up to the digital media, comment will open a text box, and share will display the URL of the post.
|2.7| Given user action, when they click on the profile of the poster of the digital media, then it will take the user to their               homepage.
|2.8| Given user action, when they click on the explore option, then all hobbies that are happening in their area will be displayed.
|2.9| Given user action, when they click on add to personal hobby list, then the hobby is then associated to the user account and the         user will start seeing posts pertaining to that hobby.


![LuLuHobby Use-Case Diagram](https://github.com/ZHANGW31/LuLu-Hobby-Design/blob/master/LuLuHobby%20Use%20Case%20Diagram.jpg)


## Requirements Table  

This requirements table highlights the requirements and the fundamental methods of requirement verification.  

Also shows whether or not the requirement is implemented, what test method, the corresponding test id, and whether or 
not it has been tested.  


|ID   |Requirements Cases Description | Implemented | Test Method | Test ID | Tested |
|-----|:------------------------------|:-----------:|:-----------:|:-------:|:------:|
|4.1.1|System shall allow users to create an account   | No | Demonstration | T1 | No |                                                
|4.1.2|System shall verify email account| No | Test | T2 | No |                                               
|4.1.3|System shall allow user login  | No | Test | T3 | No |
|4.1.4|System shall allow users to modify profile  | No | Demonstration | T4 | No | 
|4.1.5|System shall allow add hobbies  | Yes | Demonstration | T5 | Yes |
|4.1.6|System shall allow for users to search for hobbies  | No | Test | T6 | No |
|4.1.7|System shall see digital media pertaining to their shared hobbies on their homepage.  | No | Inspection | T7 | No |
|4.2.1|System shall provide web-page | Yes | Test | T8 | Yes |
|4.2.2|System shall provide user interface  | Yes | Test | T9 | Yes |
|4.2.3|System shall provide page navigation    | Yes | Test | T10 | Yes |
|4.2.4|System shall provide dynamic visual media   | Yes | Test | T11| Yes |
|4.3.1|Software shall verify user login  | No | Test | T12 | No |
|4.3.2|Software shall verify user connection   | No | Test | T13 | No |
|4.3.3|Software shall verify that the user is logged out if inactive.  | No | Test | T14 | No |
|4.3.4|Software shall make sure that user's posted media is saved to the database.   | Yes | Test | T15 | Yes |
|4.3.5|Software shall make sure that the user profile is updated to reflect user changes.  | No | Inspection | T16 | No |
|4.3.6|Software shall make sure that user's filter actions are applied.   | No | Inspection | T17 | No |
|4.3.7|Software shall make sure that user's searches return accurate results.  | No | Inspection | T18 | No |
|4.3.8|Software shall make sure that no obscene or offensive media is posted.  | No | Test | T19 | No |

## Test Table

| Test ID | Req ID('s) | Test Procedure | Current Status | Time Stamp | Build Version |
|:--------|:-------|:---------------|:--------------:|:----------:|:-------------:|
|T1       |4.1.1 , 4.1.3| Click on the sign up button to open form. Page should display required fields to be filled out | Not Tested | N/A | 0.0.0 |
|T2       |4.1.2| Click on the link sent to the user email account | Not Tested | N/A | 0.0.0 |    
|T3       |4.1.3| On the signup/login page, enter credentials and click on the login button | Not Tested | N/A | 0.0.0 |
|T4       |4.1.4| Click on the settings icon, and attempt to modify and save settings. | Not Tested | N/A | 0.0.0 |
|T5       |4.1.5| Click on the add hobby , go to user homepage and visually see that the hobby is added. | Not Tested | N/A | 0.0.0 |
|T6       |4.1.6| Click on the search bar and start typing a hobby, the search should start populating results with clickable | Not Tested | N/A | 0.0.0 |
|T7       |4.1.7| When loaded into the homepage, visually inspect that digital media of shared hobbies are displayed. | Not Tested | N/A | 0.0.0 |
|T8       |4.2.1| Upon connecting to the site, or login page, the requested webpage is loaded. | Tested | N/A | 0.0.0 |
|T9       |4.2.2| Visually inspect that the user interface is displayed upon loading of webpage. | Tested | N/A | 0.0.0 |
|T10      |4.2.3| Click on navigation links and visually inspect that it navigates to the intended location. | Tested | N/A | 0.0.0 |
|T11      |4.2.4| On the homepage, see if digital media is loaded and when clicked upon, loads and plays. | Not Tested | N/A | 0.0.0 |
|T12      |4.3.1| Enter credentials to and click login if correct log in success and display homepage, supply faulty credentials to display correct errors. | Not Tested | N/A | 0.0.0 |
|T13      |4.3.2| Check to see if the client is connected to the server. Click refresh on client to see if still logged in. | Not Tested | N/A | 0.0.0 |
|T14      |4.3.3| Log in and stay inactive (without pressing anything or navigating anywhere) for 5 minutes, it should auto log off client. | Not Tested | N/A | 0.0.0 |
|T15      |4.3.4| Check database entries and query for the information. It should exist. | Tested | N/A | 0.0.0 |
|T16      |4.3.5| Click refresh on the settings page to make sure the changes were applied. | Tested | N/A | 0.0.0 |
|T17      |4.3.6| Click on filter , apply filters, and the pass case results will be correctly filtered. | Tested | N/A | 0.0.0 |
|T18      |4.3.7| Click refresh after the filters are clicked to display the filtered results. | Not Tested | N/A | 0.0.0 |
|T19      |4.3.8| Attempt to upload unsafe content. The Moderation API should filter and disallow or remove unsafe content. | Not Tested | N/A | 0.0.0 |

## Prototypes
![Prototype Login Page](https://github.com/ZHANGW31/Project-LuLuHobby/blob/master/Prototype%20Login%20page.PNG)  

## Upcoming updates

Digital Mockups  

Additional Prototype Pages: Homepage, Friend's Page, Location Page, and Hobby Page.

Created Database and using Entity Framework Core connected the database to ASP.NET Core MVC project

Sprint planning! Will be utilizing Zenhub to show the current progress of issues and to track what is currently being worked on.

Changed the project name to Obi, from LuLu Hobby!
