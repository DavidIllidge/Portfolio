function OnGUI()
{


 
	// Make a background box
	GUI.Box (Rect (510,240,150,245), "");

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (525,275,120,25), "Play Mini-Game"))
	{
		Application.LoadLevel (2);
	}

	// Make the second button.
	if (GUI.Button (Rect (520,305,130,25), "Game Instructions")) 
	{
		Application.LoadLevel (3);
	}
	
	
	GUI.Label (Rect (540,335,110,355), "The turtles of Morton Bay are threatened by an onslaught of littered water. Can you help guide the turtles back to the bay so they can lay their eggs?");
	//GUI.skin = guiSkin;
	GUI.Label (Rect (520,245,150,190), "Litterd Reefs");
}
