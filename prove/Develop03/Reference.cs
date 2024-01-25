using System;
using System.Data;

class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    Reference(string book, int chapter, int verse){

        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    Reference(string book, int chapter, int startVerse, int endVerse){

        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {

        return " ";
    }



}