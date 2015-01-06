using UnityEngine;
using System.Collections;

public class CreateWavesRandomly : MonoBehaviour {
	public GameObject[] waves;
	public int[] RandomWaves ;
	public float TimeUntilNextWave;
	public float TimeUntilFirstWave;
	public float TimeUntilNextRoundOfWaves;
	public int TotalEnemiesInWaveSet;
	private float direction;
	private int numOfWaves;
	
	void Start (){
		numOfWaves = Random.Range (3, 9);
		print ("Num of Waves " + numOfWaves);
		RandomWaves = new int[numOfWaves];
		for (int i = 0; i < numOfWaves; i++) {
			RandomWaves [i] = Random.Range (1, waves.Length);
			TotalEnemiesInWaveSet = TotalEnemiesInWaveSet+ waves [RandomWaves [i]].gameObject.GetComponent<createEnemeiesWave> ().size;	
		}
		print("hereeee" +TotalEnemiesInWaveSet);
		print (GameObject.FindGameObjectWithTag ("WaveManager").name);
		GameObject.FindGameObjectWithTag ("WaveManager").SendMessage ("setEnemyCount", TotalEnemiesInWaveSet);
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
			GameObject RandomWave =  Instantiate (waves[RandomWaves[i]], this.gameObject.transform.position, Quaternion.identity) as GameObject;
			RandomWave.gameObject.transform.position = new Vector3(direction,RandomWave.transform.position.y,RandomWave.transform.position.z);
			yield return new WaitForSeconds (TimeUntilNextWave);
		}
		yield return new WaitForSeconds (TimeUntilNextRoundOfWaves);
		Destroy(this.gameObject);
	}
	
	public int GetTotalEnemiesInSet(){
		return TotalEnemiesInWaveSet;
	}
	
}

