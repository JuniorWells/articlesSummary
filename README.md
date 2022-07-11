# Project: Summary table of articles

## Key Notes:
  * MVP (one-day hackathon project)
  * One can filter the articles based on the Category they belong to
  * It's responsive :)
  * Rome wasn't built in a day, but this was.

## TechStack: 
  * Front-end: ReactJS
  * Back-end: .NET WebAPI, Entity Framework
  * DB: SQL-Server (Docker)

## Future Iterations:
  * Fetch data from external API, daily
  * Use subcategories for advanced filtering
  * Personalised space with recommended articles

## Test it yourself
  1. Clone this repo
  2. Navigate to the root directory and run the docker container<br/>
     `docker-compose up -d` 
  3. Go to BlogDemo.API/ and type<br/>
     `dotnet ef migrations add InitialCreate`<br/>
     `dotnet ef database update`<br/>
     to create your database.
  4. Run your dotnet app<br/>
     `dotnet run`
  5. Open a new terminal and go to blogDemo.Client/ 
  6. Install the npm packages<br/>
     `npm install`
  7. Launch the program<br/>
     `npm start`
     
 # TL;DR
 
 <img width="1293" alt="Preview in full width" src="https://user-images.githubusercontent.com/73603212/178333876-8fc93099-a118-4ad6-b791-570c78cd5b3e.png">

  
