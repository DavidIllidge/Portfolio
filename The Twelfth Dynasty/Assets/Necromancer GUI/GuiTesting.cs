using UnityEngine;
using System.Collections;

public class GuiTesting : MonoBehaviour {

	public GameObject Unit1;
	public GameObject Unit2;
	public GameObject Unit3;
	public GameObject Unit4;
	public GameObject Unit5;
	public GameObject Unit6;
	public GameObject Unit7;
	public GameObject Unit8;
	public GameObject Unit9;
	public GameObject Unit10;
	public GameObject Unit1Tile;
	public GameObject Unit2Tile;
	public GameObject Unit3Tile;
	public GameObject Unit4Tile;
	public GameObject Unit5Tile;
	public GameObject Unit6Tile;
	public GameObject Unit7Tile;
	public GameObject Unit8Tile;
	public GameObject Unit9Tile;
	public GameObject Unit10Tile;
	int Unit1Cost;
	int Unit2Cost;
	int Unit3Cost;
	int Unit4Cost;
	int Unit5Cost;
	int Unit6Cost;
	int Unit7Cost;
	int Unit8Cost;
	int Unit9Cost;
	int Unit10Cost;
	int SelectedUnitCost;
	int Command1Cost;
	int Command2Cost;
	int Command3Cost;
	int Command4Cost;
	int SelectedCommandCost;
	public GameObject Command1;
	public GameObject Command2;
	public GameObject Command3;
	public GameObject Command4;
	public GUIText Unit1Text;
	public GUIText Unit2Text;
	public GUIText Unit3Text;
	public GUIText Unit4Text;
	public GUIText Unit5Text;
	public GUIText Unit6Text;
	public GUIText Unit7Text;
	public GUIText Unit8Text;
	public GUIText Unit9Text;
	public GUIText Unit10Text;
	public GUIText Position1;
	public GUIText Position2;
	public GUIText Position3;
	public GUIText Position4;
	public GUIText Position5;
	public GUIText Position6;
	public GUIText Position7;
	public GUIText Position8;
	public GUIText Position9;
	public GUIText Position10;
	public GUIText Command1Text;
	public GUIText Command2Text;
	public GUIText Command3Text;
	public GUIText Command4Text;
	public GUIText FaithRemaining;
	public GameObject CommandSelectedButton;
	public GameObject UnitSelectedButton;
	public GameObject PositionsSelectedButton;
	public KeepOnLoadPlayer1 KeepOnLoad;
	public KeepOnLoadPlayer2 KeepOnLoad2;
	public int PlayerSelection;
	int UnitPosition = 0;
    bool doWindow4 = true;
	bool doWindow5 = false;

	public GUISkin mySkin;

	private Rect windowRect4 = new Rect (40, 265, 900, 300);
	private Rect windowRect5 = new Rect (740, 300, 400, 300);


	private string InformationText = "";
	private string SelectedUnit = "No Unit";
	private string SelectedPositionUnit = "";
	private string SelectedCommand = "No Command";

	void DoMyWindow5 (int windowID) 
	{
		
		GUILayout.Space(8);
		GUILayout.BeginVertical();
		GUILayout.Label("Confirmation");
		GUILayout.Label ("", "Divider");
		GUILayout.TextArea("Are you sure you wish to continue? Pressing Yes will lock in your commands, units and their positions. If you have not positioned your units they will not exist.");
		GUILayout.Label ("", "Divider");
		GUILayout.BeginHorizontal();
		//GUILayout.Space(50);

		if(GUILayout.Button("Yes"))
		{
			if (PlayerSelection == 1)
			{
					KeepOnLoad.Unit1 = Unit1Text.text;
					KeepOnLoad.Unit2 = Unit2Text.text;
					KeepOnLoad.Unit3 = Unit3Text.text;
					KeepOnLoad.Unit4 = Unit4Text.text;
					KeepOnLoad.Unit5 = Unit5Text.text;
					KeepOnLoad.Unit6 = Unit6Text.text;
					KeepOnLoad.Unit7 = Unit7Text.text;
					KeepOnLoad.Unit8 = Unit8Text.text;
					KeepOnLoad.Unit9 = Unit9Text.text;
					KeepOnLoad.Unit10 = Unit10Text.text;
					
					KeepOnLoad.Command1 = Command1Text.text;
					KeepOnLoad.Command2 = Command2Text.text;
					KeepOnLoad.Command3 = Command3Text.text;
					KeepOnLoad.Command4 = Command4Text.text;
					Application.LoadLevel("Player2UnitSelection");

			}
			if (PlayerSelection == 2)
			{

					KeepOnLoad2.Unit1 = Unit1Text.text;
					KeepOnLoad2.Unit2 = Unit2Text.text;
					KeepOnLoad2.Unit3 = Unit3Text.text;
					KeepOnLoad2.Unit4 = Unit4Text.text;
					KeepOnLoad2.Unit5 = Unit5Text.text;
					KeepOnLoad2.Unit6 = Unit6Text.text;
					KeepOnLoad2.Unit7 = Unit7Text.text;
					KeepOnLoad2.Unit8 = Unit8Text.text;
					KeepOnLoad2.Unit9 = Unit9Text.text;
					KeepOnLoad2.Unit10 = Unit10Text.text;
					
					KeepOnLoad2.Command1 = Command1Text.text;
					KeepOnLoad2.Command2 = Command2Text.text;
					KeepOnLoad2.Command3 = Command3Text.text;
					KeepOnLoad2.Command4 = Command4Text.text;
					Application.LoadLevel("Board");

			}
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		//GUILayout.Space(50);
		if(GUILayout.Button("No"))
				doWindow5 = false;
		GUILayout.EndHorizontal();
		GUILayout.EndVertical ();
	}
	void DoMyWindow4 (int windowID) 
	{
		
		GUILayout.Space(8);
		GUILayout.BeginVertical();
		GUILayout.Label("Information");
		GUILayout.Label ("", "Divider");
		GUILayout.Label (InformationText, "PlainText");
		GUILayout.EndVertical ();
	}
    void UnitsButtons()
    {
        if (GUI.Button (new Rect (554, 100, 100, 31), "Foot Soldier", "ShortButton")) 
		{
			SelectedUnit = "Foot Soldier";
			SelectedUnitCost = -75;
			SelectedPositionUnit = "FS";
			UnitSelectedButton.transform.position = new Vector3(-115.5f, -155f, 110.7f);
		}
        if (GUI.Button(new Rect(654, 100, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Foot Soldier\nHealth: 300\nDamage: 100\nMovement: 4\nAttack Range: 1\nCost: 75";
        }
		if (GUI.Button(new Rect(734, 100, 100, 31), "Archer", "ShortButton"))
		{
			SelectedUnit = "Archer";
			SelectedUnitCost = -100;
			SelectedPositionUnit = "Ar";
			UnitSelectedButton.transform.position = new Vector3(-57.1f, -155f, 110.7f);
		}
        if (GUI.Button(new Rect(834, 100, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Archer\nHealth: 100\nDamage: 100\nMovement: 3\nAttack Range: 6\nCost: 100";
        }
		if (GUI.Button(new Rect(554, 130, 100, 31), "Slinger", "ShortButton"))
		{
			SelectedUnit = "Slinger";
			SelectedUnitCost = -50;
			SelectedPositionUnit = "Sl";
			UnitSelectedButton.transform.position = new Vector3(-115.5f, -155f, 101f);
		}
        if (GUI.Button(new Rect(654, 130, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Slinger\nHealth: 100\nDamage: 100\nMovement: 6\nAttack Range: 1\nCost: 50";
        }
		if (GUI.Button(new Rect(734, 130, 100, 31), "Spearman", "ShortButton"))
		{
			SelectedUnit = "Spearman";
			SelectedUnitCost = -100;
			SelectedPositionUnit = "Sp";
			UnitSelectedButton.transform.position = new Vector3(-57.1f, -155f, 101.0f);
		}
        if (GUI.Button(new Rect(834, 130, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Spearman\nHealth: 200\nDamage: 200\nMovement: 4\nAttack Range: 2\nCost: 100";
        }
		if (GUI.Button(new Rect(554, 160, 100, 31), "Priest", "ShortButton"))
		{
			SelectedUnit = "Priest";
			SelectedUnitCost = -50;
			SelectedPositionUnit = "Pr";
			UnitSelectedButton.transform.position = new Vector3(-115.5f, -155f, 91.6f);
		}
        if (GUI.Button(new Rect(654, 160, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Priest\nHealth: 100\nDamage: 100\nMovement: 4\nAttack Range: 1\nCost: 50";
        }
		if (GUI.Button(new Rect(734, 160, 100, 31), "Royal Guard", "ShortButton"))
		{
			SelectedUnit = "Royal Guard";
			SelectedUnitCost = -150;
			SelectedPositionUnit = "RG";
			UnitSelectedButton.transform.position = new Vector3(-57.1f, -155f, 91.3f);
		}
        if (GUI.Button(new Rect(834, 160, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Royal Guard\nHealth: 300\nDamage: 300\nMovement: 4\nAttack Range: 1\nCost: 150";
        }
		if (GUI.Button(new Rect(554, 190, 100, 31), "Pharaoh", "ShortButton"))
		{
			SelectedUnit = "Pharaoh";
			SelectedUnitCost = -200;
			SelectedPositionUnit = "Ph";
			UnitSelectedButton.transform.position = new Vector3(-115.5f, -155f, 81.6f);
		}
        if (GUI.Button(new Rect(654, 190, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Pharaoh\nHealth: 600\nDamage: 300\nMovement: 4\nAttack Range: 1\nCost: 200";
        }
		if (GUI.Button(new Rect(734, 190, 100, 31), "No Unit", "ShortButton"))
		{
			SelectedUnit = "No Unit";
			SelectedUnitCost = 0;
			SelectedPositionUnit = "NU";
			UnitSelectedButton.transform.position = new Vector3(-57.1f, -155f, 81.6f);
		}
        
    }
    void CommandsButtons()
    {
		if (GUI.Button(new Rect(554, 625, 115, 31), "Eye Of Horus", "ShortButton"))
		{
			SelectedCommand = "Eye Of Horus";
			SelectedCommandCost = -150;
			CommandSelectedButton.transform.position = new Vector3(-112.7f, -155f, -58.9f);
		}
        if (GUI.Button(new Rect(669, 625, 50, 31), "  i", "ShortButton"))
        {
			InformationText = "Eye Of Horus\nUse the healing powers granted by the Eye of Horus to restore a unit to full health.\ncost:150";
        }
		if (GUI.Button(new Rect(734, 625, 115, 31), "Charge", "ShortButton"))
		{
			SelectedCommand = "Charge";
			SelectedCommandCost = -75;
			CommandSelectedButton.transform.position = new Vector3(-54.7f, -155f, -58.9f);
		}
        if (GUI.Button(new Rect(849, 625, 50, 31), "  i", "ShortButton"))
        {
			InformationText = "Charge\nCall to your units to charge into battle by granting double movement distance this turn.\ncost:75";
        }
		if (GUI.Button(new Rect(554, 655, 115, 31), "Knot Of Isis", "ShortButton"))
		{
			SelectedCommand = "Knot Of Isis";
			SelectedCommandCost = -75;
			CommandSelectedButton.transform.position = new Vector3(-112.7f, -155f, -68.6f);
		}
        if (GUI.Button(new Rect(669, 655, 50, 31), "  i", "ShortButton"))
        {
			InformationText = "Knot Of Isis\nCall upon the power of the Knot of Isis amulet and give a unit +400 health for a turn. May only be used on 1 unit at once.\ncost:75";
        }
		if (GUI.Button(new Rect(734, 655, 115, 31), "Ankh", "ShortButton"))
		{
			SelectedCommand = "Ankh";
			SelectedCommandCost = -75;
			CommandSelectedButton.transform.position = new Vector3(-54.7f, -155f, -68.6f);
		}
        if (GUI.Button(new Rect(849, 655, 50, 31), "  i", "ShortButton"))
        {
			InformationText = "Ankh\nCall upon the power of the Ankh amulet to grant strength to your unit for a turn, giving it +200 damage and +100 health until the end of the turn. May only be used on 1 unit at once.\ncost:75";
        }
		if (GUI.Button(new Rect(554, 685, 115, 31), "Power Of Apep", "ShortButton"))
		{
			SelectedCommand = "Power Of Apep";
			SelectedCommandCost = -75;
			CommandSelectedButton.transform.position = new Vector3(-112.7f, -155f, -78.3f);
		}
        if (GUI.Button(new Rect(669, 685, 50, 31), "  i", "ShortButton"))
        {
			InformationText = "Power Of Apep\nPray to Apep to poison an enemy unit dealing 50 damage a turn.\ncost:75";
        }
		if (GUI.Button(new Rect(734, 685, 115, 31), "Smite", "ShortButton"))
		{
			SelectedCommand = "Smite";
			SelectedCommandCost = -150;
			CommandSelectedButton.transform.position = new Vector3(-54.7f, -155f, -78.3f);
		}
        if (GUI.Button(new Rect(849, 685, 50, 31), "  i", "ShortButton"))
        {
			InformationText = "Smite\nPray to the God of War, Montu, to smite down an enemy dealing 200 damage.\ncost:150";
        }
		if (GUI.Button(new Rect(554, 715, 115, 31), "Book Of Throth", "ShortButton"))
		{
			SelectedCommand = "Book Of Throth";
			SelectedCommandCost = -100;
			CommandSelectedButton.transform.position = new Vector3(-112.7f, -155f, -88.0f);
		}
        if (GUI.Button(new Rect(669, 715, 50, 31), "  i", "ShortButton"))
        {
            InformationText = "Book Of Throth\nRead from the book of Throth to ressurect the dead. Summon a random unit.\ncost:100";
        }
		if (GUI.Button(new Rect(734, 715, 115, 31), "No Command", "ShortButton"))
		{
			SelectedCommand = "No Command";
			SelectedCommandCost = 0;
			CommandSelectedButton.transform.position = new Vector3(-54.7f, -155f, -88.0f);
		}

    }

	void PositionsButtons()
	{
		if (GUI.Button (new Rect (1040, 330, 100, 31), Unit1Text.text, "ShortButton")) 
		{
			UnitPosition = 1;
			PositionsSelectedButton.transform.position = new Vector3(41.7f, -155f, 36.5f);

		}
		if (GUI.Button(new Rect(1220, 330, 100, 31), Unit2Text.text, "ShortButton"))
		{
			UnitPosition = 2;
			PositionsSelectedButton.transform.position = new Vector3(100f, -155f, 36.5f);
		}
		if (GUI.Button(new Rect(1040, 360, 100, 31), Unit3Text.text, "ShortButton"))
		{
			UnitPosition = 3;
			PositionsSelectedButton.transform.position = new Vector3(41.7f, -155f, 26.8f);
		}
		if (GUI.Button(new Rect(1220, 360, 100, 31), Unit4Text.text, "ShortButton"))
		{
			UnitPosition = 4;
			PositionsSelectedButton.transform.position = new Vector3(100f, -155f, 26.8f);
		}
		if (GUI.Button(new Rect(1040, 390, 100, 31), Unit5Text.text, "ShortButton"))
		{
			UnitPosition = 5;
			PositionsSelectedButton.transform.position = new Vector3(41.7f, -155f, 17.1f);
		}
		if (GUI.Button(new Rect(1220, 390, 100, 31), Unit6Text.text, "ShortButton"))
		{
			UnitPosition = 6;
			PositionsSelectedButton.transform.position = new Vector3(100f, -155f, 17.1f);
		}
		if (GUI.Button(new Rect(1040, 420, 100, 31), Unit7Text.text, "ShortButton"))
		{
			UnitPosition = 7;
			PositionsSelectedButton.transform.position = new Vector3(41.7f, -155f, 7.4f);
		}
		if (GUI.Button(new Rect(1220, 420, 100, 31), Unit8Text.text, "ShortButton"))
		{
			UnitPosition = 8;
			PositionsSelectedButton.transform.position = new Vector3(100f, -155f, 7.4f);
		}
		if (GUI.Button(new Rect(1040, 450, 100, 31), Unit9Text.text, "ShortButton"))
		{
			UnitPosition = 9;
			PositionsSelectedButton.transform.position = new Vector3(41.7f, -155f, -2.3f);
		}
		if (GUI.Button(new Rect(1220, 450, 100, 31), Unit10Text.text, "ShortButton"))
		{
			UnitPosition = 10;
			PositionsSelectedButton.transform.position = new Vector3(100f, -155f, -2.3f);
		}
		
	}


    void OnGUI()
    {
        GUI.skin = mySkin;

        UnitsButtons();
        CommandsButtons();
		PositionsButtons ();
		if (PlayerSelection == 1)
		{
			if(GUI.Button(new Rect(1080, 680, 200, 50), "\t\t\tNext Player", "ShortButton"))
			{			
				doWindow5 = true;
			}
		}
			if (PlayerSelection == 2)
			{
			if(GUI.Button(new Rect(1080, 680, 200, 50), "\t\t\tGo To Board", "ShortButton"))
			{
				doWindow5 = true;
			}
		}
        if (doWindow4)
            windowRect4 = GUI.Window(4, windowRect4, DoMyWindow4, "");
        GUI.BeginGroup(new Rect(0, 0, 100, 100));
        GUI.EndGroup();
		if (doWindow5)
			windowRect5 = GUI.Window(5, windowRect5, DoMyWindow5, "");
		GUI.BeginGroup(new Rect(0, 0, 100, 100));
		GUI.EndGroup();
    }

	void Start () {
	
	}
	

	void Update () {
		FaithRemaining.text = (1000 + Unit1Cost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost).ToString ();
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{					
					switch (hit.collider.gameObject.name)
					{
					case "Unit1":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
						{
						Unit1Text.text = SelectedUnit;
						Unit1Cost = SelectedUnitCost;
						Position1.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit2":
						if(1000 + SelectedUnitCost + Unit1Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
						{
						Unit2Text.text = SelectedUnit;
						Unit2Cost = SelectedUnitCost;
						Position2.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit3":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit1Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
							{
						Unit3Text.text = SelectedUnit;
						Unit3Cost = SelectedUnitCost;
						Position3.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit4":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit1Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
								{
						Unit4Text.text = SelectedUnit;
						Unit4Cost = SelectedUnitCost;
						Position4.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit5":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit1Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
									{
						Unit5Text.text = SelectedUnit;
						Unit5Cost = SelectedUnitCost;
						Position5.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit6":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit1Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
										{
						Unit6Text.text = SelectedUnit;
						Unit6Cost = SelectedUnitCost;
						Position6.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit7":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit1Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
											{
						Unit7Text.text = SelectedUnit;
						Unit7Cost = SelectedUnitCost;
						Position7.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit8":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit1Cost + Unit9Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
												{
						Unit8Text.text = SelectedUnit;
						Unit8Cost = SelectedUnitCost;
						Position8.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit9":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit1Cost + Unit10Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
													{
						Unit9Text.text = SelectedUnit;
						Unit9Cost = SelectedUnitCost;
						Position9.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					case "Unit10":
						if(1000 + SelectedUnitCost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit1Cost + Command1Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
						{
						Unit10Text.text = SelectedUnit;
						Unit10Cost = SelectedUnitCost;
						Position10.text = SelectedPositionUnit;
						}
						else
							print ("Not enough Faith to select this unit.");
						break;
					}

					switch (hit.collider.gameObject.name)
					{
					case "Command1":
						if(1000 + SelectedCommandCost + Unit1Cost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command2Cost + Command3Cost + Command4Cost >= 0)
						{
						Command1Text.text = SelectedCommand;
							Command1Cost = SelectedCommandCost;
						if (Command2Text.text == SelectedCommand)
						{
							Command2Text.text = "No Command";
								Command2Cost = 0;
						}
						if (Command3Text.text == SelectedCommand)
						{
							Command3Text.text = "No Command";
								Command3Cost = 0;
						}
						if (Command4Text.text == SelectedCommand)
						{
							Command4Text.text = "No Command";
								Command4Cost = 0;
						}
						}
						else
							print ("Not enough Faith to select this command.");
						break;
					case "Command2":
						if(1000 + SelectedCommandCost + Unit1Cost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command1Cost + Command3Cost + Command4Cost >= 0)
						{
						Command2Text.text = SelectedCommand;
							Command2Cost = SelectedCommandCost;
						if (Command1Text.text == SelectedCommand)
						{
							Command1Text.text = "No Command";
								Command1Cost = 0;
						}
						if (Command3Text.text == SelectedCommand)
						{
							Command3Text.text = "No Command";
								Command3Cost = 0;
						}
						if (Command4Text.text == SelectedCommand)
						{
							Command4Text.text = "No Command";
								Command4Cost = 0;
						}
						}
							else
								print ("Not enough Faith to select this command.");
						break;

					case "Command3":
						if(1000 + SelectedCommandCost + Unit1Cost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command2Cost + Command1Cost + Command4Cost >= 0)
							{
						Command3Text.text = SelectedCommand;
							Command3Cost = SelectedCommandCost;
						if (Command1Text.text == SelectedCommand)
						{
							Command1Text.text = "No Command";
									Command1Cost = 0;
						}
						if (Command2Text.text == SelectedCommand)
						{
							Command2Text.text = "No Command";
									Command2Cost = 0;
						}
						if (Command4Text.text == SelectedCommand)
						{
							Command4Text.text = "No Command";
									Command4Cost = 0;
						}
							}
								else
									print ("Not enough Faith to select this command.");
						break;
					case "Command4":
								if(1000 + SelectedCommandCost + Unit1Cost + Unit2Cost + Unit3Cost + Unit4Cost + Unit5Cost + Unit6Cost + Unit7Cost + Unit8Cost + Unit9Cost + Unit10Cost + Command2Cost + Command3Cost + Command1Cost >= 0)
								{
						Command4Text.text = SelectedCommand;
							Command4Cost = SelectedCommandCost;
						if (Command1Text.text == SelectedCommand)
						{
							Command1Text.text = "No Command";
										Command1Cost = 0;
						}
						if (Command2Text.text == SelectedCommand)
						{
							Command2Text.text = "No Command";
										Command2Cost = 0;
						}
						if (Command3Text.text == SelectedCommand)
						{
							Command3Text.text = "No Command";
										Command3Cost = 0;
						}
								}
									else
										print ("Not enough Faith to select this command.");
						break;
					}

					if (hit.collider.tag == "Tile")
					{
						print ("Tile hit " + hit.collider.gameObject.name);
						if (UnitPosition == 1){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit1Tile.GetComponent<TilePosition>().selected = false;
								Unit1Tile = hit.collider.gameObject;
								Unit1Tile.GetComponent<TilePosition>().selected = true;
								Position1.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position1 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position1 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 2){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{
								
								Unit2Tile.GetComponent<TilePosition>().selected = false;
								Unit2Tile = hit.collider.gameObject;
								Unit2Tile.GetComponent<TilePosition>().selected = true;
								Position2.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position2 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position2 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 3){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit3Tile.GetComponent<TilePosition>().selected = false;
								Unit3Tile = hit.collider.gameObject;
								Unit3Tile.GetComponent<TilePosition>().selected = true;
								Position3.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position3 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position3 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 4){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit4Tile.GetComponent<TilePosition>().selected = false;
								Unit4Tile = hit.collider.gameObject;
								Unit4Tile.GetComponent<TilePosition>().selected = true;
								Position4.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position4 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position4 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 5){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit5Tile.GetComponent<TilePosition>().selected = false;
								Unit5Tile = hit.collider.gameObject;
								Unit5Tile.GetComponent<TilePosition>().selected = true;
								Position5.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position5 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position5 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 6){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit6Tile.GetComponent<TilePosition>().selected = false;
								Unit6Tile = hit.collider.gameObject;
								Unit6Tile.GetComponent<TilePosition>().selected = true;
								Position6.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position6 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position6 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}	
						if (UnitPosition == 7){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit7Tile.GetComponent<TilePosition>().selected = false;
								Unit7Tile = hit.collider.gameObject;
								Unit7Tile.GetComponent<TilePosition>().selected = true;
								Position7.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position7 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position7 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 8){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit8Tile.GetComponent<TilePosition>().selected = false;
								Unit8Tile = hit.collider.gameObject;
								Unit8Tile.GetComponent<TilePosition>().selected = true;
								Position8.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position8 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position8 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 9){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{	

								Unit9Tile.GetComponent<TilePosition>().selected = false;
								Unit9Tile = hit.collider.gameObject;
								Unit9Tile.GetComponent<TilePosition>().selected = true;
								Position9.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position9 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position9 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0f, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
						if (UnitPosition == 10){
							if (hit.collider.GetComponent<TilePosition>().selected == false)
							{

								Unit10Tile.GetComponent<TilePosition>().selected = false;
								Unit10Tile = hit.collider.gameObject;
								Unit10Tile.GetComponent<TilePosition>().selected = true;
								Position10.transform.position = new Vector2((0.728f + hit.collider.GetComponent<TilePosition>().TileX * 0.0164f), (0.212f + hit.collider.GetComponent<TilePosition>().TileY * 0.0344f));
								if (PlayerSelection == 1)
							KeepOnLoad.Position10 = new Vector3(5.5f - hit.collider.GetComponent<TilePosition>().TileX, 0, 9.5f - hit.collider.GetComponent<TilePosition>().TileY);
								if (PlayerSelection == 2)
									KeepOnLoad2.Position10 = new Vector3(-5.5f + hit.collider.GetComponent<TilePosition>().TileX, 0, -9.5f + hit.collider.GetComponent<TilePosition>().TileY);
							}
						}
					}


				
			
				
			}
		}
	}








}
}
