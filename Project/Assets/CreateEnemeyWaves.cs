using UnityEngine;
using System.Collections;

public class CreateEnemeyWaves : MonoBehaviour {
	public GameObject[] waves;
	public float TimeUntilNextWave;
	public float TimeUntilFirstWave;
	public float TimeUntilNextRoundOfWaves;
	public int TotalEnemiesInWaveSet = 0;
	public bool isRandom;
	
	void Start (){
		StartCoroutine (CreateWaves ());
	}
	
	IEnumerator CreateWaves ()
	{
		yield return new WaitForSeconds (TimeUntilFirstWave);
			for (int i = 0; i < waves.Length; i++){
				Instantiate (waves[i], this.gameObject.transform.position, Quaternion.identity);
				yield return new WaitForSeconds (TimeUntilNextWave);
			}
			//yield return new WaitForSeconds (TimeUntilNextRoundOfWaves);
			Destroy(this.gameObject);
	}

	public int GetTotalEnemiesInSet(){
		print("GetTotalEnemiesInSet " + TotalEnemiesInWaveSet);
		return TotalEnemiesInWaveSet;
	}

}
