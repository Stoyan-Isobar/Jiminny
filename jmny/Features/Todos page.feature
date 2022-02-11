Feature: Todos page basic functionality
	In order to enable users to organize tasks
    As a user of the website
    I want to create and manage todo lists

@functional

Scenario: Todo welcoming page layout

Given the url to the Todo page is: <todo_page_url>
When the Todo page is accessed via a browser
Then the following elements are on the page:
|ElementName|ElementValue|
|Header|todos|
|Input|What needs to be done?|
|Footer1|Double-click to edit a todo|
|Footer2|Written by Evan You|
And the element Footer 2 has the following details:
|p(paragraph)|a(hiperlink)|
|Written by|<a href="http://evanyou.me">Evan You</a>|