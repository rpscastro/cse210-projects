using System;

class Word
{
    //Private variables
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text){

        _text = text;
    }

    //Methods to change private variables
    public void Hide(){

        _isHidden = true;
    }

    public void Show(){

        _isHidden = false;

    }

    public bool IsHidden(){

        return _isHidden;

    }

    //Display text of a word
    public string GetDisplayText(){

        string displayText = _text;

        //If a word is hidden, it will show underscores for each character
        if(_isHidden){

            String hidden = new String('_',_text.Length);
            displayText = _text.Replace(_text,hidden);
        }

        return displayText;

    }



}