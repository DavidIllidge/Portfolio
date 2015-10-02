
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
	
	GUI.Label (Rect (570,230,732,115), "The Reefs of Morton Bay have been filled with litter, can you help the Morton Bay turtles swim to saftey? Guide them home using the Arrow Keys, Good Luck!");
	GUI.Label (Rect (570,330,732,115)," Click 'Find out more' to find out about the Turtles of Morton Bay online!");

GUI.skin = guiSkin;
	GUI.Box (Rect (50,50,1265,505), "");


}