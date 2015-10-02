private var guiOn = false;
private var guiStyleBack : GUIStyle;
public var guiSkin : GUISkin;
public var guiSkin2 : GUISkin;

public var bullet: int;
var bullets : int;

 
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
 
var mud1 : int = 0;
var mud2 : int = 0;
var mud3 : int = 0;
 
 
mud1 = PlayerPrefs.GetInt("mudClick1");
mud2 = PlayerPrefs.GetInt("mudClick2");
mud3 = PlayerPrefs.GetInt("mudClick3");


function Update()
{
	if ( mud1 == 1 && mud3 == 1 && mud2 == 1)
	{
						
	

	guiOn = true;

	//bullets += 10;

	}
}


function OnGUI()
{
//bullets;

					if (GUI.Button (Rect (50,350,250,25), "Press if youve cleaned the fish!"))
					{
						PlayerPrefs.DeleteAll();
					//	Application.LoadLevel(Application.loadedLevel);
						bullets += (10);

					}
					
					GUI.Label (Rect (50,500,100,40), "Score: " + bullets);

					 if (guiOn)
					{  

						//GUI.Box (Rect (410,140,150,225), "Fish Cleaned!!!");
							if (GUI.Button (Rect (50,250,120,25), "Delete player pref"))
							{
								PlayerPrefs.DeleteAll();

							}
				
					}
}










