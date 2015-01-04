using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	//public int HP;
	private int EnemyClassHP;

	// Use this for initialization
	void Start () {
		 EnemyClassHP = this.gameObject.GetComponent<enemyClass> ().HP;
	}
	
	// Update is called once per frame
	void Update () {
		EnemyClassHP = this.gameObject.GetComponent<enemyClass> ().HP;
		if (EnemyClassHP <= 0) {

		//	StartCoroutine(wait());
			GameObject manager = GameObject.FindGameObjectWithTag("game_manager");
			manager.GetComponent<startScreen>().gameWon();
				}
	
	}


}
