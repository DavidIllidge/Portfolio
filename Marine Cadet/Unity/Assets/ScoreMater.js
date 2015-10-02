static public var score: int = 0;
public var guiSkin : GUISkin;
public var guiSkin2 : GUISkin;
public var GUIScore : GUIText;


function Start () 
{

}

function addScore()
{
score+=10;
Destroy (gameObject);

}


function OnMouseDown()
{
addScore();
}

function Update()
{
	GUIScore.text = score.ToString();

}
/*function OnGUI()

{
GUI.skin = guiSkin;
GUI.Label( Rect(10,10,200,100),"Score: " + score);
}*/
