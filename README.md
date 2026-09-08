# Library-Management-System-Console-App

A console-based library book tracker built in C#, allowing a librarian to manage book titles, track available copies, and handle issuing and returning of books. Built to practice class design, encapsulation, and calculated (read-only) properties in C#.

# Features
Add Book — add a new book title with its total number of copies
View All Books — display every book in the system along with its currently available copy count
Issue Book — issue a copy of a book to a borrower, with checks to prevent issuing a book that doesn't exist or has no copies left
Return Book — return a previously issued copy back into circulation
Search Book — look up a book by title and see how many copies are currently available
# Tech Stack
C# (.NET)
Console Application
In-memory data storage using List<T> / Dictionary (no external database)
Architecture / OOP Concepts Used
Encapsulation — TotalCopies and IssuedCopies are private fields exposed through public properties, so invalid data (e.g. a negative copy count) can be rejected at the point of assignment
Calculated (Read-Only) Property — AvailableCopies is not stored directly; it is computed on demand as TotalCopies - IssuedCopies via a get-only property, so it can never fall out of sync with the underlying data
Validated Properties — setting TotalCopies to a negative value is rejected rather than silently accepted
State-Changing Methods — IssueCopy() and ReturnCopy() encapsulate the business rules around borrowing (can't issue more copies than exist, can't return more than were issued) rather than letting calling code manipulate the counts directly
ToString() Override — each book prints a clean, readable summary (Book: <title> by <author>, Available: X/Y) instead of the default object representation
# Project Structure
Program.cs
├── Main()                — menu-driven console loop
├── AddBook()              — add a new book title with total copies
├── ViewAllBooks()          — display every book and its available copies
├── IssueBook()              — issue a copy of a book
├── ReturnBook()              — return a copy of a book
├── SearchBook()                — look up a book by title
│
└── Book
    ├── Title, Author              — public fields
    ├── TotalCopies (property)      — validated, rejects negative values
    ├── AvailableCopies (property)   — read-only, calculated as TotalCopies - IssuedCopies
    ├── IssueCopy()                    — decreases available copies, blocks if none left
    ├── ReturnCopy()                    — increases available copies, blocks if nothing was issued
    └── ToString() override              — formatted book summary
# How to Run
Clone the repository
Open the project in Visual Studio / VS Code
Run dotnet run or launch via the IDE
Use the on-screen menu to add books, issue/return copies, and search the catalog
Sample Menu Flow
1 - Add Book
2 - View All Books
3 - Issue Book
4 - Return Book
5 - Search Book
6 - Exit
What I Learned

This project focuses on getting class design right at a smaller scale before moving to bigger multi-class systems — specifically the difference between a stored property (TotalCopies) and a calculated one (AvailableCopies), why business rules (like refusing to issue a book with zero copies left) belong inside the class rather than in the calling code, and how validation in a property setter prevents bad data from ever entering the system in the first place.
