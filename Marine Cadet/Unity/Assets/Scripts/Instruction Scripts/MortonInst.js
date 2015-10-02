
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

			if (GUI.Button (Rect (570,450,125,50), "Play Game")) 
			{
				Application.LoadLevel (3);
			}

			if (GUI.Button (Rect (720,450,120,50), "Go Back")) 
			{
				Application.LoadLevel (0);
			}

			if (GUI.Button (Rect (870,450,190,50), "Find Out More...")) 
			{
				
			}
			
			GUI.Label(Rect(200,280,100,90),"Need Picture of Turtle");  // Remove this Line when image of turtle is on scene!

	}

}