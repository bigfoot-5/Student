# Graduate Web Development Assessment
use "dotnet watch" to start the application
```
dotnet watch
```
The code contains solution for the following tasks

## Task 1
You should have been sent an accompanying file students-and-subjects.csv. This includes example data for a group of 20 fictional students. 
For each student there is a record of an id number, first name, surname, title, e-mail address, date of birth, and up to 2 subjects that the student is studying.
Using this csv please design a relational database that would be appropriate for storing all the details in the csv file. 
Please provide a database diagram showing the tables you would use in the database, and the relationships between the tables, and accompanying SQL commands that you would use to create the tables and their relationships.

## Task 2
Please create a web page that displays a list of all students in the attached spreadsheet. This page needs to display the following information about each student - id, first name, surname, title, and e-mail address.
This web page does not have to connect to a data source, and you can just use the static data provided if you wish.
Please use bootstrap v5.3 (https://getbootstrap.com/) to help you build this web page.

## Task 3
Please create a web page for creating a new student account. This page needs to provide input fields for:
- first name (maximum 25 characters)
- surname (maximum 25 characters)
- title
- e-mail address (maximum 50 characters)
- date of birth (date picker)
- Up to 2 subjects
This web page does not have to connect to a data source to save the data and can just be a web page to allow data to be input and provide client-side validation.
Please use bootstrap v5.3 (https://getbootstrap.com/) to help you build this web page.

 
## Task 4
The following JSON feed is used to lists courses at the University where students can study some of the course at a partner institute:
https://www.liverpool.ac.uk/app-data/study-abroad/courses.json
Please create a web page to list all the courses that are available. Each course name should be a link that when clicked on will then provide a list of the names and countries of partner universities where the course can be studied.
Please use bootstrap v5.3 (https://getbootstrap.com/) to help you build these web pages.
