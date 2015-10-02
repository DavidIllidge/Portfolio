using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EndGame2 : BaseMenuState 
{
	public bool endGame = false;
	//public string EndGameInfo;
	public string restartSTR = "Restart level";
	public string mainMenuSTR = "Main Menu";
	public float regularTimeScale = 1f;
	public int levelSceneIndex = 0;
	public string Score;
	public GUIText GUIScore;
	
	//the background texture
	public Texture backgroundTexture;
	
	public override void Awake(){
		base.Awake();
		transform.position = startPos;
	}
	
	public void Update()
		
	{
		if (endGame == true)
		{
			Score = GUIScore.text;
			MenuStateManager.enterStateUsingName(	m_stateID);		
			Time.timeScale=0;
		}
	}
	public override void onGUI()
	{
		
		float offsetX = transform.position.x;
		float offsetY = transform.position.y;
		
		if(backgroundTexture)
		{
			GUI.DrawTexture( GUIHelper.screenRect(0,0,1,1),backgroundTexture);
		}
		GUI.skin = guiSkin0;
		//draw a button which will increase the graphics quality
		GUI.Label(GUIHelper.screenRect (offsetX+0.448f,.25f,.3f,.1f),
		          ("\nScore: " + Score + "\n\nCan you do better?"));	
		/*{
			MenuStateManager.enterStateUsingGameObject(null);			
//			unapuseGame();
			//load the first level.
			Application.LoadLevel(Application.loadedLevel);
		}*/
		
		//draw a button that will decrease the graphics quality
		if(addButton(GUIHelper.screenRect (offsetX+0.35f,offsetY + 0.4f,.3f,.1f),
		             restartSTR))			
		{
			MenuStateManager.enterStateUsingGameObject(null);
			Application.LoadLevel(Application.loadedLevel);
			//		unapuseGame();
		}
		
		if(addButton(GUIHelper.screenRect (offsetX+0.35f,offsetY + 0.55f,.3f,.1f),
		             mainMenuSTR))		
		{
			MenuStateManager.enterStateUsingGameObject(null);
			//	unapuseGame();
			//load the first level.
			Application.LoadLevel( "MainMenu_Scene" );
		}
		
	}	
}
