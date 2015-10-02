
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
	
	GUI.Label (Rect (770,230,732,115), "The fisherman are trying to illegally fish in Somalian Waters! It is your job to click the fishermans hooks and repell them from coming into contact with the fish! The more fish you save, the more points you will get! Good Luck!");
	GUI.Label (Rect (770,330,732,115)," Click 'Find out more' to find out about illegal fishing in Somalia online!");

GUI.skin = guiSkin;
	GUI.Box (Rect (50,50,1820,980), "");


}