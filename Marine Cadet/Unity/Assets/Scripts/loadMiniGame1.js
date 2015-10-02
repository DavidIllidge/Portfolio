
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

	GUI.Box (Rect (410,140,150,225), "");

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (425,170,120,25), "Play Mini-Game"))
	{
		Application.LoadLevel ("Minigame #1");
	}

	// Make the second button.
	if (GUI.Button (Rect (420,200,130,25), "Game Instructions")) 
	{
		Application.LoadLevel ("fishInstructionsScreen");
	}
	
	
	GUI.Label (Rect (430,230,110,145), "The deep sea BP oil spill is still affecting fish in the Gulf of Mexico. Can you help clean up the fish and stop them deplenishing?");
	GUI.skin = guiSkin;
	GUI.Label (Rect (420,140,150,290), "Clean the Fish");
	
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