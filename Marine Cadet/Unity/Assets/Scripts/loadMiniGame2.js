
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
	GUI.Box (Rect (860,220,150,245), "");

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (875,255,120,25), "Play Mini-Game"))
	{
		Application.LoadLevel (2);
	}

	// Make the second button.
	if (GUI.Button (Rect (870,285,130,25), "Game Instructions")) 
	{
		Application.LoadLevel (7);
	}
	
	
	GUI.Label (Rect (890,315,110,355), "The turtles of Morton Bay are threatened by an onslaught of littered water. Can you help guide the turtles back to the bay so they can lay their eggs?");
	GUI.skin = guiSkin;
	GUI.Label (Rect (870,225,150,190), "Litterd Reefs");
	
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