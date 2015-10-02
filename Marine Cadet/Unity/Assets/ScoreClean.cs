using UnityEngine;
using System.Collections;


public class ScoreClean : MonoBehaviour
{
	public double score = 0;					// The player's score.
	public bool  guiOn = false;
	public bool  guiOn2 = false;
	public bool  guiOn3 = false;
	public GUISkin _Skin = null;
	public GUISkin _Skin2 = null;
	//private PlayerControl playerControl;		// Reference to the player control script.
	private double previousScore = 0;			// The score in the previous frame.
	//private PlayerHealth playerHealth;
	
	
	
	void Awake ()
	{
		// Setting up the reference.
	//	playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	//	playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		
	}
	
	void Update ()
	{
		// Set the score text.
		guiText.text = "Score: " + score;
		
		// If the score has changed...
		if(previousScore != score)
			// ... play a taunt.
		//	playerControl.StartCoroutine(playerControl.Taunt());
		
		// Set the previous score to this frame's score.
		previousScore = score;
		
		

		
		
		
		if(  score > 1913 && score < 1915)		//	Level 1
		{	
			guiOn2 = true;
			
			PlayerPrefs.SetInt("SavedLevel1", 1);
			Time.timeScale = 0; 
		}
		if(  score > 1917 && score < 1919)		// Level 2
		{	
			guiOn2 = true;
			
			PlayerPrefs.SetInt("SavedLevel2", 1);
			Time.timeScale = 0; 
		}
		if(  score > 1927 && score < 1929)		//	Level 5
		{	
			guiOn2 = true;
			
			PlayerPrefs.SetInt("SavedLevel5", 1);
			Time.timeScale = 0; 
		}
		if(  score > 19.14 && score < 19.15)		// Level 6
		{	
			guiOn2 = true;
			
			PlayerPrefs.SetInt("SavedLevel6", 1);
			Time.timeScale = 0; 
		}
		if(  score > 1937 && score < 1939)		//	Level 9
		{	
			guiOn2 = true;
			
			PlayerPrefs.SetInt("SavedLevel9", 1);
			Time.timeScale = 0; 
		}
		if(  score > 19145 && score < 19147)		//	Level 10
		{	
			guiOn3 = true;
			
			PlayerPrefs.SetInt("SavedLevel10", 1);
			Time.timeScale = 0; 
		}
		
	
		
		
		
	}
	
	
	public void OnGUI() 
	{
		if (guiOn == true)
		{
			
			if (_Skin != null)
				
			{
				GUI.skin = _Skin;
				
			}
			
			if (GUI.Button( new Rect(570, 200, 200, 50), "Try Again"))
			{
				PlayerPrefs.SetInt("Death", (PlayerPrefs.GetInt("Death")+1));
				Application.LoadLevel(Application.loadedLevel);
			}
			
			if (GUI.Button( new Rect(505, 270, 350, 50), "Select Another Level"))
			{
				PlayerPrefs.SetInt("Death", (PlayerPrefs.GetInt("Death")+1));
				Application.LoadLevel (2);
			}
			GUI.color = Color.red;
			
			GUI.Label (new Rect (585, 120, 200, 90), "Game Over!");
			
			Time.timeScale = 0;
		}
		
		
		if (guiOn2 == true)
		{
			
			if (_Skin2 != null)
				
			{
				GUI.skin = _Skin2;
				
			}
			
			if (GUI.Button( new Rect(530, 230, 295, 50), "Choose Next Level"))
			{
				Application.LoadLevel (2);
			}
			
			
			GUI.color = Color.red;
			
			GUI.Label (new Rect (560, 120, 300, 90), "Level Complete!");
			Time.timeScale = 0;
		}
		if (guiOn3 == true)
		{
			
			if (_Skin2 != null)
				
			{
				GUI.skin = _Skin2;
				
			}
			
			if (GUI.Button( new Rect(450, 230, 330, 50), "Go to End Screen"))
			{
				Application.LoadLevel (16);
			}
			
			
			GUI.color = Color.red;
			
			GUI.Label (new Rect (400, 120, 600, 90), "You have completed the game!");
			Time.timeScale = 0;
		}
		
		
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}









