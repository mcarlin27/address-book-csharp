# CD List

#### A program that allows users to enter Contacts into an Address Book, separating those COntacts by Category with the aim to improve search functionality. 5/26/17

#### By **Marilyn Carlin**

## Description

A website created with C#, HTML, and CSS where a user can input Contacts into an address book, and then view those Contacts either generally, or by Category."

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Homepage** | User accesses localhost:5004| Homepage with links to other pages |
| **Add Category** | User clicks link to add category| Form for submission of new category |
| **Add Contact**| localhost:5004/contact/new | Form for submission of new contact |
| **View All Categories**| localhost:5004/categories | Page displaying all categories (clickable) |
| **View All Contacts** | localhost:5004/contacts | Page displaying all categories (clickable) |
| **Clear All Contacts** | User clicks link to clear contacts | Page displaying confirmation of cleared contacts |
| **View One Category** | localhost:5004/categories/{id} | Page displaying one instance of category |
| **View One Contact** | localhost:5004/contacts/{id} | Page displaying one instance of contact |

## Setup/Installation Requirements

1. To run this program, you must have a C# compiler. I use [Mono](http://www.mono-project.com).
2. Install the [Nancy](http://nancyfx.org/) framework to use the view engine. Follow the link for installation instructions.
3. Clone this repository.
4. Open the command line--I use PowerShell--and navigate into the repository. Use the command "dnx kestrel" to start the server.
5. On your browser, navigate to "localhost:5004" and enjoy!

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
  * Nancy framework
  * Razor View Engine
  * ASP.NET Kestrel HTTP server
* HTML
* CSS
  * Bootstrap

## Support and contact details

_Email no one with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2017 **_{Marilyn Carlin}_**
