/**
 *  Grading ID:  L8486
 *  Class:       CIS 199-75
 *  Program:     4
 *  Due date:    12/04/19
 *  Description: Library book management system. Demos the use of LibraryBook class.
 **/

using System;
using static System.Console;
using static System.Environment;

class Program
{
    public static void Main()
    {
        const int NUM_OF_DEFAULT_BOOKS = 5; // Amount of default books
        
        // LibraryBook book = new LibraryBook("Title", "Author", "Publisher", 2000, "Call Number");
        LibraryBook book1 = new LibraryBook("Tom's tales", "Tom", "Independant Authors", 2000, "111-111-111");
        LibraryBook book2 = new LibraryBook("Tom's tails", "Tom", "Independant Authors", 2018, "111-222-111");
        LibraryBook book3 = new LibraryBook("Top 100 airplane jokes", "Jefferson airplane", "Independant Authors", 2005, "111-333-111");
        LibraryBook book4 = new LibraryBook("Secret diary", "Jake", "Independant Authors", -1, "111-111-222");
        LibraryBook book5 = new LibraryBook("Tom is dumb", "Jake", "Independant Authors", -1, "111-111-333");
        
        // Populate book array
        LibraryBook[] allBooks = new LibraryBook[NUM_OF_DEFAULT_BOOKS];
        allBooks[0] = book1;
        allBooks[1] = book2;
        allBooks[2] = book3;
        allBooks[3] = book4;
        allBooks[4] = book5;

        // DEMO
        ListBooks(allBooks);
        book2.CheckOut();
        book4.CheckOut();
        book1.Publisher = "Thomas";
        book5.CallNumber = "123-456-789";
        ListBooks(allBooks);
        book2.ReturnToShelf();
        book4.ReturnToShelf();
        ListBooks(allBooks);
        ReadKey();
        // END DEMO
    }

    // Pre-Condition:  LibraryBook array must exist
    // Post-Condition: Prints each LibraryBook object's ToString in the array
    private static void ListBooks(LibraryBook[] allBooks)
    {
        for (int i = 0; i < allBooks.Length; ++i)
            WriteLine($"{NewLine}Book #{i + 1} of {allBooks.Length}{NewLine}{allBooks[i].ToString()}");
    }
}