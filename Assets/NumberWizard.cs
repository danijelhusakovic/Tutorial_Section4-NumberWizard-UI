using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
	int max;
	int min;
	int guess;
	int maxNumberOfGuesses = 10;
	
	public Text textGuess;
	public Text textNumberOfGuesses;

	// Use this for initialization
	void Start (){
		StartGame();
	}
	
	void StartGame () {
		max = 1001;
		min = 1;
		NextGuess();
		textNumberOfGuesses.text = "" + maxNumberOfGuesses;
		
	}
	
	void NextGuess () {
		//guess = (max + min) / 2;
		guess = Random.Range(min, 	max + 1);
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
