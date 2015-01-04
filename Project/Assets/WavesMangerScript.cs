using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WavesMangerScript : MonoBehaviour {

	public GameObject[] CreateWaves;
	private bool isGameOver;
	private Text BeforeWaveText;
	//public float[] TimeBeforeWaveInSec;
	public float timeUntilFirstWave;
	public float[] TimeBeforeNextRoundInSec;
	public float textTime;
	public int EnemiesCount = 0;
	public int [] countEnemiesInCreateWaves;

	// Use this for initialization
	void Start () {
		//countEnemiesInCreateWaves = new int[CreateWaves.Length];
		//for (int i= 0; i< CreateWaves.Length; i++) {
		//	countEnemiesInCreateWaves[i] = CreateWaves[i].gameObject.GetComponent<CreateEnemeyWaves>().GetTotalEnemiesInSet();
		//}

		BeforeWaveText = GameObject.FindGameObjectWithTag("MainTextWaves").GetComponent<Text>();
		StartCoroutine (StartGame ());
		BeforeWaveText.text = "Start Game";
	
	}
	
	IEnumerator StartGame ()
	{
		yield return new WaitForSeconds (timeUntilFirstWave);
		for (int i = 0; i < CreateWaves.Length; i++){
			BeforeWaveText.text = "Division #" +(i+1)+" is coming!";
			yield return new WaitForSeconds (textTime);
			BeforeWaveText.text = "";
			Instantiate (CreateWaves[i], this.transform.position, Quaternion.identity);
			yield return new WaitForSeconds (TimeBeforeNextRoundInSec[i]);//Delay before next round
		}
		BeforeWaveText.text = "You win";
	}

	public void decreaseEnemyCount(){
		EnemiesCount--;
		print("Enemies count is "+EnemiesCount);
	}
}
