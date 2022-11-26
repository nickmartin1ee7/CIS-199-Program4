/**
 *  Grading ID:  L8486
 *  Class:       CIS 199-75
 *  Program:     4
 *  Due date:    12/04/19
 *  Description: Library book object class.
 **/

using System;
using static System.Console;
using static System.Environment;

public class LibraryBook
{
    const int DEFAULT_YEAR = 2019;  // Default copyright year
    public string Title {   // Book's title
        // Pre-Condition:  None
        // Post-Condition: Returns a string
        get;
        // Pre-Condition:  None
        // Post-Condition: Sets property to value as a string
        set;
    }
    public string Author {  // Book's author
        // Pre-Condition:  None
        // Post-Condition: Returns a string
        get;
        // Pre-Condition:  None
        // Post-Condition: Sets property to value as a string
        set;
    }
    public string Publisher {   // Book's publisher
        // Pre-Condition:  None
        // Post-Condition: Returns a string
        get;
        // Pre-Condition:  None
        // Post-Condition: Sets property to value as a string
        set;
        }
    public string CallNumber {  // Book's call number
        // Pre-Condition:  None
        // Post-Condition: Returns a string
        get;
        // Pre-Condition:  None
        // Post-Condition: Sets property to value as a string
        set;
        }
    private int _copyrightYear; // Copyright year backing field
    public int CopyrightYear {  // Book's copyright year
        // Pre-Condition:  None
        // Post-Condition: Returns an int
        get {return _copyrightYear;}
        // Pre-Condition:  0 < value < infinate
        // Post-Condition: Sets property's backing field to value if positive, otherwise set to 2019
        set {
            if (value >= 0)
                _copyrightYear = value;
            else
                _copyrightYear = DEFAULT_YEAR;
            }
        }
    private bool CheckedOut {   // Book's checked out status. False = On shelf, True = Checked out. Private because will only be called via class method
        // Pre-Condition:  None
        // Post-Condition: Returns a boolean
        get;
        // Pre-Condition:  None
        // Post-Condition: Sets property to value as a boolean
        set;
    }

    // Constructor
    // Pre-Condition:  4 Strings and 1 int passed to constructor
    // Post-Condition: Constructs LibraryBook object with given arguments and by default not checked out
    public LibraryBook(string title, string author, string publisher, int copyrightYear, string callNumber)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        CopyrightYear = copyrightYear;
        CallNumber = callNumber;
        CheckedOut = false;    // Is book checked out flag. False by default.
    }

    // Methods
    // Pre-Condition:  None
    // Post-Condition: CheckedOut boolean will be true. Error message will be displayed if already true
    public void CheckOut()
    {
        if (CheckedOut)
            WriteLine("Error: already checked out");
        else
            CheckedOut = true;
    }
    
    // Pre-Condition:  None
    // Post-Condition: CheckedOut boolean will be false. Error message will be displayed if already false
    public void ReturnToShelf()
    {
         if (CheckedOut)
            CheckedOut = false;
        else
            WriteLine("Error: already on shelf");
    }

    // Pre-Condition:  None
    // Post-Condition: Returns a boolean
    public bool IsCheckedOut()
    {
        return CheckedOut;
    }

    // Pre-Condition:  None
    // Post-Condition: Returns a string of all object's data in custom format
    public override string ToString()
    {
        string result = $"Title: {Title}{NewLine}Author: {Author}{NewLine}Publisher: {Publisher}{NewLine}Copyright Year: {CopyrightYear}{NewLine}Call Number: {CallNumber}{NewLine}Is checked out? {CheckedOut}";
        return result;
    }
}