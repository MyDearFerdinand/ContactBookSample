Contact Book

The Contact Book is a simple console application implemented in C#. It serves as an introduction to object-oriented programming, file I/O operations, exception handling, and usage of generics in C#.

Overview

This application allows users to manage a simple contact book. The contact book stores contact names and their associated phone numbers.

The contact data is stored in a text file. The application provides functionality to add a new contact to the book, retrieve the phone number of an existing contact, and save the contacts to a file for persistent storage. The application handles file read/write exceptions gracefully, informing the user whenever an error occurs.

Features

Object-Oriented Programming (OOP): The application is structured around the ContactBook class, showcasing the principles of OOP.

File I/O: The contact book is stored persistently in a file. The application reads from this file when it starts, and writes to the file whenever a new contact is added.

Exception Handling: The application includes exception handling for file I/O operations. This ensures that any errors encountered during file read/write operations do not crash the application and are appropriately communicated to the user.

User Input: Users can add their own contacts to the contact book through console input.

Future Enhancements

Future enhancements could include more functionalities such as deleting or editing contacts, validating phone numbers before they are added, and perhaps expanding the contact model to include additional information like email addresses.
