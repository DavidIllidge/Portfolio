using UnityEngine;
using System.Collections;

public class BoardGUI : MonoBehaviour {
	public int PlayersTurn;
	public MovePiece MovePiece;
	public SpawnCharacter SpawnCharacter;
	public string UnitName;
	public int UnitHealth;
	public int UnitDamage;
	public int UnitMovement;
	public int UnitAttackDistance;
	public bool UnitSelected = false;
	private Rect windowRect1 = new Rect(1600, 20, 300, 600);
	private Rect windowRect2 = new Rect(1600, 570, 300, 350);
	private Rect windowRect3 = new Rect(1600, 570, 300, 350);
	bool doWindow1 = true;
	bool doWindow2 = true;
	public bool doWindow3 = false;
	public string player1command1;
	public string player1command2;
	public string player1command3;
	public string player1command4;
	public string player2command1;
	public string player2command2;
	public string player2command3;
	public string player2command4;
	public int player1command1value;
	public int player1command2value;
	public int player1command3value;
	public int player1command4value;
	public int player2command1value;
	public int player2command2value;
	public int player2command3value;
	public int player2command4value;
	public GUISkin mySkin;
	public bool myIdol = false;
	public GUIText GUIVictory;
	public GUIText GUIPlayer;
	public GUITexture GameOver;
	int playerVictory = 0;
	// Use this for initialization

	void DoMyWindow1 (int windowID) 
	{
		
		GUILayout.Space(8);
		GUILayout.BeginVertical();
		GUILayout.Label("Unit Information");
		GUILayout.Label ("", "Divider");
		if ((UnitSelected == true)&&(UnitHealth > 0))
		{
			GUILayout.TextArea("Player's Unit: " + PlayersTurn.ToString());
			GUILayout.TextArea("Unit Name: " + UnitName.ToString());
			GUILayout.TextArea("Health: " + UnitHealth.ToString());
			if (UnitName != "Idol")
			{
				GUILayout.TextArea("Damage: " + UnitDamage.ToString());
				GUILayout.TextArea("Movement: " + UnitMovement.ToString());
				GUILayout.TextArea("Attack Distance: " + UnitAttackDistance.ToString());


			}
			else
			{
				if (myIdol == true)
				{

				GUILayout.Label ("", "Divider");
				if(GUILayout.Button("Archer"))
						SpawnCharacter.Unit = 2;
				if(GUILayout.Button("Foot Soldier"))
					SpawnCharacter.Unit = 3;
				if(GUILayout.Button("Pharaoh"))
					SpawnCharacter.Unit = 1;
				if(GUILayout.Button("Priest"))
					SpawnCharacter.Unit = 4;
				if(GUILayout.Button("Royal Guard"))
					SpawnCharacter.Unit = 5;
				if(GUILayout.Button("Slinger"))
					SpawnCharacter.Unit = 6;
				if(GUILayout.Button("Spearman"))
					SpawnCharacter.Unit = 7;
				SpawnCharacter.ForceIdolSelected = true;
				}
			}
		}

		GUILayout.EndVertical ();
	}
	void DoMyWindow2 (int windowID) 
	{
		if (MovePiece.playersTurn == 1)
		{
			GUILayout.Space(8);
			GUILayout.BeginVertical();
			GUILayout.Label("Faith Commands");
			GUILayout.Label ("", "Divider");
			if (player1command1 != "")
			{
				if(GUILayout.Button(player1command1))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player1command1value;
					}
					else
					{
					print ("Player 1 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			if (player1command2 != "")
			{
				if(GUILayout.Button(player1command2))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player1command2value;
					}
					else
					{
						print ("Player 1 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			if (player1command3 != "")
			{
				if(GUILayout.Button(player1command3))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player1command3value;
					}
					else
					{
						print ("Player 1 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			if (player1command4 != "")
			{
				if(GUILayout.Button(player1command4))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player1command4value;
					}
					else
					{
						print ("Player 1 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			GUILayout.EndVertical ();
		}	
		if (MovePiece.playersTurn == 2)
		{
			GUILayout.Space(8);
			GUILayout.BeginVertical();
			GUILayout.Label("Faith Commands");
			GUILayout.Label ("", "Divider");
			if (player2command1 != "")
			{
				if(GUILayout.Button(player2command1))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player2command1value;
					}
					else
					{
						print ("Player 2 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			if (player2command2 != "")
			{
				if(GUILayout.Button(player2command2))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player2command2value;
					}
					else
					{
						print ("Player 2 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			if (player2command3 != "")
			{
				if(GUILayout.Button(player2command3))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player2command3value;
					}
					else
					{
						print ("Player 2 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			if (player2command4 != "")
			{
				if(GUILayout.Button(player2command4))
				{
					if (FindPriest(MovePiece.playersTurn) == true)
					{
						MovePiece.abilitySelected = player2command4value;
					}
					else
					{
						print ("Player 2 does not own a Priest and therefore can't use any faith commands.");
					}
				}
			}
			GUILayout.EndVertical ();
		}
	}
	void DoMyWindow3 () 
	{
		GUIVictory.active = true;
		GUIPlayer.active = true;
		GameOver.active = true;

		GUIPlayer.text = ("Player " + playerVictory.ToString());
		Time.timeScale = 0;		
		if (GUI.Button (new Rect (820, 640, 150, 31), "Return to Main Menu", "ShortButton")) 
		{
			Time.timeScale = 1;
			Application.LoadLevel("StartScene");
		}

	}
	void OnGUI()
	{
	GUI.skin = mySkin;

	if (doWindow1)
		windowRect1 = GUI.Window(1, windowRect1, DoMyWindow1, "");
	GUI.BeginGroup(new Rect(0, 0, 100, 100));
	GUI.EndGroup();
		if (GUI.Button(new Rect(50, 50, 95, 40), "Next Turn", "ShortButton"))
		
		    MovePiece.nextTurn = true;

		if (doWindow2)
			windowRect2 = GUI.Window(2, windowRect2, DoMyWindow2, "");
		GUI.BeginGroup(new Rect(0, 0, 100, 100));
		GUI.EndGroup();

		if (doWindow3)
		{
			DoMyWindow3();
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerVictory = checkIdolHealth ();
		if (playerVictory != 0)
			doWindow3 = true;

	}
	bool FindPriest(int playersTurn) 
	{
		bool ValidPriest = false;
		var gos = GameObject.FindGameObjectsWithTag("UnitPriest");
		foreach (GameObject go in gos) 
		{
			if (go.GetComponent<Priest>().PlayerNumber == playersTurn)
				ValidPriest = true;
			
		}
		return ValidPriest;
	}
	int checkIdolHealth() 
	{
		int playerVictory = 0;
		var gos = GameObject.FindGameObjectsWithTag("Idol");
		foreach (GameObject go in gos) 
		{
			if (go.GetComponent<Idol>().Health <= 0)
			{
				if(go.GetComponent<Idol>().PlayerNumber == 1)
					playerVictory = 2;
				if(go.GetComponent<Idol>().PlayerNumber == 2)
					playerVictory = 1;
			}
		}
		return playerVictory;
	}

}