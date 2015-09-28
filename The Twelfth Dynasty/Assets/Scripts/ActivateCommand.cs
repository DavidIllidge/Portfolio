using UnityEngine;
using System.Collections;

public class ActivateCommand : MonoBehaviour {
	public int abilitySelected = 0;
	public GameObject UnitBuffed;
	public bool Ankh1 = false;
	public bool Ankh2 = false;
	public bool KnotOfIsis1 = false;
	public bool KnotOfIsis2 = false;
	int playersTurn = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F2)) 
		{
			abilitySelected = 1;
		}


		if (abilitySelected == 1)
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
								print("Pharaoh gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Pharaoh>().Ankh = true;
								if (playersTurn == 1)
									Ankh1 = true;
								else
									Ankh2 = true;
							}
						}
						if (hit.collider.tag == "UnitFootSoldier")
						{
							if (hit.collider.gameObject.GetComponent<FootSoldier>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<FootSoldier>().Damage = UnitBuffed.GetComponent<FootSoldier>().Damage + 200;
								UnitBuffed.GetComponent<FootSoldier>().Health = UnitBuffed.GetComponent<FootSoldier>().Health + 100;
								print("FootSoldier gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<FootSoldier>().Ankh = true;
								if (playersTurn == 1)
									Ankh1 = true;
								else
									Ankh2 = true;
							}
						}
						if (hit.collider.tag == "UnitPriest")
						{
							if (hit.collider.gameObject.GetComponent<Priest>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Priest>().Damage = UnitBuffed.GetComponent<Priest>().Damage + 200;
								UnitBuffed.GetComponent<Priest>().Health = UnitBuffed.GetComponent<Priest>().Health + 100;
								print("Priest gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Priest>().Ankh = true;
								if (playersTurn == 1)
									Ankh1 = true;
								else
									Ankh2 = true;
							}
						}
						if (hit.collider.tag == "UnitRoyalGuard")
						{
							if (hit.collider.gameObject.GetComponent<RoyalGuard>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<RoyalGuard>().Damage = UnitBuffed.GetComponent<RoyalGuard>().Damage + 200;
								UnitBuffed.GetComponent<RoyalGuard>().Health = UnitBuffed.GetComponent<RoyalGuard>().Health + 100;
								print("RoyalGuard gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<RoyalGuard>().Ankh = true;
								if (playersTurn == 1)
									Ankh1 = true;
								else
									Ankh2 = true;
							}
						}
						if (hit.collider.tag == "UnitSlinger")
						{
							if (hit.collider.gameObject.GetComponent<Slinger>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Slinger>().Damage = UnitBuffed.GetComponent<Slinger>().Damage + 200;
								UnitBuffed.GetComponent<Slinger>().Health = UnitBuffed.GetComponent<Slinger>().Health + 100;
								print("Slinger gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Slinger>().Ankh = true;
								if (playersTurn == 1)
									Ankh1 = true;
								else
									Ankh2 = true;
							}
						}
						if (hit.collider.tag == "UnitSpearman")
						{
							if (hit.collider.gameObject.GetComponent<Spearman>().PlayerNumber == playersTurn)
							{
								UnitBuffed = hit.collider.gameObject;
								UnitBuffed.GetComponent<Spearman>().Damage = UnitBuffed.GetComponent<Spearman>().Damage + 200;
								UnitBuffed.GetComponent<Spearman>().Health = UnitBuffed.GetComponent<Spearman>().Health + 100;
								print("Spearman gained Ankh: 200 damage, 100 health");
								UnitBuffed.GetComponent<Spearman>().Ankh = true;
								if (playersTurn == 1)
									Ankh1 = true;
								else
									Ankh2 = true;
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
	}
}

