using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    public Text myGuess;

    int min = 0;
    int max = 0;
    int guess = 0;
    int maxGuesses = 5;

    // Use this for initialization
    void Start () {

        StartGame();

    }
	
	// Update is called once per frame
	void Update () {

    }

    void StartGame()
    {

        min = 1;
        max = 1000;
        //guess = 500;

        NextGuess();
    }

    void NextGuess()
    {
        if (maxGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }
        else {
            guess = Random.Range(min, (max + 1));
            myGuess.text = guess + "?";
            maxGuesses--;
        }
    }

    public void GuessHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
        
    }

    
    
}
