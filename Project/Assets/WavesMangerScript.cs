using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WavesMangerScript : MonoBehaviour {

	public GameObject[] CreateWaves;
	private bool isGameOver;
	private Text BeforeWaveText;
	public float timeUntilFirstWave;
	public float TimeBeforeNextRoundInSec;
	public float textTime;
	public int EnemiesCount = 1;
	public int countEnemiesInCreateWaves;

	private int currentWave = 0;

	// Use this for initialization
	void Start () {
		BeforeWaveText = GameObject.FindGameObjectWithTag("MainTextWaves").GetComponent<Text>();
		BeforeWaveText.text = "Prepare";
		firstWave ();
	}

	private void firstWave(){
		StartCoroutine (CreateDivision ());
	}
	
	IEnumerator CreateDivision ()
	{
		yield return new WaitForSeconds (TimeBeforeNextRoundInSec);//Delay before next round
		BeforeWaveText.text = "Division #" +(currentWave+1)+" is coming!";
		yield return new WaitForSeconds (textTime);
		BeforeWaveText.text = "";
		Instantiate (CreateWaves[currentWave], this.transform.position, Quaternion.identity);
		EnemiesCount = CreateWaves[currentWave].gameObject.GetComponent<CreateEnemeyWaves>().GetTotalEnemiesInSet();
	}

	public void decreaseEnemyCount(){
			EnemiesCount--;
			print ("Enemies count is " + EnemiesCount);
			if (EnemiesCount == 0) {
				currentWave++;
				StartCoroutine (CreateDivision ());
			}
		}
}
