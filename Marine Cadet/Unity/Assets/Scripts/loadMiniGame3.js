
 var text = "Run forest ";
private var currentToolTipText = "";
private var guiStyleFore : GUIStyle;
private var guiOn = false;
private var guiStyleBack : GUIStyle;
public var guiSkin : GUISkin;
public var guiSkin2 : GUISkin;

 
function Start()
{

    guiStyleFore = new GUIStyle();
    guiStyleFore.normal.textColor = Color.white;  
    guiStyleFore.alignment = TextAnchor.UpperCenter ;
    guiStyleFore.wordWrap = true;
    guiStyleBack = new GUIStyle();
    guiStyleBack.normal.textColor = Color.black;  
    guiStyleBack.alignment = TextAnchor.UpperCenter ;
    guiStyleBack.wordWrap = true;
}
 
function OnMouseEnter ()
{
 	renderer.material.color = Color.red;
    currentToolTipText = text;
    
}


 
function OnMouseExit ()
{
    currentToolTipText = "";
    renderer.material.color = Color.white;
   
}

function OnMouseDown () 
     {
   		  guiOn = true; 
   		  
  			
  		  yield WaitForSeconds(6.5);
    	  guiOn = false;

	 }


function OnGUI()
{

 if (guiOn)
{  
	// Make a background box
	GUI.Box (Rect (640,310,150,205), "");

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (655,345,120,25), "Play Mini-Game"))
	{
		Application.LoadLevel ("Minigame #2");
	}

	// Make the second button.
	if (GUI.Button (Rect (650,375,130,25), "Game Instructions")) 
	{
		Application.LoadLevel ("somilia Instructions");
	}
	
	
	GUI.Label (Rect (660,405,110,125), "Illegal fishing is diminishing fish in Somalia. Can you save these fish from the fisherman?");
	GUI.skin = guiSkin;
	GUI.Label (Rect (650,315,150,190), "Illegal Fishing");
	
}

if (currentToolTipText != "")
    {
        var x = Event.current.mousePosition.x;
        var y = Event.current.mousePosition.y;
        GUI.skin = guiSkin2;
        GUI.Label (Rect (x-149,y+40,300,60), currentToolTipText, guiStyleBack);
        GUI.Label (Rect (x-150,y+40,300,60), currentToolTipText, guiStyleFore);
    }

    
}