using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
	int max;
	int min;
	int guess;
	int maxNumberOfGuesses = 8;
	
	public Text textGuess;
	public Text textNumberOfGuesses;

	// Use this for initialization
	void Start (){
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
		textNumberOfGuesses.text = "" + maxNumberOfGuesses;
		
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		textGuess.text = "" + guess;
		maxNumberOfGuesses--;
		textNumberOfGuesses.text = "" + maxNumberOfGuesses;
		if(maxNumberOfGuesses <= 0){
			Application.LoadLevel("Win");
		}
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess ();
	}
}
