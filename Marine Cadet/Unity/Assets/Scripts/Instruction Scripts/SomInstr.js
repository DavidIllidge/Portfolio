
public var guiSkin1 : GUISkin;
public var guiSkin2 : GUISkin;
public var guiOn = true;


function Start()
{
}
function OnGUI()
{



	if(guiOn == true)
	{
		GUI.skin = guiSkin1;

			if (GUI.Button (Rect(770,450,125,50), "Play Game")) 
			{
				Application.LoadLevel ("Minigame #2");
			}

			if (GUI.Button (Rect (920,450,120,50), "Go Back")) 
			{
				Application.LoadLevel ("MainMenu_Scene");
			}

			if (GUI.Button (Rect (1070,450,190,50), "Find Out More...")) 
			{
				Application.OpenURL ("http://www.hiiraan.com/news4/2013/July/30548/gcc_businessmen_supporting_illegal_fishing_in_somalia_un.aspx");
			}

	}

}