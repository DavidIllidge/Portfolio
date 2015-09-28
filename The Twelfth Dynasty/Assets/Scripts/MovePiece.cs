using UnityEngine;
using System.Collections;

public class MovePiece : MonoBehaviour {

	public BoardGUI BoardGUI;
	public GameObject UnitSelected;
	public GameObject UnitTargeted;
	public int UnitSelectedPlayerNumber;
	public int UnitTargetPlayerNumber;
	public bool Selected = false;
	public int UnitMovementDistance;
	public int UnitAttackDistance;
	public int UnitTargetAttackDistance;
	public int UnitAttackDamage;
	public int turnTimer;
	public GUIText GUITurnTimer;
	public GUIText GUIPlayerTurn;
	public GUIText GUIFaith;
	Vector3 UnitSelectedPosition;
	Vector3 TileSelectedPosition;
	bool moved = false;
	bool attacked = false;
	public int playersTurn = 1;
	public bool nextTurn = false;

	public int faith1 = 0;
	public int faith2 = 0;
	public int abilitySelected = 0;
	public GameObject UnitBuffed;
	public bool Ankh1 = false;
	public bool Ankh2 = false;
	public bool KnotOfIsis1 = false;
	public bool KnotOfIsis2 = false;

	public bool Player1Ankh = false;
	public bool Player1KnotOfIsis = false;
	public bool Player1Charge = false;
	public bool Player1PowerOfApep = false;
	public bool Player1EyeOfHorus = false;
	public bool Player1Smite = false;
	public bool Player1BookOfThroth = false;

	public bool Player2Ankh = false;
	public bool Player2KnotOfIsis = false;
	public bool Player2Charge = false;
	public bool Player2PowerOfApep = false;
	public bool Player2EyeOfHorus = false;
	public bool Player2Smite = false;
	public bool Player2BookOfThroth = false;
	void Start () 
	{
		turnTimer = 60;
		print ("player 1's turn");

		var gos = GameObject.FindGameObjectsWithTag("KeepOnLoad");
		
		foreach (GameObject go in gos) {
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Ankh") {
								Player1Ankh = true;
				BoardGUI.player1command1 = "Ankh";
				BoardGUI.player1command1value = 1;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Knot Of Isis") {
								Player1KnotOfIsis = true;
				BoardGUI.player1command1 = "Knot Of Isis";
				BoardGUI.player1command1value = 2;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Charge") {
								Player1Charge = true;
				BoardGUI.player1command1 = "Charge";
				BoardGUI.player1command1value = 3;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Power Of Apep") {
								Player1PowerOfApep = true;
				BoardGUI.player1command1 = "Power Of Apep";
				BoardGUI.player1command1value = 4;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Eye Of Horus") {
								Player1EyeOfHorus = true;
				BoardGUI.player1command1 = "Eye Of Horus";
				BoardGUI.player1command1value = 6;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Smite") {
								Player1Smite = true;
				BoardGUI.player1command1 = "Smite";
				BoardGUI.player1command1value = 5;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command1 == "Book Of Throth") {
								Player1BookOfThroth = true;
				BoardGUI.player1command1 = "Book Of Throth";
				BoardGUI.player1command1value = 7;
						}

						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Ankh") {
								Player1Ankh = true;
				BoardGUI.player1command2 = "Ankh";
				BoardGUI.player1command2value = 1;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Knot Of Isis") {
								Player1KnotOfIsis = true;
				BoardGUI.player1command2 = "Knot Of Isis";
				BoardGUI.player1command2value = 2;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Charge") {
								Player1Charge = true;
				BoardGUI.player1command2 = "Charge";
				BoardGUI.player1command2value = 3;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Power Of Apep") {
								Player1PowerOfApep = true;
				BoardGUI.player1command2 = "Power Of Apep";
				BoardGUI.player1command2value = 4;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Eye Of Horus") {
								Player1EyeOfHorus = true;
				BoardGUI.player1command2 = "Eye Of Horus";
				BoardGUI.player1command2value = 6;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Smite") {
								Player1Smite = true;
				BoardGUI.player1command2 = "Smite";
				BoardGUI.player1command2value = 5;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command2 == "Book Of Throth") {
								Player1BookOfThroth = true;
				BoardGUI.player1command2 = "Book Of Throth";
				BoardGUI.player1command2value = 7;
						}

						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Ankh") {
								Player1Ankh = true;
				BoardGUI.player1command3 = "Ankh";
				BoardGUI.player1command3value = 1;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Knot Of Isis") {
								Player1KnotOfIsis = true;
				BoardGUI.player1command3 = "Knot Of Isis";
				BoardGUI.player1command3value = 2;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Charge") {
								Player1Charge = true;
				BoardGUI.player1command3 = "Charge";
				BoardGUI.player1command3value = 3;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Power Of Apep") {
								Player1PowerOfApep = true;
				BoardGUI.player1command3 = "Power Of Apep";
				BoardGUI.player1command3value = 4;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Eye Of Horus") {
								Player1EyeOfHorus = true;
				BoardGUI.player1command3 = "Eye Of Horus";
				BoardGUI.player1command3value = 6;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Smite") {
								Player1Smite = true;
				BoardGUI.player1command3 = "Smite";
				BoardGUI.player1command3value = 5;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command3 == "Book Of Throth") {
								Player1BookOfThroth = true;
				BoardGUI.player1command3 = "Book Of Throth";
				BoardGUI.player1command3value = 7;
						}

						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Ankh") {
								Player1Ankh = true;
				BoardGUI.player1command4 = "Ankh";
				BoardGUI.player1command4value = 1;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Knot Of Isis") {
								Player1KnotOfIsis = true;
				BoardGUI.player1command4 = "Knot Of Isis";
				BoardGUI.player1command4value = 2;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Charge") {
								Player1Charge = true;
				BoardGUI.player1command4 = "Charge";
				BoardGUI.player1command4value = 3;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Power Of Apep") {
								Player1PowerOfApep = true;
				BoardGUI.player1command4 = "Power Of Apep";
				BoardGUI.player1command4value = 4;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Eye Of Horus") {
								Player1EyeOfHorus = true;
				BoardGUI.player1command4 = "Eye Of Horus";
				BoardGUI.player1command4value = 6;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Smite") {
								Player1Smite = true;
				BoardGUI.player1command4 = "Smite";
				BoardGUI.player1command4value = 5;
						}
						if (go.GetComponent<KeepOnLoadPlayer1> ().Command4 == "Book Of Throth") {
								Player1BookOfThroth = true;
				BoardGUI.player1command4 = "Book Of Throth";
				BoardGUI.player1command4value = 7;
						}
				}
		var gos2 = GameObject.FindGameObjectsWithTag("KeepOnLoad2");
		
		foreach (GameObject go in gos2) {
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Ankh") {
				Player2Ankh = true;
				BoardGUI.player2command1 = "Ankh";
				BoardGUI.player2command1value = 1;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Knot Of Isis") {
				Player2KnotOfIsis = true;
				BoardGUI.player2command1 = "Knot Of Isis";
				BoardGUI.player2command1value = 2;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Charge") {
				Player2Charge = true;
				BoardGUI.player2command1 = "Charge";
				BoardGUI.player2command1value = 3;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Power Of Apep") {
				Player2PowerOfApep = true;
				BoardGUI.player2command1 = "Power Of Apep";
				BoardGUI.player2command1value = 4;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Eye Of Horus") {
				Player2EyeOfHorus = true;
				BoardGUI.player2command1 = "Eye Of Horus";
				BoardGUI.player2command1value = 6;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Smite") {
				Player2Smite = true;
				BoardGUI.player2command1 = "Smite";
				BoardGUI.player2command1value = 5;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command1 == "Book Of Throth") {
				Player2BookOfThroth = true;
				BoardGUI.player2command1 = "Book Of Throth";
				BoardGUI.player2command1value = 7;
			}
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Ankh") {
				Player2Ankh = true;
				BoardGUI.player2command2 = "Ankh";
				BoardGUI.player2command2value = 1;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Knot Of Isis") {
				Player2KnotOfIsis = true;
				BoardGUI.player2command2 = "Knot Of Isis";
				BoardGUI.player2command2value = 2;

			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Charge") {
				Player2Charge = true;
				BoardGUI.player2command2 = "Charge";
				BoardGUI.player2command2value = 3;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Power Of Apep") {
				Player2PowerOfApep = true;
				BoardGUI.player2command2 = "Power Of Apep";
				BoardGUI.player2command2value = 4;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Eye Of Horus") {
				Player2EyeOfHorus = true;
				BoardGUI.player2command2 = "Eye Of Horus";
				BoardGUI.player2command2value = 6;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Smite") {
				Player2Smite = true;
				BoardGUI.player2command2 = "Smite";
				BoardGUI.player2command2value = 5;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command2 == "Book Of Throth") {
				Player2BookOfThroth = true;
				BoardGUI.player2command2 = "Book Of Throth";
				BoardGUI.player2command2value = 7;
			}
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Ankh") {
				Player2Ankh = true;
				BoardGUI.player2command3 = "Ankh";
				BoardGUI.player2command3value = 1;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Knot Of Isis") {
				Player2KnotOfIsis = true;
				BoardGUI.player2command3 = "Knot Of Isis";
				BoardGUI.player2command3value = 2;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Charge") {
				Player2Charge = true;
				BoardGUI.player2command3 = "Charge";
				BoardGUI.player2command3value = 3;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Power Of Apep") {
				Player2PowerOfApep = true;
				BoardGUI.player2command3 = "Power Of Apep";
				BoardGUI.player2command3value = 4;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Eye Of Horus") {
				Player2EyeOfHorus = true;
				BoardGUI.player2command3 = "Eye Of Horus";
				BoardGUI.player2command3value = 6;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Smite") {
				Player2Smite = true;
				BoardGUI.player2command3 = "Smite";
				BoardGUI.player2command3value = 5;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command3 == "Book Of Throth") {
				Player2BookOfThroth = true;
				BoardGUI.player2command3 = "Book Of Throth";
				BoardGUI.player2command3value = 7;
			}
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Ankh") {
				Player2Ankh = true;
				BoardGUI.player2command4 = "Ankh";
				BoardGUI.player2command4value = 1;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Knot Of Isis") {
				Player2KnotOfIsis = true;
				BoardGUI.player2command4 = "Knot Of Isis";
				BoardGUI.player2command4value = 2;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Charge") {
				Player2Charge = true;
				BoardGUI.player2command4 = "Charge";
				BoardGUI.player2command4value = 3;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Power Of Apep") {
				Player2PowerOfApep = true;
				BoardGUI.player2command4 = "Power Of Apep";
				BoardGUI.player2command4value = 4;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Eye Of Horus") {
				Player2EyeOfHorus = true;
				BoardGUI.player2command4 = "Eye Of Horus";
				BoardGUI.player2command4value = 6;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Smite") {
				Player2Smite = true;
				BoardGUI.player2command4 = "Smite";
				BoardGUI.player2command4value = 5;
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Command4 == "Book Of Throth") {
				Player2BookOfThroth = true;
				BoardGUI.player2command4 = "Book Of Throth";
				BoardGUI.player2command4value = 7;
			}
		}
		StartCoroutine ("TurnTimerCountdown");
	}

	void Update () 
	{
		/*if (Input.GetKeyDown (KeyCode.F11)) {
						print (abilitySelected);
				}*/
		GUITurnTimer.text = turnTimer.ToString ();
		if (playersTurn == 1)
			GUIFaith.text = faith1.ToString();
		if (playersTurn == 2)
			GUIFaith.text = faith2.ToString();
		if (turnTimer < 0)
		{
			nextTurn = true;

		}

		if (nextTurn == true)
		{
			if (playersTurn == 1){
				playersTurn = 2; 
				GUIPlayerTurn.text = "Player 2";
				print ("player 2's turn");
				faith2 = faith2 + 25;
			}
			else{
				playersTurn = 1;
				GUIPlayerTurn.text = "Player 1";
				print ("player 1's turn");
				faith1 = faith1 + 25;
			}
			moved = false;
			attacked = false;
			UnitSelected = null;
			UnitTargeted = null;
			UnitSelectedPlayerNumber = 10;
			UnitTargetPlayerNumber = 10;
			Selected = false;
			turnTimer = 60;
			abilitySelected = 0;
			UpdatedUnitsHealth();
			nextTurn = false;
		}


		/*
		if (Input.GetKeyDown (KeyCode.F2)) 
		{
			if ((playersTurn == 1)&&(Player1Ankh == true))
			{
				if (FindPriest(playersTurn) == true)
				{
				abilitySelected = 1;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
			if ((playersTurn == 2)&&(Player2Ankh == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 1;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.F3)) 
		{
			if ((playersTurn == 1)&&(Player1KnotOfIsis == true))
			{
			if (FindPriest(playersTurn) == true)
			{
				abilitySelected = 2;
			}
			else
			{
				print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
				abilitySelected = 0;
			}
			}
			if ((playersTurn == 2)&&(Player2KnotOfIsis == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 2;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.F4)) 
		{
			if ((playersTurn == 1)&&(Player1Charge == true))
			{
			if (FindPriest(playersTurn) == true)
			{
				abilitySelected = 3;
			}
			else
			{
				print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
				abilitySelected = 0;
			}
			}
			if ((playersTurn == 2)&&(Player2Charge == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 3;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.F5)) 
		{
			if ((playersTurn == 1)&&(Player1PowerOfApep == true))
			{
			if (FindPriest(playersTurn) == true)
			{
				abilitySelected = 4;
			}
			else
			{
				print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
				abilitySelected = 0;
			}
			}
			if ((playersTurn == 2)&&(Player2PowerOfApep == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 4;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.F6)) 
		{
			if ((playersTurn == 1)&&(Player1Smite == true))
			{
			if (FindPriest(playersTurn) == true)
			{
				abilitySelected = 5;
			}
			else
			{
				print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
				abilitySelected = 0;
			}
			}
			if ((playersTurn == 2)&&(Player2Smite == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 5;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.F7)) 
		{
			if ((playersTurn == 1)&&(Player1EyeOfHorus == true))
			{
			if (FindPriest(playersTurn) == true)
			{
				abilitySelected = 6;
			}
			else
			{
				print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
				abilitySelected = 0;
			}
			}
			if ((playersTurn == 2)&&(Player2EyeOfHorus == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 6;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.F8)) 
		{
			if ((playersTurn == 1)&&(Player1BookOfThroth == true))
			{
			if (FindPriest(playersTurn) == true)
			{
				abilitySelected = 7;
			}
			else
			{
				print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
				abilitySelected = 0;
			}
			}
			if ((playersTurn == 2)&&(Player2BookOfThroth == true))
			{
				if (FindPriest(playersTurn) == true)
				{
					abilitySelected = 7;
				}
				else
				{
					print ("Player " + playersTurn + " does not own a Priest and therefore can't use any faith commands.");
					abilitySelected = 0;
				}
			}
		}

		*/
		if ((Selected == true)&&(UnitSelected != null))
		{
			UnitSelected.transform.position = Vector3.MoveTowards(UnitSelected.transform.position, TileSelectedPosition, 2*Time.deltaTime);
			//transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		}




		if (Input.GetMouseButtonDown(1))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{
					if (Selected == true)
					{
						if (moved == false)
						{
						if (hit.collider.tag == "Tile")
						{
							if (((UnitSelected.transform.position.x + UnitMovementDistance) >= (hit.collider.transform.position.x)) && ((UnitSelected.transform.position.x - UnitMovementDistance) <= (hit.collider.transform.position.x)))
							{
								if (((UnitSelected.transform.position.z + UnitMovementDistance) >= (hit.collider.transform.position.z)) && ((UnitSelected.transform.position.z - UnitMovementDistance) <= (hit.collider.transform.position.z)))
								{
									TileSelectedPosition = new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y + 0f, hit.collider.transform.position.z);
									moved = true;
										print ("Moved = true");
									if (UnitSelected.tag == "UnitPharaoh")
										UnitSelected.GetComponent<Pharaoh>().Moved = true;
									if (UnitSelected.tag == "UnitArcher")
										UnitSelected.GetComponent<Archer>().Moved = true;
									if (UnitSelected.tag == "UnitFootSoldier")
										UnitSelected.GetComponent<FootSoldier>().Moved = true;
									if (UnitSelected.tag == "UnitPriest")
										UnitSelected.GetComponent<Priest>().Moved = true;
									if (UnitSelected.tag == "UnitRoyalGuard")
										UnitSelected.GetComponent<RoyalGuard>().Moved = true;
									if (UnitSelected.tag == "UnitSlinger")
										UnitSelected.GetComponent<Slinger>().Moved = true;
									if (UnitSelected.tag == "UnitSpearman")
										UnitSelected.GetComponent<Spearman>().Moved = true;
								}
							}
						}
						}
						if (hit.collider.tag == "Idol")
						{
							if (attacked == false)
							{
								UnitTargeted = hit.collider.gameObject;
								UnitTargetPlayerNumber = UnitTargeted.GetComponent<Idol>().PlayerNumber;
								if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
								{
									if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
									{
										if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
										{
											UnitTargeted.GetComponent<Idol>().Health = UnitTargeted.GetComponent<Idol>().Health - UnitAttackDamage;
											attacked = true;
											print("attacked = true. Idol health = " + UnitTargeted.GetComponent<Idol>().Health);
											if (UnitTargeted.GetComponent<Idol>().Health <= 0)
											{
											Destroy (UnitTargeted.gameObject);
											print ("Game Over. Player " + playersTurn + " wins.");
											}
										}
									}
								}
							}
						}

						if (hit.collider.tag == "UnitPharaoh")
						{
							if (attacked == false)
							{
							UnitTargeted = hit.collider.gameObject;
							UnitTargetAttackDistance = UnitTargeted.GetComponent<Pharaoh>().AttackRange;
							UnitTargetPlayerNumber = UnitTargeted.GetComponent<Pharaoh>().PlayerNumber;

							if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
							{
								if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
								{
									if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
									{
										UnitTargeted.GetComponent<Pharaoh>().Health = UnitTargeted.GetComponent<Pharaoh>().Health - UnitAttackDamage;
										attacked = true;
											print("attacked = true. Pharaoh health = " + UnitTargeted.GetComponent<Pharaoh>().Health);
											if (UnitTargeted.GetComponent<Pharaoh>().Health > 0)

										{
											if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
											{
												if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
												{
													if (UnitSelected.tag == "UnitPharaoh"){
														UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;

													}
													if (UnitSelected.tag == "UnitArcher"){
														UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;
														
													}

													if (UnitSelected.tag == "UnitFootSoldier"){
														UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;
														
													}

													if (UnitSelected.tag == "UnitPriest"){
														UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;
														
													}

													if (UnitSelected.tag == "UnitRoyalGuard"){
														UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;
														
													}

													if (UnitSelected.tag == "UnitSlinger"){
														UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;
														
													}

													if (UnitSelected.tag == "UnitSpearman"){
														UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<Pharaoh>().Damage;
														
													}

												}
											}
										}
									}
								}
							}
							}
						}
						if (hit.collider.tag == "UnitArcher")
						{
							if (attacked == false)
							{
							UnitTargeted = hit.collider.gameObject;
							UnitTargetAttackDistance = UnitTargeted.GetComponent<Archer>().AttackRange;
							UnitTargetPlayerNumber = UnitTargeted.GetComponent<Archer>().PlayerNumber;
							
							if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
							{
								if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
								{
									if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
									{
										UnitTargeted.GetComponent<Archer>().Health = UnitTargeted.GetComponent<Archer>().Health - UnitAttackDamage;
											attacked = true;
											print("attacked = true. Archer health = " + UnitTargeted.GetComponent<Archer>().Health);
										if (UnitTargeted.GetComponent<Archer>().Health > 0)
											
										{
												if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
												{
													if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
												{
													if (UnitSelected.tag == "UnitPharaoh"){
														UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<Archer>().Damage;
												
													}
													if (UnitSelected.tag == "UnitArcher"){
														UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<Archer>().Damage;
												
													}
													
													if (UnitSelected.tag == "UnitFootSoldier"){
														UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<Archer>().Damage;
								
													}
													
													if (UnitSelected.tag == "UnitPriest"){
														UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<Archer>().Damage;
												
													}
													
													if (UnitSelected.tag == "UnitRoyalGuard"){
														UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<Archer>().Damage;
											
													}
													
													if (UnitSelected.tag == "UnitSlinger"){
														UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<Archer>().Damage;
												
													}
													
													if (UnitSelected.tag == "UnitSpearman"){
														UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<Archer>().Damage;
									
													}
													
												}
											}
										}
									}
								}
							}
							}
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (attacked == false)
							{
							UnitTargeted = hit.collider.gameObject;
							UnitTargetAttackDistance = UnitTargeted.GetComponent<FootSoldier>().AttackRange;
							UnitTargetPlayerNumber = UnitTargeted.GetComponent<FootSoldier>().PlayerNumber;
							
							if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
							{
								if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
								{
									if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
									{
										UnitTargeted.GetComponent<FootSoldier>().Health = UnitTargeted.GetComponent<FootSoldier>().Health - UnitAttackDamage;
											attacked = true;
											print("attacked = true. FootSoldier health = " + UnitTargeted.GetComponent<FootSoldier>().Health);
										if (UnitTargeted.GetComponent<FootSoldier>().Health > 0)
											
										{
												if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
												{
													if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
												{
													if (UnitSelected.tag == "UnitPharaoh"){
														UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
											
													}
													if (UnitSelected.tag == "UnitArcher"){
														UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
											
													}
													
													if (UnitSelected.tag == "UnitFootSoldier"){
														UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
												
													}
													
													if (UnitSelected.tag == "UnitPriest"){
														UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
													
													}
													
													if (UnitSelected.tag == "UnitRoyalGuard"){
														UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
													
													}
													
													if (UnitSelected.tag == "UnitSlinger"){
														UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
													
													}
													
													if (UnitSelected.tag == "UnitSpearman"){
														UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<FootSoldier>().Damage;
													
													}
													
												}
											}
										}
									}
								}
							}
							}
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (attacked == false)
							{
							UnitTargeted = hit.collider.gameObject;
							UnitTargetAttackDistance = UnitTargeted.GetComponent<Priest>().AttackRange;
							UnitTargetPlayerNumber = UnitTargeted.GetComponent<Priest>().PlayerNumber;
							
							if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
							{
								if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
								{
									if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
									{
										UnitTargeted.GetComponent<Priest>().Health = UnitTargeted.GetComponent<Priest>().Health - UnitAttackDamage;
											attacked = true;
											print("attacked = true. Priest health = " + UnitTargeted.GetComponent<Priest>().Health);
										if (UnitTargeted.GetComponent<Priest>().Health > 0)
										
										{
												if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
												{
													if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
												{
													if (UnitSelected.tag == "UnitPharaoh"){
														UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<Priest>().Damage;
													
													}
													if (UnitSelected.tag == "UnitArcher"){
														UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<Priest>().Damage;
													
													}
													
													if (UnitSelected.tag == "UnitFootSoldier"){
														UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<Priest>().Damage;
												
													}
													
													if (UnitSelected.tag == "UnitPriest"){
														UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<Priest>().Damage;
											
													}
													
													if (UnitSelected.tag == "UnitRoyalGuard"){
														UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<Priest>().Damage;
											
													}
													
													if (UnitSelected.tag == "UnitSlinger"){
														UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<Priest>().Damage;
													
													}
													
													if (UnitSelected.tag == "UnitSpearman"){
														UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<Priest>().Damage;
												
													}
													
												}
											}
										}
									}
								}
							}
							}
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (attacked == false)
							{
							UnitTargeted = hit.collider.gameObject;
							UnitTargetAttackDistance = UnitTargeted.GetComponent<RoyalGuard>().AttackRange;
							UnitTargetPlayerNumber = UnitTargeted.GetComponent<RoyalGuard>().PlayerNumber;
							
							if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
							{
								if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
								{
									if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
									{
										UnitTargeted.GetComponent<RoyalGuard>().Health = UnitTargeted.GetComponent<RoyalGuard>().Health - UnitAttackDamage;
											attacked = true;
											print("attacked = true. RoyalGuard health = " + UnitTargeted.GetComponent<RoyalGuard>().Health);
										if (UnitTargeted.GetComponent<RoyalGuard>().Health > 0)
		
										{
												if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
												{
													if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
												{
													if (UnitSelected.tag == "UnitPharaoh"){
														UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;
									
													}
													if (UnitSelected.tag == "UnitArcher"){
														UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;
						
													}
													
													if (UnitSelected.tag == "UnitFootSoldier"){
														UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;
				
													}
													
													if (UnitSelected.tag == "UnitPriest"){
														UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;
	
													}
													
													if (UnitSelected.tag == "UnitRoyalGuard"){
														UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;
	
													}
													
													if (UnitSelected.tag == "UnitSlinger"){
														UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;

													}
													
													if (UnitSelected.tag == "UnitSpearman"){
														UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<RoyalGuard>().Damage;

													}
													
												}
											}
										}
									}
								}
							}
							}
						}
			
					}
					if (hit.collider.tag == "UnitSlinger")
					{
						if (attacked == false)
						{
						UnitTargeted = hit.collider.gameObject;
						UnitTargetAttackDistance = UnitTargeted.GetComponent<Slinger>().AttackRange;
						UnitTargetPlayerNumber = UnitTargeted.GetComponent<Slinger>().PlayerNumber;
						
						if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
						{
							if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
							{
								if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
								{
									UnitTargeted.GetComponent<Slinger>().Health = UnitTargeted.GetComponent<Slinger>().Health - UnitAttackDamage;
										attacked = true;
										print("attacked = true. Slinger health = " + UnitTargeted.GetComponent<Slinger>().Health);
									if (UnitTargeted.GetComponent<Slinger>().Health > 0)

									{
											if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
											{
												if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
											{
												if (UnitSelected.tag == "UnitPharaoh"){
													UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												if (UnitSelected.tag == "UnitArcher"){
													UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												
												if (UnitSelected.tag == "UnitFootSoldier"){
													UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												
												if (UnitSelected.tag == "UnitPriest"){
													UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												
												if (UnitSelected.tag == "UnitRoyalGuard"){
													UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												
												if (UnitSelected.tag == "UnitSlinger"){
													UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												
												if (UnitSelected.tag == "UnitSpearman"){
													UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<Slinger>().Damage;

												}
												
											}
										}
									}
								}
							}
						}
						}
					}
					if (hit.collider.tag == "UnitSpearman")
					{
						if (attacked == false)
						{
						UnitTargeted = hit.collider.gameObject;
						UnitTargetAttackDistance = UnitTargeted.GetComponent<Spearman>().AttackRange;
						UnitTargetPlayerNumber = UnitTargeted.GetComponent<Spearman>().PlayerNumber;
						
						if (UnitSelectedPlayerNumber != UnitTargetPlayerNumber)
						{
							if (((UnitSelected.transform.position.x + UnitAttackDistance) >= (UnitTargeted.transform.position.x)) && ((UnitSelected.transform.position.x - UnitAttackDistance) <= (UnitTargeted.transform.position.x)))
							{
								if (((UnitSelected.transform.position.z + UnitAttackDistance) >= (UnitTargeted.transform.position.z)) && ((UnitSelected.transform.position.z - UnitAttackDistance) <= (UnitTargeted.transform.position.z)))
								{
									UnitTargeted.GetComponent<Spearman>().Health = UnitTargeted.GetComponent<Spearman>().Health - UnitAttackDamage;
										attacked = true;
										print("attacked = true. Spearman health = " + UnitTargeted.GetComponent<Spearman>().Health);
									if (UnitTargeted.GetComponent<Spearman>().Health > 0)

									{
											if (((UnitTargeted.transform.position.x + UnitTargetAttackDistance) >= (UnitSelected.transform.position.x)) && ((UnitTargeted.transform.position.x - UnitTargetAttackDistance) <= (UnitSelected.transform.position.x)))
											{
												if (((UnitTargeted.transform.position.z + UnitTargetAttackDistance) >= (UnitSelected.transform.position.z)) && ((UnitTargeted.transform.position.z - UnitTargetAttackDistance) <= (UnitSelected.transform.position.z)))
											{
												if (UnitSelected.tag == "UnitPharaoh"){
													UnitSelected.GetComponent<Pharaoh>().Health = UnitSelected.GetComponent<Pharaoh>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												if (UnitSelected.tag == "UnitArcher"){
													UnitSelected.GetComponent<Archer>().Health = UnitSelected.GetComponent<Archer>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												
												if (UnitSelected.tag == "UnitFootSoldier"){
													UnitSelected.GetComponent<FootSoldier>().Health = UnitSelected.GetComponent<FootSoldier>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												
												if (UnitSelected.tag == "UnitPriest"){
													UnitSelected.GetComponent<Priest>().Health = UnitSelected.GetComponent<Priest>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												
												if (UnitSelected.tag == "UnitRoyalGuard"){
													UnitSelected.GetComponent<RoyalGuard>().Health = UnitSelected.GetComponent<RoyalGuard>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												
												if (UnitSelected.tag == "UnitSlinger"){
													UnitSelected.GetComponent<Slinger>().Health = UnitSelected.GetComponent<Slinger>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												
												if (UnitSelected.tag == "UnitSpearman"){
													UnitSelected.GetComponent<Spearman>().Health = UnitSelected.GetComponent<Spearman>().Health - UnitTargeted.GetComponent<Spearman>().Damage;

												}
												
											}
										}
									}
								}
							}
						}
						}
					}



				}
			}
		}


		if (abilitySelected == 1)
		{
			if (playersTurn == 1)
			{
			    if (faith1 >= 75)
				{
				if(Ankh1 == false)
				{
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					if (hit.collider != null)
					{
						
						if (hit.collider.tag == "UnitPharaoh")
						{
							if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Pharaoh>().Damage = UnitBuffed.GetComponent<Pharaoh>().Damage + 200;
								UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().Health + 100;
								UnitBuffed.GetComponent<Pharaoh>().MaxHealth = UnitBuffed.GetComponent<Pharaoh>().MaxHealth + 100;
								print("Pharaoh gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Pharaoh>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
									abilitySelected = 0;
						}
						if (hit.collider.tag == "UnitArcher")
						{
							if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Archer>().Damage = UnitBuffed.GetComponent<Archer>().Damage + 200;
								UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().Health + 100;
								UnitBuffed.GetComponent<Archer>().MaxHealth = UnitBuffed.GetComponent<Archer>().MaxHealth + 100;
								print("Archer gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Archer>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
							abilitySelected = 0;
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<FootSoldier>().Damage = UnitBuffed.GetComponent<FootSoldier>().Damage + 200;
								UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health + 100;
								UnitBuffed.GetComponent<FootSoldier>().MaxHealth = UnitBuffed.GetComponent<FootSoldier>().MaxHealth + 100;
								print("FootSoldier gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<FootSoldier>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
									abilitySelected = 0;
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Priest>().Damage = UnitBuffed.GetComponent<Priest>().Damage + 200;
								UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health + 100;
								UnitBuffed.GetComponent<Priest>().MaxHealth = UnitBuffed.GetComponent<Priest>().MaxHealth + 100;
								print("Priest gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Priest>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
									abilitySelected = 0;
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<RoyalGuard>().Damage = UnitBuffed.GetComponent<RoyalGuard>().Damage + 200;
								UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health + 100;
								UnitBuffed.GetComponent<RoyalGuard>().MaxHealth = UnitBuffed.GetComponent<RoyalGuard>().MaxHealth + 100;
								print("RoyalGuard gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<RoyalGuard>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
									abilitySelected = 0;
						}
						if (hit.collider.tag == "UnitSlinger")
						{
							if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Slinger>().Damage = UnitBuffed.GetComponent<Slinger>().Damage + 200;
								UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health + 100;
								UnitBuffed.GetComponent<Slinger>().MaxHealth = UnitBuffed.GetComponent<Slinger>().MaxHealth + 100;
								print("Slinger gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Slinger>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
									abilitySelected = 0;
						}
						if (hit.collider.tag == "UnitSpearman")
						{
							if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Spearman>().Damage = UnitBuffed.GetComponent<Spearman>().Damage + 200;
								UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health + 100;
								UnitBuffed.GetComponent<Spearman>().MaxHealth = UnitBuffed.GetComponent<Spearman>().MaxHealth + 100;
								print("Spearman gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Spearman>().Ankh = true;
								Ankh1 = true;
								faith1 = faith1 - 75;
							}
									abilitySelected = 0;
						}
						
					}
					else
					{
						abilitySelected = 0;
					}
				}
			}
			}
			else
				{
				print ("Player 1 already has a unit infused with the power of the ankh");
				abilitySelected = 0;
				}
			}
			
				else{
				print ("Player 1 doesn't have enough faith to use Ankh.");
					abilitySelected = 0;
			}
			}
			if (playersTurn == 2)
			{
				if (faith2 >= 75)
				{
					if(Ankh2 == false)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Pharaoh>().Damage = UnitBuffed.GetComponent<Pharaoh>().Damage + 200;
										UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().Health + 100;
										UnitBuffed.GetComponent<Pharaoh>().MaxHealth = UnitBuffed.GetComponent<Pharaoh>().MaxHealth + 100;
										print("Pharaoh gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<Pharaoh>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Archer>().Damage = UnitBuffed.GetComponent<Archer>().Damage + 200;
										UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().Health + 100;
										UnitBuffed.GetComponent<Archer>().MaxHealth = UnitBuffed.GetComponent<Archer>().MaxHealth + 100;
										print("Archer gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<Archer>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<FootSoldier>().Damage = UnitBuffed.GetComponent<FootSoldier>().Damage + 200;
										UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health + 100;
										UnitBuffed.GetComponent<FootSoldier>().MaxHealth = UnitBuffed.GetComponent<FootSoldier>().MaxHealth + 100;
										print("FootSoldier gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<FootSoldier>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Priest>().Damage = UnitBuffed.GetComponent<Priest>().Damage + 200;
										UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health + 100;
										UnitBuffed.GetComponent<Priest>().MaxHealth = UnitBuffed.GetComponent<Priest>().MaxHealth + 100;
										print("Priest gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<Priest>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<RoyalGuard>().Damage = UnitBuffed.GetComponent<RoyalGuard>().Damage + 200;
										UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health + 100;
										UnitBuffed.GetComponent<RoyalGuard>().MaxHealth = UnitBuffed.GetComponent<RoyalGuard>().MaxHealth + 100;
										print("RoyalGuard gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<RoyalGuard>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Slinger>().Damage = UnitBuffed.GetComponent<Slinger>().Damage + 200;
										UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health + 100;
										UnitBuffed.GetComponent<Slinger>().MaxHealth = UnitBuffed.GetComponent<Slinger>().MaxHealth + 100;
										print("Slinger gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<Slinger>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Spearman>().Damage = UnitBuffed.GetComponent<Spearman>().Damage + 200;
										UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health + 100;
										UnitBuffed.GetComponent<Spearman>().MaxHealth = UnitBuffed.GetComponent<Spearman>().MaxHealth + 100;
										print("Spearman gained Ankh: 200 damage, 100 health");
										UnitBuffed.GetComponent<Spearman>().Ankh = true;
										Ankh2 = true;
										faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 2 already has a unit infused with the power of the ankh");
					abilitySelected = 0;
				}
				}
				else
				{
					print ("Player 2 doesn't have enough faith to use Ankh.");
					abilitySelected = 0;
				}
			}
		}

		if (abilitySelected == 2)
		{
			if (playersTurn == 1)
			{
				if (faith1 >= 75)
				{
				if(KnotOfIsis1 == false)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().Health + 400;
										UnitBuffed.GetComponent<Pharaoh>().MaxHealth = UnitBuffed.GetComponent<Pharaoh>().MaxHealth + 400;
										print("Pharaoh gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Pharaoh>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().Health + 400;
										UnitBuffed.GetComponent<Archer>().MaxHealth = UnitBuffed.GetComponent<Archer>().MaxHealth + 400;
										print("Archer gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Archer>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health + 400;
										UnitBuffed.GetComponent<FootSoldier>().MaxHealth = UnitBuffed.GetComponent<FootSoldier>().MaxHealth + 400;
										print("FootSoldier gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<FootSoldier>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health + 400;
										UnitBuffed.GetComponent<Priest>().MaxHealth = UnitBuffed.GetComponent<Priest>().MaxHealth + 400;
										print("Priest gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Priest>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health + 400;
										UnitBuffed.GetComponent<RoyalGuard>().MaxHealth = UnitBuffed.GetComponent<RoyalGuard>().MaxHealth + 400;
										print("RoyalGuard gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<RoyalGuard>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health + 400;
										UnitBuffed.GetComponent<Slinger>().MaxHealth = UnitBuffed.GetComponent<Slinger>().MaxHealth + 400;
										print("Slinger gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Slinger>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health + 400;
										UnitBuffed.GetComponent<Spearman>().MaxHealth = UnitBuffed.GetComponent<Spearman>().MaxHealth + 400;
										print("Spearman gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Spearman>().KnotOfIsis = true;
										KnotOfIsis1 = true;
											faith1 = faith1 - 75;
									}
									abilitySelected = 0;
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 1 already has a unit infused with the power of the Knot Of Isis");
					abilitySelected = 0;
				}
				}
				else
				{
					print ("Player 1 doesn't have enough faith to use Knot Of Isis.");
					abilitySelected = 0;
				}
			}
			if (playersTurn == 2)
			{
				if (faith2 >= 75)
				{
					if(KnotOfIsis2 == false)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().Health + 400;
										UnitBuffed.GetComponent<Pharaoh>().MaxHealth = UnitBuffed.GetComponent<Pharaoh>().MaxHealth + 400;
										print("Pharaoh gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Pharaoh>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().Health + 400;
										UnitBuffed.GetComponent<Archer>().MaxHealth = UnitBuffed.GetComponent<Archer>().MaxHealth + 400;
										print("Archer gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Archer>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health + 400;
										UnitBuffed.GetComponent<FootSoldier>().MaxHealth = UnitBuffed.GetComponent<FootSoldier>().MaxHealth + 400;
										print("FootSoldier gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<FootSoldier>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health + 400;
										UnitBuffed.GetComponent<Priest>().MaxHealth = UnitBuffed.GetComponent<Priest>().MaxHealth + 400;
										print("Priest gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Priest>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health + 400;
										UnitBuffed.GetComponent<RoyalGuard>().MaxHealth = UnitBuffed.GetComponent<RoyalGuard>().MaxHealth + 400;
										print("RoyalGuard gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<RoyalGuard>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health + 400;
										UnitBuffed.GetComponent<Slinger>().MaxHealth = UnitBuffed.GetComponent<Slinger>().MaxHealth + 400;
										print("Slinger gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Slinger>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health + 400;
										UnitBuffed.GetComponent<Spearman>().MaxHealth = UnitBuffed.GetComponent<Spearman>().MaxHealth + 400;
										print("Spearman gained Knot Of Isis: 400 health");
										UnitBuffed.GetComponent<Spearman>().KnotOfIsis = true;
										KnotOfIsis2 = true;
											faith2 = faith2 - 75;
									}
									abilitySelected = 0;
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 2 already has a unit infused with the power of the Knot Of Isis");
					abilitySelected = 0;
				}
			}
			else
			{
				print ("Player 2 doesn't have enough faith to use Knot Of Isis.");
					abilitySelected = 0;
			}
			}
		}

		if (abilitySelected == 3)
		{
			if (playersTurn == 1)
			{
				if (faith1 >= 75)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Pharaoh>().Charge == false)
										{
										UnitBuffed = hit.collider.gameObject;
										print("Pharaoh gained Charge: double movement");
										UnitBuffed.GetComponent<Pharaoh>().Charge = true;
											faith1 = faith1 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
								abilitySelected = 0;
									}
								}
						if (hit.collider.tag == "UnitArcher")
						{
							if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<Archer>().Charge == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("Archer gained Charge: double movement");
									UnitBuffed.GetComponent<Archer>().Charge = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be given Charge more than once.");
								}
								abilitySelected = 0;
							}
						}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
									{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().Charge == false)
									{
										UnitBuffed = hit.collider.gameObject;
										print("FootSoldier gained Charge: double movement");
									UnitBuffed.GetComponent<FootSoldier>().Charge = true;
											faith1 = faith1 - 75;
									}
									else
									{
										print ("Unit can't be given Charge more than once.");
									}
								abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
									{
								if (hit.collider.gameObject.GetComponent<Priest>().Charge == false)
									{
										UnitBuffed = hit.collider.gameObject;
									print("Priest gained Charge: double movement");
									UnitBuffed.GetComponent<Priest>().Charge = true;
											faith1 = faith1 - 75;
									}
									else
									{
										print ("Unit can't be given Charge more than once.");
									}
								abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
									{
								if (hit.collider.gameObject.GetComponent<RoyalGuard>().Charge == false)
									{
										UnitBuffed = hit.collider.gameObject;
									print("RoyalGuard gained Charge: double movement");
									UnitBuffed.GetComponent<RoyalGuard>().Charge = true;
											faith1 = faith1 - 75;
									}
									else
									{
										print ("Unit can't be given Charge more than once.");
									}
								abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
									{
								if (hit.collider.gameObject.GetComponent<Slinger>().Charge == false)
									{
										UnitBuffed = hit.collider.gameObject;
									print("Slinger gained Charge: double movement");
									UnitBuffed.GetComponent<Slinger>().Charge = true;
											faith1 = faith1 - 75;
									}
									else
									{
										print ("Unit can't be given Charge more than once.");
									}
								abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
									{
								if (hit.collider.gameObject.GetComponent<Spearman>().Charge == false)
									{
										UnitBuffed = hit.collider.gameObject;
										print("Spearman gained Charge: double movement");
											UnitBuffed.GetComponent<Spearman>().Charge = true;
											faith1 = faith1 - 75;

									}
									else
									{
										print ("Unit can't be given Charge more than once.");
									}
										abilitySelected = 0;
									}
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
				}
				}
					else
					{
						print ("Player 1 doesn't have enough faith to use Charge.");
					abilitySelected = 0;
					}
				}
			if (playersTurn == 2)
			{
				if (faith2 >= 75)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Pharaoh>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Pharaoh gained Charge: double movement");
											UnitBuffed.GetComponent<Pharaoh>().Charge = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Archer>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Archer gained Charge: double movement");
											UnitBuffed.GetComponent<Archer>().Charge = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<FootSoldier>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("FootSoldier gained Charge: double movement");
											UnitBuffed.GetComponent<FootSoldier>().Charge = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Priest>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Priest gained Charge: double movement");
											UnitBuffed.GetComponent<Priest>().Charge = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<RoyalGuard>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("RoyalGuard gained Charge: double movement");
											UnitBuffed.GetComponent<RoyalGuard>().Charge = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Slinger>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Slinger gained Charge: double movement");
											UnitBuffed.GetComponent<Slinger>().Charge = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Spearman>().Charge == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Spearman gained Charge: double movement");
											UnitBuffed.GetComponent<Spearman>().Charge = true;
											faith2 = faith2 - 75;
											
										}
										else
										{
											print ("Unit can't be given Charge more than once.");
										}
										abilitySelected = 0;
									}
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 2 doesn't have enough faith to use Charge.");
					abilitySelected = 0;
				}
			}
		}
		if (abilitySelected == 4)
		{
			if (playersTurn == 1)
			{
				if (faith1 >= 75)
				{
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					if (hit.collider != null)
					{
						
						if (hit.collider.tag == "UnitPharaoh")
						{
							if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<Pharaoh>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("Pharaoh cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<Pharaoh>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						if (hit.collider.tag == "UnitArcher")
						{
							if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<Archer>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("Archer cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<Archer>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<FootSoldier>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("FootSoldier cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<FootSoldier>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<Priest>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("Priest cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<Priest>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<RoyalGuard>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("RoyalGuard cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<RoyalGuard>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						if (hit.collider.tag == "UnitSlinger")
						{
							if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<Slinger>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("Slinger cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<Slinger>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						if (hit.collider.tag == "UnitSpearman")
						{
							if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber != playersTurn)
							{
								if (hit.collider.gameObject.GetComponent<Spearman>().PowerOfApep == false)
								{
									UnitBuffed = hit.collider.gameObject;
									print("Spearman cursed by Power Of Apep: -50 health per turn");
									UnitBuffed.GetComponent<Spearman>().PowerOfApep = true;
											faith1 = faith1 - 75;
								}
								else
								{
									print ("Unit can't be cursed by Power of Apep more than once.");
								}
								abilitySelected = 0;
							}
						}
						
					}
					else
					{
						abilitySelected = 0;
					}
				}
			}
				}
				else
				{
					print ("Player 1 doesn't have enough faith to use  Power Of Apep.");
					abilitySelected = 0;
				}
			}
			if (playersTurn == 2)
			{
				if (faith2 >= 75)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Pharaoh>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Pharaoh cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<Pharaoh>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Archer>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Archer cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<Archer>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<FootSoldier>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("FootSoldier cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<FootSoldier>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Priest>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Priest cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<Priest>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<RoyalGuard>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("RoyalGuard cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<RoyalGuard>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Slinger>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Slinger cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<Slinger>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber != playersTurn)
									{
										if (hit.collider.gameObject.GetComponent<Spearman>().PowerOfApep == false)
										{
											UnitBuffed = hit.collider.gameObject;
											print("Spearman cursed by Power Of Apep: -50 health per turn");
											UnitBuffed.GetComponent<Spearman>().PowerOfApep = true;
											faith2 = faith2 - 75;
										}
										else
										{
											print ("Unit can't be cursed by Power of Apep more than once.");
										}
										abilitySelected = 0;
									}
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 2 doesn't have enough faith to use Power Of Apep.");
					abilitySelected = 0;
				}
			}
		}
		if (abilitySelected == 5)
		{
			if (playersTurn == 1)
			{
				if (faith1 >= 150)
				{
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					if (hit.collider != null)
					{
						
						if (hit.collider.tag == "UnitPharaoh")
						{
							if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber != playersTurn)
							{
								
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().Health - 200;
								print("Pharaoh smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						if (hit.collider.tag == "UnitArcher")
						{
							if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber != playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().Health - 200;
								print("Archer smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber != playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health - 200;
								print("FootSoldier smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber != playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health - 200;
								print("Priest smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber != playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health - 200;
								print("RoyalGuard smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						if (hit.collider.tag == "UnitSlinger")
						{
							if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber != playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health - 200;
								print("Slinger smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						if (hit.collider.tag == "UnitSpearman")
						{
							if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber != playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health - 200;
								print("Spearman smited: Health - 200.");
								abilitySelected = 0;
										faith1 = faith1 - 150;
							}
						}
						
					}
					else
					{
						abilitySelected = 0;
					}
				}
			}
				}
				else
				{
					print ("Player 1 doesn't have enough faith to use Smite.");
					abilitySelected = 0;
				}
			}
			if (playersTurn == 2)
			{
				if (faith2 >= 150)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber != playersTurn)
									{
										
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().Health - 200;
										print("Pharaoh smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber != playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().Health - 200;
										print("Archer smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber != playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health - 200;
										print("FootSoldier smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber != playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health - 200;
										print("Priest smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber != playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health - 200;
										print("RoyalGuard smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber != playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health - 200;
										print("Slinger smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber != playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health - 200;
										print("Spearman smited: Health - 200.");
										abilitySelected = 0;
										faith2 = faith2 - 150;
									}
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 2 doesn't have enough faith to use Smite.");
					abilitySelected = 0;
				}
			}
		}

		if (abilitySelected == 6)
		{
			if (playersTurn == 1)
			{
				if (faith1 >= 150)
				{
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					if (hit.collider != null)
					{
						
						if (hit.collider.tag == "UnitPharaoh")
						{
							if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
							{

								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<Pharaoh>().Health == UnitBuffed.GetComponent<Pharaoh>().MaxHealth)
									print("Pharaoh already at max health. Health can't be restored.");
								else
								{
									UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().MaxHealth;
									print("Pharaoh healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						if (hit.collider.tag == "UnitArcher")
						{
							if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<Archer>().Health == UnitBuffed.GetComponent<Archer>().MaxHealth)
									print("Archer already at max health. Health can't be restored.");
								else{
									UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().MaxHealth;
									print("Archer healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<FootSoldier>().Health == UnitBuffed.GetComponent<FootSoldier>().MaxHealth)
									print("FootSoldier already at max health. Health can't be restored.");
								else{
									UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().MaxHealth;
									print("FootSoldier healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<Priest>().Health == UnitBuffed.GetComponent<Priest>().MaxHealth)
									print("Priest already at max health. Health can't be restored.");
								else{
									UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().MaxHealth;
									print("Priest healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<RoyalGuard>().Health == UnitBuffed.GetComponent<RoyalGuard>().MaxHealth)
									print("RoyalGuard already at max health. Health can't be restored.");
								else{
									UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().MaxHealth;
									print("RoyalGuard healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						if (hit.collider.tag == "UnitSlinger")
						{
							if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<Slinger>().Health == UnitBuffed.GetComponent<Slinger>().MaxHealth)
									print("Slinger already at max health. Health can't be restored.");
								else{
									UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().MaxHealth;
									print("Slinger healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						if (hit.collider.tag == "UnitSpearman")
						{
							if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								abilitySelected = 0;
								if (UnitBuffed.GetComponent<Spearman>().Health == UnitBuffed.GetComponent<Spearman>().MaxHealth)
									print("Spearman already at max health. Health can't be restored.");
								else{
									UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().MaxHealth;
									print("Spearman healed to full by the Eye of Horus.");
											faith1 = faith1 - 150;
								}
							}
						}
						
					}
					else
					{
						abilitySelected = 0;
					}
					}
					}
				}
				else
				{
					print ("Player 1 doesn't have enough faith to use Eye Of Horus.");
							abilitySelected = 0;
				}
			}
			if (playersTurn == 2)
			{
				if (faith2 >= 150)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "UnitPharaoh")
								{
									if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
									{
										
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<Pharaoh>().Health == UnitBuffed.GetComponent<Pharaoh>().MaxHealth)
											print("Pharaoh already at max health. Health can't be restored.");
										else
										{
											UnitBuffed.GetComponent<Pharaoh>().Health = UnitBuffed.GetComponent<Pharaoh>().MaxHealth;
											print("Pharaoh healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								if (hit.collider.tag == "UnitArcher")
								{
									if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<Archer>().Health == UnitBuffed.GetComponent<Archer>().MaxHealth)
											print("Archer already at max health. Health can't be restored.");
										else{
											UnitBuffed.GetComponent<Archer>().Health = UnitBuffed.GetComponent<Archer>().MaxHealth;
											print("Archer healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								if (hit.collider.tag == "UnitFootSoldier")
								{
									if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<FootSoldier>().Health == UnitBuffed.GetComponent<FootSoldier>().MaxHealth)
											print("FootSoldier already at max health. Health can't be restored.");
										else{
											UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().MaxHealth;
											print("FootSoldier healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								if (hit.collider.tag == "UnitPriest")
								{
									if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<Priest>().Health == UnitBuffed.GetComponent<Priest>().MaxHealth)
											print("Priest already at max health. Health can't be restored.");
										else{
											UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().MaxHealth;
											print("Priest healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								if (hit.collider.tag == "UnitRoyalGuard")
								{
									if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<RoyalGuard>().Health == UnitBuffed.GetComponent<RoyalGuard>().MaxHealth)
											print("RoyalGuard already at max health. Health can't be restored.");
										else{
											UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().MaxHealth;
											print("RoyalGuard healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								if (hit.collider.tag == "UnitSlinger")
								{
									if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<Slinger>().Health == UnitBuffed.GetComponent<Slinger>().MaxHealth)
											print("Slinger already at max health. Health can't be restored.");
										else{
											UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().MaxHealth;
											print("Slinger healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								if (hit.collider.tag == "UnitSpearman")
								{
									if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
									{
										UnitBuffed = hit.collider.gameObject;
										abilitySelected = 0;
										if (UnitBuffed.GetComponent<Spearman>().Health == UnitBuffed.GetComponent<Spearman>().MaxHealth)
											print("Spearman already at max health. Health can't be restored.");
										else{
											UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().MaxHealth;
											print("Spearman healed to full by the Eye of Horus.");
											faith2 = faith2 - 150;
										}
									}
								}
								
							}
							else
							{
								abilitySelected = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 1 doesn't have enough faith to use Eye Of Horus.");
					abilitySelected = 0;
				}
			}
		}

		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{
					if (moved == false)
					{
						ChangeAllTilesToStandard();
						if (hit.collider.tag == "UnitPharaoh")
						{
							if (hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<Pharaoh>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<Pharaoh>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<Pharaoh>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Pharaoh selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<Pharaoh>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<Pharaoh>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<Pharaoh>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<Pharaoh>().Health;
							BoardGUI.UnitName = "Pharaoh";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<Pharaoh>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<Pharaoh>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "UnitArcher")
						{
							if (hit.collider.gameObject.GetComponent<Archer>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<Archer>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<Archer>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<Archer>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Archer selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<Archer>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<Archer>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<Archer>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<Archer>().Health;
							BoardGUI.UnitName = "Archer";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<Archer>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<Archer>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<FootSoldier>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<FootSoldier>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<FootSoldier>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Foot Soldier selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<FootSoldier>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<FootSoldier>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<FootSoldier>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<FootSoldier>().Health;
							BoardGUI.UnitName = "Foot Soldier";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<FootSoldier>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<Priest>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<Priest>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<Priest>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Priest selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<Priest>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<Priest>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<Priest>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<Priest>().Health;
							BoardGUI.UnitName = "Priest";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<Priest>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<Priest>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<RoyalGuard>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<RoyalGuard>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<RoyalGuard>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Royal Guard selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<RoyalGuard>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<RoyalGuard>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<RoyalGuard>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<RoyalGuard>().Health;
							BoardGUI.UnitName = "Royal Guard";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<RoyalGuard>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "UnitSlinger")
						{
							if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<Slinger>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<Slinger>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<Slinger>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Slinger selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<Slinger>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<Slinger>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<Slinger>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<Slinger>().Health;
							BoardGUI.UnitName = "Slinger";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<Slinger>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "UnitSpearman")
						{
							if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
							{
								UnitSelected = hit.collider.gameObject;
								UnitSelectedPosition = UnitSelected.transform.position;
								TileSelectedPosition = UnitSelectedPosition;
								UnitMovementDistance = UnitSelected.GetComponent<Spearman>().MovementDistance;
								UnitAttackDistance = UnitSelected.GetComponent<Spearman>().AttackRange;
								UnitAttackDamage = UnitSelected.GetComponent<Spearman>().Damage;
								Selected = true;
								FindBlueTiles(UnitSelectedPosition, UnitMovementDistance);
								print("Spearman selected");
								UnitSelectedPlayerNumber = UnitSelected.GetComponent<Spearman>().PlayerNumber;
							}
							BoardGUI.UnitAttackDistance = hit.collider.gameObject.GetComponent<Spearman>().AttackRange;
							BoardGUI.UnitDamage = hit.collider.gameObject.GetComponent<Spearman>().Damage;
							BoardGUI.UnitHealth = hit.collider.gameObject.GetComponent<Spearman>().Health;
							BoardGUI.UnitName = "Spearman";
							BoardGUI.UnitMovement = hit.collider.gameObject.GetComponent<Spearman>().MovementDistance;
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber;
							BoardGUI.UnitSelected = true;
						}
						if (hit.collider.tag == "Idol")
						{
							if (hit.collider.gameObject.GetComponent<Idol>().PlayerNumber == playersTurn)
								BoardGUI.myIdol = true;
							else
								BoardGUI.myIdol = false;
							BoardGUI.UnitName = "Idol";
							BoardGUI.PlayersTurn = hit.collider.gameObject.GetComponent<Idol>().PlayerNumber;
							BoardGUI.UnitHealth = hit.collider.GetComponent<Idol>().Health;
							BoardGUI.UnitSelected = true;
							ChangeAllTilesToStandard();
						}
						if (hit.collider.tag == "Tile")
						{
							Selected = false;
							BoardGUI.UnitSelected = false;
							ChangeAllTilesToStandard();
						}
					}

						
				}
				
				
			}
			else
			{
				Selected = false;
				ChangeAllTilesToStandard();
				//BoardGUI.UnitSelected = false;
			}
		}

		if (moved == true)
			ChangeAllTilesToStandard();



	}
	IEnumerator TurnTimerCountdown()
	{
		turnTimer = turnTimer - 1;
		yield return new WaitForSeconds (1);
		StartCoroutine ("TurnTimerCountdown");
	}

	void UpdatedUnitsHealth() 
	{
		var gos = GameObject.FindGameObjectsWithTag("Unit");
		foreach (GameObject go in gos) 
		{
			GameObject MainObject = go.transform.parent.gameObject;
			if (MainObject.tag == "UnitPharaoh")
				MainObject.GetComponent<Pharaoh>().NextTurn = true;
			if (MainObject.tag == "UnitArcher")
				MainObject.GetComponent<Archer>().NextTurn = true;
			if (MainObject.tag == "UnitFootSoldier")
				MainObject.GetComponent<FootSoldier>().NextTurn = true;
			if (MainObject.tag == "UnitPriest")
				MainObject.GetComponent<Priest>().NextTurn = true;
			if (MainObject.tag == "UnitRoyalGuard")
				MainObject.GetComponent<RoyalGuard>().NextTurn = true;
			if (MainObject.tag == "UnitSlinger")
				MainObject.GetComponent<Slinger>().NextTurn = true;
			if (MainObject.tag == "UnitSpearman")
				MainObject.GetComponent<Spearman>().NextTurn = true;

		}

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

	void FindBlueTiles(Vector3 UnitPosition, int MovementDistance) 
	{
		var gos = GameObject.FindGameObjectsWithTag("Tile");
		foreach (GameObject go in gos) 
		{
			if (((UnitPosition.x + MovementDistance) >= (go.transform.position.x)) && ((UnitPosition.x - MovementDistance) <= (go.transform.position.x)))
			{
				if (((UnitPosition.z + MovementDistance) >= (go.transform.position.z)) && ((UnitPosition.z - MovementDistance) <= (go.transform.position.z)))
				{
					go.GetComponent<TileMaterial>().changeToBlue = true;
				}
			}
		}
	}
	void ChangeAllTilesToStandard()
	{
		var gos = GameObject.FindGameObjectsWithTag("Tile");
		foreach (GameObject go in gos) 
		{
			go.GetComponent<TileMaterial>().changeToBlue = false;
		}
	}
}