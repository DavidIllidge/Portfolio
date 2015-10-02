private var startTime : float;
private var restSeconds : int;
private var roundedRestSeconds : int;
private var displaySeconds : int;
private var displayMinutes : int;
private var guiOn = false;
public var guiSkin : GUISkin;



 
var countDownSeconds : int;
var textTime : String; //added this member variable here so we can access it through other scripts
 
function Awake() 
{
    startTime = Time.timeSinceLevelLoad;
    Time.timeScale =1;
    var guiTime : float = (Time.timeSinceLevelLoad - 60) + startTime;
 
    restSeconds = countDownSeconds - (guiTime);
    
    //make sure that your time is based on when this script was first called
    //instead of when your game started
  
 
    //display messages or whatever here -->do stuff based on your timer
    if (restSeconds == 50)
     {
     	
        print ("One Minute Left");
    }
    if (restSeconds == 55) 
    {
        print ("Time is Over");
        guiOn = true;
        //do stuff here
    }
 
    //display the timer
    roundedRestSeconds = Mathf.CeilToInt(restSeconds);
    displaySeconds = roundedRestSeconds % 60;
    displayMinutes = roundedRestSeconds / 60; 
}
 
function OnGUI () {
    
 GUI.skin = guiSkin;

    textTime = String.Format ("{0:00}", displaySeconds); 
    GUI.Label(Rect(150,10,100,30),"Time: " +textTime);
    
    if (guiOn == true)
    
    {
    
    Time.timeScale =0;
    GUI.Label(Rect(Screen.width/2,(Screen.height/2)- 200,100,50),"Time Up!");
	if (GUI.Button(Rect((Screen.width/2)- 40,(Screen.height/2)- 100,120,40),"Play Again!"))
	{
	Application.LoadLevel(Application.loadedLevel);
	}
    if (GUI.Button(Rect((Screen.width/2) - 70,(Screen.height/2) -40,180,40),"Back to Menu!"))
    {
    	Application.LoadLevel(0);

    }
    
    }
    
}