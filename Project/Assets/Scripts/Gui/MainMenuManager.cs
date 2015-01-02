using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
	public Image controlsPanel;					// The UI panel that shows the controls
	private bool fadeOutToBlack = false;		// Whether or not the UI is fading out to black
	private bool fadeIn = false;				// Whether or not the UI is fading in from black
	private bool isSoundOn=true;

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
	}

	// Start playing the game
	public void Play()
	{
		Application.LoadLevel(2);
	}

	// Quit the game
	public void Quit()
	{
		Application.Quit();
	}

	// Show/hide the controls UI element
	public void Controls()
	{
		if (!controlsPanel.gameObject.activeSelf)
		{
			controlsPanel.gameObject.SetActive(true);
		}
		else if (controlsPanel.gameObject.activeSelf)
		{
			controlsPanel.gameObject.SetActive(false);
		}
	}

	public void SoundOnOff()
	{
		if (isSoundOn) {
			AudioListener.volume = 0;
			isSoundOn=false;
		} else {
			AudioListener.volume = 1;
			isSoundOn=true;
		}
	}
}
