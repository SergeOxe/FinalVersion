using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour {
	public GameObject bullet;
	public GameObject heroPos;
	Vector3 startPos;
	private int score;


	//public Text scoreText;
		
	void Start(){
		score = 0;
	}


	public void addScore(int points){
		score += points;	
		if (score < 0)
			score = 0;
	}

	public int getScore(){
		return score;	
	}


}
