using UnityEngine;
using System.Collections;

public class TimerGame1 : MonoBehaviour {
	public GUIText GUItimer;
	public GUIText GUIScore;
	public bool play = true;
	public int timer = 60;
	private Rect windowRect1 = new Rect (760, 390, 400, 300);
	public ScoreMaster ScoreScript;
	public EndGame2 endGame;
	public cameraForward cameraScript;
	// Use this for initialization
	void Start () {
		StartCoroutine("Timer");
		Time.timeScale = 1f;

		ScoreScript.score2 = 0;
		GUIScore.text = "0";
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (timer == 40)
			//cameraScript.zIncrement = 0.3f;
		//if (timer == 20)
			//cameraScript.zIncrement = 0.3f;
	}
	IEnumerator Timer()
	{
		yield return new WaitForSeconds(2);
		while (play == true)
		{
			yield return new WaitForSeconds(1);
			timer = timer - 1;
			GUItimer.text = timer.ToString();
			if (timer == 0)
			{
				cameraScript.pauseCamera = true;
				endGame.endGame = true;
				ScoreScript.click = false;
//				print ("Game Over");
//				print ("Final score = " + GameScript.Score);
				
			}
		}
		
	}
	void DoMyWindow1 (int windowID) 
	{
		Time.timeScale = 0f;
		//GUILayout.Space(8);
		GUILayout.BeginVertical();
		GUILayout.Label("Game over");
		GUILayout.Label("Score: " + ScoreScript.score2);
		GUILayout.Label("Can you do better?");
		if(GUILayout.Button ("Replay"))
		{

			Application.LoadLevel(Application.loadedLevel);
			//ScoreScript.score2 = 0;

		}
		if(GUILayout.Button ("Main Menu"))
			Application.LoadLevel("fishInstructionsScreen");
		GUILayout.EndVertical();
	}
	void OnGUI()
	{
		if(play == false)
		{
			
			windowRect1 = GUI.Window(1, windowRect1, DoMyWindow1, "");
			GUI.BeginGroup(new Rect(0, 0, 100, 100));
			GUI.EndGroup();
		}
	}
}
