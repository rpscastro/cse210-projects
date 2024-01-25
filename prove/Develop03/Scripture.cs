using System;

class Scripture
{

    private Reference _reference;

    private List<Word> _words;

    Scripture(Reference Reference, string text){

        _reference = Reference;

        _words = new List<Word>();
    }


    public void HideRandomWords(int numberToHide){


    }

    public string GetDisplayText(){

        return "";
    }

    public bool IsCompletelyHidden(){

        return false;
    }




}