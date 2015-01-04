using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour {
	public GameObject bullet;
	public GameObject heroPos;
	Vector3 startPos;
	public int shotsCount;
	public  int maxEnemiesToEndGame; //triger for ending the game

	private static int deadenemyCounter; //triger for ending the game
	private int score;


	//public Text scoreText;
		
	void Start(){
		score = 0;
		deadenemyCounter = 0;
	}

	public void increaseDeadenemyCount()
	{
		deadenemyCounter++;
		if (deadenemyCounter >= maxEnemiesToEndGame) {
			GameObject manager = GameObject.FindGameObjectWithTag("game_manager");
			manager.GetComponent<startScreen>().gameWon();
				

		}
	}

	public void addScore(int points){
		score += points;	
	}

	public int getScore(){
		return score;	
	}

	public void addShots(int shotsToAdd){
		shotsCount += shotsToAdd;	
	}
	
	public int getShotsCount(){
		return shotsCount;	
	}
}
