using System;
using UnityEngine;

public class pause : MonoBehaviour
{
	bool paused = false;
	private Rect windowRect1 = new Rect (760, 390, 400, 300);
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			paused = togglePause();
	}

	
	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
	void DoMyWindow1 (int windowID) 
	{
		GUILayout.BeginVertical();
		GUILayout.Label("Paused");
		if(GUILayout.Button ("Continue"))
			paused = togglePause();
		if(GUILayout.Button ("Main Menu"))
			Application.LoadLevel("somilia Instructions");
		GUILayout.EndVertical();
	}
	void OnGUI()
	{
		if(paused)
		{
			
			windowRect1 = GUI.Window(1, windowRect1, DoMyWindow1, "");
			GUI.BeginGroup(new Rect(0, 0, 100, 100));
			GUI.EndGroup();
		}
	}
}