//C#
using UnityEngine;
using System.Collections;

public class startGUI : MonoBehaviour {


    bool doWindow0 = true;
    private Rect windowRect0 = new Rect(660, 200, 600, 500);
    public GUISkin mySkin;
    void DoMyWindow0(int windowID)
    {
        // use the spike function to add the spikes
        // note: were passing the width of the window to the function
        //AddSpikes(windowRect0.width);

        GUILayout.BeginVertical();
        GUILayout.Space(40);
        //GUILayout.Label("", "Divider");//-------------------------------- custom
        GUILayout.Space(40);
        if(GUILayout.Button("Start"))
        {
            Application.LoadLevel("Player1UnitSelection");
        }
        GUILayout.Space(40);
        GUILayout.Label("", "Divider");//-------------------------------- custom
        GUILayout.Space(40);
        GUILayout.Button("Instructions");
        {
            //Application.LoadLevel("Player1UnitSelection");
        }
        GUILayout.Space(40);
        GUILayout.Label("", "Divider");//-------------------------------- custom
        GUILayout.Space(40);
        if(GUILayout.Button("Exit"))
        {
            Application.Quit();
        }
        GUILayout.EndVertical();

        // Make the windows be draggable.
        //GUI.DragWindow (Rect (0,0,10000,10000));
    }
    
    
    void OnGUI () {
        GUI.skin = mySkin;

        if (doWindow0)
            windowRect0 = GUI.Window(0, windowRect0, DoMyWindow0, "");
        //now adjust to the group. (0,0) is the topleft corner of the group.
        GUI.BeginGroup(new Rect(0, 0, 100, 100));
        // End the group we started above. This is very important to remember!
        GUI.EndGroup();

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        //if(GUI.Button(new Rect(700,290,520,113), "Start")) {
        //    Application.LoadLevel("Player1UnitSelection");
        //}
		
        //// Make the second button.
        //if(GUI.Button(new Rect(700,443,520,113), "Instructions")) {
        //    //Application.LoadLevel(2);
        //}

        //// Make the third button.
        //if(GUI.Button(new Rect(700,596,520,113), "Exit")) {
        //    //Application.LoadLevel(2);
        //}






	}
}