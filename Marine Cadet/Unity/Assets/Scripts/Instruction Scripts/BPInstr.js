
private var guiStyleFore : GUIStyle;
private var guiOn = false;
private var guiStyleBack : GUIStyle;
public var guiSkin : GUISkin;
public var guiSkin2 : GUISkin;

function Start ()
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

function OnGUI () 
{
// Make a background box
	
	
	GUI.skin = guiSkin2;
	
	GUI.Label (Rect (770,230,732,115), "The BP oil spill is still affecting fish in the Gulf of Mexico. Can you help clean up as many fish as you can in the time limit you're given? Click over the waste on top of the fish and remove it completely to gain points for cleaning fish. Good Luck");
	GUI.Label (Rect (770,330,732,115)," Click 'Find out more' to find out about conservation projects in the Gulf of Mexico!");

GUI.skin = guiSkin;
	GUI.Box (Rect (50,50,1820,980), "");


}