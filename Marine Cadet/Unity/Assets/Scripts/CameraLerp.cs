using UnityEngine;
using System.Collections;

public class CameraLerp : MonoBehaviour {

	private Vector3 newPositionCamera;
	private Vector3 newPositionWave;
	public GameObject Wave;
	public GameObject Fisherman1;
	public GameObject Fisherman2;
	public bool play = true;
	public int timer = 120;
	public GUIText GUItimer;
	public Game2Raycast GameScript;
	private Rect windowRect1 = new Rect (760, 390, 400, 300);
	public EndGame endGame;
	void Start () 
	{
		newPositionCamera = transform.position;
		newPositionWave = Wave.transform.position;
		StartCoroutine("WaitStart");
		StartCoroutine("Timer");
		Time.timeScale = 1f;
	}

	void Update () 
	{
		transform.position = Vector3.Lerp (transform.position, newPositionCamera, 0.5f * Time.deltaTime);
		Wave.transform.position = Vector3.Lerp (Wave.transform.position, newPositionWave, 0.5f * Time.deltaTime);
	}

	IEnumerator WaitStart()
	{
		yield return new WaitForSeconds(3);
		newPositionCamera = new Vector3(0.25f, -1.8f, -2.75f);

		newPositionWave = new Vector3 (-4.36f, -0.47f, 2.95f);

	}
	IEnumerator Timer()
	{
		yield return new WaitForSeconds(6);
		while (play == true)
		{
			yield return new WaitForSeconds(1);
			timer = timer - 1;
			GUItimer.text = timer.ToString();
			if (timer == 0)
			{
				//play = false;
				endGame.endGame = true;

				//print ("Game Over");
				//print ("Final score = " + GameScript.Score);

			}
		}
		
	}
	void DoMyWindow1 (int windowID) 
	{
		Time.timeScale = 0f;
		//GUILayout.Space(8);
		GUILayout.BeginVertical();
		GUILayout.Label("Game over");
		GUILayout.Label("Fish Remaining: " + GameScript.Score);
		GUILayout.Label("Can you do better?");
		if(GUILayout.Button ("Replay"))
			Application.LoadLevel(Application.loadedLevel);
		if(GUILayout.Button ("Main Menu"))
			Application.LoadLevel("somilia Instructions");
		GUILayout.EndVertical();
	}
	void OnGUI()
	{
		/*if(play == false)
		{

			windowRect1 = GUI.Window(1, windowRect1, DoMyWindow1, "");
			GUI.BeginGroup(new Rect(0, 0, 100, 100));
			GUI.EndGroup();
		}*/
	}
}
