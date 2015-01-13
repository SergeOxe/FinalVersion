using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {
	public int PointsDecreaseWhenEnemyIsLEavingTheScreen;
	public GameObject points;
	public Vector3 offset;
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "enemy") {
			col.gameObject.GetComponent<enemyClass> ().DestroyThis ();
			if(points != null){
				GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller> ().addScore (PointsDecreaseWhenEnemyIsLEavingTheScreen);
				Instantiate (points, col.transform.position+offset, Quaternion.identity);
			}
		} else
			Destroy (col.gameObject);
		}
}
