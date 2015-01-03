using UnityEngine;
using System.Collections;

public enum Enum_RewardType{BOMB, SHOTS, LIVES};


public class EnemyReward : MonoBehaviour {
	public float force;
	public Enum_RewardType rewardType;

	// Use this for initialization
	void Start () {
		this.gameObject.rigidbody2D.AddForce((new Vector2(0,1)) * force);  //Pop the reward up

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Player") {
			this.gameObject.collider2D.enabled = false;
			if(rewardType == Enum_RewardType.BOMB){
				gameObject.GetComponent<Animator>().SetBool ("Boom", true);
			}
			else
				Destroy(this.gameObject);
			col.gameObject.GetComponent<PlayerController>().reactToReward(rewardType);
		}
	}
}
