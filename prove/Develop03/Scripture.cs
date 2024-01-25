using System;

class Scripture
{
    //Private variables
    private Reference _reference;

    private List<Word> _words;

    //Constructor
    public Scripture(Reference Reference, string text){

        _reference = Reference;

        _words = new List<Word>();

        //Crates a list of Word objects from a string
        string[] wordsText = text.Split(" ");

        for(int i = 0; i < wordsText.Length; i++)
        {
            Word word = new Word(wordsText[i]);
            _words.Add(word);
            
        }

    }


    public void HideRandomWords(int numberToHide){

       int countHidden = 0;

        //Generates a random index
       Random randomGenerator = new Random();
       int randomIndex = randomGenerator.Next(0, _words.Count);

       do
       {

        //Check if a word is already hidden before hiding it
        if(!_words[randomIndex].IsHidden()){

            _words[randomIndex].Hide();
            countHidden++;

        }
        else{

            randomIndex = randomGenerator.Next(0, _words.Count);

        }


       } while(countHidden < numberToHide && !IsCompletelyHidden());


    }

    //Display the text of the entire scripture with its reference
    public string GetDisplayText(){

        string displayText = _reference.GetDisplayText();
        
        foreach(Word word in _words){

            displayText = displayText + " " + word.GetDisplayText();
        }
        
        return displayText;
    }

    //Check if the scripture is entire hidden
    public bool IsCompletelyHidden(){

        int countHiddens = 0;
        bool completelyHidden = false;

        foreach(Word word in _words){

            
            if(word.IsHidden()){

                countHiddens++;

            } 
        }

        if(countHiddens == _words.Count){

            completelyHidden = true;
        }
        return completelyHidden;
    }




}