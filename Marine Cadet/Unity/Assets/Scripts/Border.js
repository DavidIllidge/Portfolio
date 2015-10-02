
private var currentToolTipText = "";
private var guiStyleFore : GUIStyle;
private var guiOn = false;
private var guiStyleBack : GUIStyle;
public var guiSkin : GUISkin;


 
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

function OnGUI()
{
	GUI.skin = guiSkin;
	GUI.Box (Rect (410,140,150,225), "");
	
}