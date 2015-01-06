using UnityEngine;
using System.Collections;

public class CreateWavesRandomly : MonoBehaviour {
	public GameObject[] waves;
	private GameObject[] RandomWaves;
	public float TimeUntilNextWave;
	public float TimeUntilFirstWave;
	public float TimeUntilNextRoundOfWaves;
	public int TotalEnemiesInWaveSet;
	private float direction;
	
	void Start (){
		TotalEnemiesInWaveSet = 0;
		int numOfWaves = Random.Range (3, 8);
		print ("NUm of Waves " + numOfWaves);
		RandomWaves = new GameObject[numOfWaves];
		for (int i = 0; i < numOfWaves; i++) {
			RandomWaves [i] = waves [Random.Range (1, waves.Length)];
			TotalEnemiesInWaveSet = TotalEnemiesInWaveSet+ RandomWaves [i].gameObject.GetComponent<createEnemeiesWave> ().size;		
			print("GetTotalEnemiesInSet RANDOM " + TotalEnemiesInWaveSet);
		}
		
		StartCoroutine (CreateWaves ());
	}
	
	IEnumerator CreateWaves ()
	{
		yield return new WaitForSeconds (TimeUntilFirstWave);
		for (int i = 0; i < RandomWaves.Length; i++){
			if(Random.Range(1,10) > 5)
				direction = -1f;
			else
				direction = 1f;
			GameObject RandomWave =  Instantiate (RandomWaves[i], this.gameObject.transform.position, Quaternion.identity) as GameObject;
			RandomWave.gameObject.transform.position = new Vector3(direction,RandomWave.transform.position.y,RandomWave.transform.position.z);
			yield return new WaitForSeconds (TimeUntilNextWave);
		}
		//yield return new WaitForSeconds (TimeUntilNextRoundOfWaves);
		Destroy(this.gameObject);
	}
	
	public int GetTotalEnemiesInSet(){
		return TotalEnemiesInWaveSet;
	}
}

