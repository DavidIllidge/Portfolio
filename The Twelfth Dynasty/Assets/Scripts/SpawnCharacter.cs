using UnityEngine;
using System.Collections;

public class SpawnCharacter : MonoBehaviour {
	GameObject Idol;
	bool IdolSelected = false;
	public bool ForceIdolSelected = false;
	bool ThrothIdolSelected = false;
	public int Unit;
	public MovePiece myGameController;
	int UnitNumber;
	public Transform Pharaoh;
	public Transform Archer;
	public Transform FootSoldier1;
	public Transform Priest;
	public Transform RoyalGuard;
	public Transform Slinger;
	public Transform Spearman;

	public Transform Pharaoh2;
	public Transform Archer2;
	public Transform FootSoldier2;
	public Transform Priest2;
	public Transform RoyalGuard2;
	public Transform Slinger2;
	public Transform Spearman2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (myGameController.playersTurn == 1)
		{
		
		/*if (Input.GetKeyDown (KeyCode.Q))
			Unit = 1;
		if (Input.GetKeyDown (KeyCode.W))
			Unit = 2;
		if (Input.GetKeyDown (KeyCode.E))
			Unit = 3;
		if (Input.GetKeyDown (KeyCode.R))
			Unit = 4;
		if (Input.GetKeyDown (KeyCode.T))
			Unit = 5;
		if (Input.GetKeyDown (KeyCode.Y))
			Unit = 6;
		if (Input.GetKeyDown (KeyCode.U))
			Unit = 7;
*/


				if (myGameController.abilitySelected == 7)
				{
					if (myGameController.faith1 >= 100)
					{
						if (Input.GetMouseButtonDown(0))
						{
							RaycastHit hit;
							Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
							if (Physics.Raycast(ray, out hit))
							{
								if (hit.collider != null)
								{
									
									if (hit.collider.tag == "Idol")
									{
										if (hit.collider.gameObject.GetComponent<Idol>().PlayerNumber == myGameController.playersTurn)
										{
										Idol = hit.collider.gameObject;
											ThrothIdolSelected = true;
											if (ThrothIdolSelected == true)
											{
												UnitNumber = Random.Range(1, 8);
											print (UnitNumber);
											}

										}
									}
									if (hit.collider.tag == "Tile") 
									{
									if (ThrothIdolSelected == true)
										{
											if (((Idol.transform.position.x + 1.5f) >= (hit.collider.transform.position.x)) && ((Idol.transform.position.x - 1.5f) <= (hit.collider.transform.position.x))) 
											{												
												if (((Idol.transform.position.z + 2) >= (hit.collider.transform.position.z)) && ((Idol.transform.position.z - 2) <= (hit.collider.transform.position.z))) 
												{
													switch (UnitNumber)
													{
													case 1:

													Transform q = Instantiate (Pharaoh, new Vector3 (hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),  Pharaoh.transform.rotation) as Transform;
															GameObject Unit1 = q.gameObject;
															Unit1.GetComponent<Pharaoh>().gameController = myGameController;
													myGameController.faith1 = myGameController.faith1 - 100;
														ThrothIdolSelected = false;
													myGameController.abilitySelected = 0;
													print ("Pharaoh created");
														break;
													case 2:

													Transform w = Instantiate (Archer, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),  Archer.transform.rotation) as Transform;
															GameObject Unit2 = w.gameObject;
															Unit2.GetComponent<Archer>().gameController = myGameController;
															myGameController.faith1 = myGameController.faith1 - 100;
													myGameController.abilitySelected = 0;
													print ("Archer created");
														ThrothIdolSelected = false;
														break;
													case 3:

															Transform e = Instantiate (FootSoldier1, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), FootSoldier1.transform.rotation) as Transform;
															GameObject Unit3 = e.gameObject;
															Unit3.GetComponent<FootSoldier>().gameController = myGameController;
													myGameController.faith1 = myGameController.faith1 - 100;
													myGameController.abilitySelected = 0;
													print ("FootSoldier created");
														ThrothIdolSelected = false;
														break;
													case 4:

													Transform r = Instantiate (Priest, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),  Priest.transform.rotation) as Transform;
															GameObject Unit4 = r.gameObject;
															Unit4.GetComponent<Priest>().gameController = myGameController;
													myGameController.faith1 = myGameController.faith1 - 100;
													myGameController.abilitySelected = 0;
													print ("Priest created");
														ThrothIdolSelected = false;
														break;
													case 5:

													Transform t = Instantiate (RoyalGuard, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),  RoyalGuard.transform.rotation) as Transform;
															GameObject Unit5 = t.gameObject;
															Unit5.GetComponent<RoyalGuard>().gameController = myGameController;
													myGameController.faith1 = myGameController.faith1 - 100;
													myGameController.abilitySelected = 0;
													print ("RoyalGuard created");
														ThrothIdolSelected = false;
														break;
													case 6:

													Transform y = Instantiate (Slinger, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),  Slinger.transform.rotation) as Transform;
															GameObject Unit6 = y.gameObject;
															Unit6.GetComponent<Slinger>().gameController = myGameController;
													print ("Slinger created");
													myGameController.abilitySelected = 0;
													myGameController.faith1 = myGameController.faith1 - 100;

														ThrothIdolSelected = false;
														break;
													case 7:

													Transform u = Instantiate (Spearman, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Spearman.transform.rotation) as Transform;
															GameObject Unit7 = u.gameObject;
															Unit7.GetComponent<Spearman>().gameController = myGameController;
													print ("Spearman created");
															myGameController.faith1 = myGameController.faith1 - 100;
													myGameController.abilitySelected = 0;
														ThrothIdolSelected = false;
														break;
								}
							}
						}
										ThrothIdolSelected = false;
										myGameController.abilitySelected = 0;
										UnitNumber = 0;
					}
									}
								}
							else
							{
								ThrothIdolSelected = false;
								myGameController.abilitySelected = 0;
								UnitNumber = 0;
							}
							}
						}
					}
					else
					{
						print ("Player 1 doesn't have enough faith to use Book of Throth.");
						ThrothIdolSelected = false;
					myGameController.abilitySelected = 0;
					}
				}
				else
			{

		if(Input.GetMouseButtonDown (0)) 
		{	
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
					
			if (Physics.Raycast (ray, out hit)) 
			{								
				if (hit.collider != null) 
				{										
					if (hit.collider.tag == "Idol") 
					{											
						Idol = hit.collider.gameObject;
							if (Idol.GetComponent<Idol>().PlayerNumber == 1)
						IdolSelected = true;
					}
					if (hit.collider.tag == "Tile") 
					{
						if (IdolSelected == true)
						{
							if (((Idol.transform.position.x + 1.5f) >= (hit.collider.transform.position.x)) && ((Idol.transform.position.x - 1.5f) <= (hit.collider.transform.position.x))) 
							{												
								if (((Idol.transform.position.z + 2) >= (hit.collider.transform.position.z)) && ((Idol.transform.position.z - 2) <= (hit.collider.transform.position.z))) 
								{
									switch (Unit)
									{
									case 1:
											if (myGameController.faith1 >= 200)
											{
													Transform q = Instantiate (Pharaoh, new Vector3 (hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Pharaoh.transform.rotation) as Transform;
											GameObject Unit1 = q.gameObject;
											Unit1.GetComponent<Pharaoh>().gameController = myGameController;
												myGameController.faith1 = myGameController.faith1 - 200;
											}
											else
												print ("Not enough faith to create a Pharaoh");
											IdolSelected = false;
											Unit = 0;
										break;
									case 2:
											if (myGameController.faith1 >= 100)
											{
													Transform w = Instantiate (Archer, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Archer.transform.rotation) as Transform;
										GameObject Unit2 = w.gameObject;
										Unit2.GetComponent<Archer>().gameController = myGameController;
												myGameController.faith1 = myGameController.faith1 - 100;
										}
										else
											print ("Not enough faith to create a Archer");
										IdolSelected = false;
												Unit = 0;
										break;
									case 3:
											if (myGameController.faith1 >= 75)
											{
										Transform e = Instantiate (FootSoldier1, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), FootSoldier1.transform.rotation) as Transform;
										GameObject Unit3 = e.gameObject;
										Unit3.GetComponent<FootSoldier>().gameController = myGameController;
												myGameController.faith1 = myGameController.faith1 - 75;
									}
									else
										print ("Not enough faith to create a Foot Soldier");
									IdolSelected = false;
												Unit = 0;
										break;
									case 4:
											if (myGameController.faith1 >= 50)
											{
													Transform r = Instantiate (Priest, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Priest.transform.rotation) as Transform;
										GameObject Unit4 = r.gameObject;
										Unit4.GetComponent<Priest>().gameController = myGameController;
												myGameController.faith1 = myGameController.faith1 - 50;
								}
								else
									print ("Not enough faith to create a Priest");
								IdolSelected = false;
												Unit = 0;
										break;
									case 5:
											if (myGameController.faith1 >= 150)
											{
													Transform t = Instantiate (RoyalGuard, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), RoyalGuard.transform.rotation) as Transform;
										GameObject Unit5 = t.gameObject;
										Unit5.GetComponent<RoyalGuard>().gameController = myGameController;
												myGameController.faith1 = myGameController.faith1 - 150;
							}
							else
								print ("Not enough faith to create a Royal Guard");
							IdolSelected = false;
												Unit = 0;
										break;
									case 6:
											if (myGameController.faith1 >= 50)
											{
													Transform y = Instantiate (Slinger, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Slinger.transform.rotation) as Transform;
										GameObject Unit6 = y.gameObject;
										Unit6.GetComponent<Slinger>().gameController = myGameController;
										
												myGameController.faith1 = myGameController.faith1 - 50;
						}
						else
							print ("Not enough faith to create a Slinger");
						IdolSelected = false;
												Unit = 0;
										break;
									case 7:
											if (myGameController.faith1 >= 100)
											{
													Transform u = Instantiate (Spearman, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Spearman.transform.rotation) as Transform;
										GameObject Unit7 = u.gameObject;
										Unit7.GetComponent<Spearman>().gameController = myGameController;
										
												myGameController.faith1 = myGameController.faith1 - 100;
					}
					else
						print ("Not enough faith to create a Spearman");
					IdolSelected = false;
												Unit = 0;
										break;
									}

								}																								
							}
									IdolSelected = false;
									Unit = 0;
						}
					}
				}
				else
				{					

						IdolSelected = false;
							Unit = 0;
				}
						
			}
				
		}

	}
			}
		if (myGameController.playersTurn == 2)
		{
			/*
			if (Input.GetKeyDown (KeyCode.Q))
				Unit = 1;
			if (Input.GetKeyDown (KeyCode.W))
				Unit = 2;
			if (Input.GetKeyDown (KeyCode.E))
				Unit = 3;
			if (Input.GetKeyDown (KeyCode.R))
				Unit = 4;
			if (Input.GetKeyDown (KeyCode.T))
				Unit = 5;
			if (Input.GetKeyDown (KeyCode.Y))
				Unit = 6;
			if (Input.GetKeyDown (KeyCode.U))
				Unit = 7;
				*/
			if (myGameController.abilitySelected == 7)
			{
				if (myGameController.faith2 >= 100)
				{
					if (Input.GetMouseButtonDown(0))
					{
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider != null)
							{
								
								if (hit.collider.tag == "Idol")
								{
									if (hit.collider.gameObject.GetComponent<Idol>().PlayerNumber == myGameController.playersTurn)
									{
										Idol = hit.collider.gameObject;
										ThrothIdolSelected = true;
										if (ThrothIdolSelected == true)
										{
											UnitNumber = Random.Range(1, 8);
											print ( UnitNumber);
										}
										
									}
								}
								if (hit.collider.tag == "Tile") 
								{
									if (ThrothIdolSelected == true)
									{
										if (((Idol.transform.position.x + 1.5f) >= (hit.collider.transform.position.x)) && ((Idol.transform.position.x - 1.5f) <= (hit.collider.transform.position.x))) 
										{												
											if (((Idol.transform.position.z + 2) >= (hit.collider.transform.position.z)) && ((Idol.transform.position.z - 2) <= (hit.collider.transform.position.z))) 
											{
												switch (UnitNumber)
												{
												case 1:
													
													Transform q = Instantiate (Pharaoh2, new Vector3 (hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Pharaoh2.transform.rotation) as Transform;
													GameObject Unit1 = q.gameObject;
													Unit1.GetComponent<Pharaoh>().gameController = myGameController;
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												case 2:
													
													Transform w = Instantiate (Archer2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Archer2.transform.rotation) as Transform;
													GameObject Unit2 = w.gameObject;
													Unit2.GetComponent<Archer>().gameController = myGameController;
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												case 3:
													
													Transform e = Instantiate (FootSoldier2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), FootSoldier2.transform.rotation) as Transform;
													GameObject Unit3 = e.gameObject;
													Unit3.GetComponent<FootSoldier>().gameController = myGameController;
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												case 4:
													
													Transform r = Instantiate (Priest2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),Priest2.transform.rotation) as Transform;
													GameObject Unit4 = r.gameObject;
													Unit4.GetComponent<Priest>().gameController = myGameController;
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												case 5:
													
													Transform t = Instantiate (RoyalGuard2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),RoyalGuard2.transform.rotation) as Transform;
													GameObject Unit5 = t.gameObject;
													Unit5.GetComponent<RoyalGuard>().gameController = myGameController;
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												case 6:
													
													Transform y = Instantiate (Slinger2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Slinger2.transform.rotation) as Transform;
													GameObject Unit6 = y.gameObject;
													Unit6.GetComponent<Slinger>().gameController = myGameController;
													
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												case 7:
													
													Transform u = Instantiate (Spearman2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Spearman2.transform.rotation) as Transform;
													GameObject Unit7 = u.gameObject;
													Unit7.GetComponent<Spearman>().gameController = myGameController;
													
													myGameController.faith2 = myGameController.faith2 - 100;
													myGameController.abilitySelected = 0;
													ThrothIdolSelected = false;
													break;
												}
											}
										}
										ThrothIdolSelected = false;
										myGameController.abilitySelected = 0;
										UnitNumber = 0;
									}
								}
							}
							else
							{
								ThrothIdolSelected = false;
								myGameController.abilitySelected = 0;
								UnitNumber = 0;
							}
						}
					}
				}
				else
				{
					print ("Player 2 doesn't have enough faith to use Book of Throth.");
					ThrothIdolSelected = false;
					myGameController.abilitySelected = 0;
				}
			}
			else
			{
			if(Input.GetMouseButtonDown (0)) 
			{	
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				
				if (Physics.Raycast (ray, out hit)) 
				{								
					if (hit.collider != null) 
					{										
						if (hit.collider.tag == "Idol") 
						{											
							Idol = hit.collider.gameObject;
							if (Idol.GetComponent<Idol>().PlayerNumber == 2)
								IdolSelected = true;
						}
						if (hit.collider.tag == "Tile") 
						{

							if (IdolSelected == true)
							{

								if (((Idol.transform.position.x + 1.5f) >= (hit.collider.transform.position.x)) && ((Idol.transform.position.x - 1.5f) <= (hit.collider.transform.position.x))) 
								{												
									if (((Idol.transform.position.z + 2) >= (hit.collider.transform.position.z)) && ((Idol.transform.position.z - 2) <= (hit.collider.transform.position.z))) 
									{
											print (Unit);
										switch (Unit)
										{
										case 1:
											if (myGameController.faith2 >= 200)
											{
													Transform q = Instantiate (Pharaoh2, new Vector3 (hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Pharaoh2.transform.rotation) as Transform;
												GameObject Unit1 = q.gameObject;
												Unit1.GetComponent<Pharaoh>().gameController = myGameController;
												myGameController.faith2 = myGameController.faith2 - 200;
											}
											else
												print ("Not enough faith to create a Pharaoh");
											IdolSelected = false;
												Unit = 0;
											break;
										case 2:
											if (myGameController.faith2 >= 100)
											{
													Transform w = Instantiate (Archer2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Archer2.transform.rotation) as Transform;
												GameObject Unit2 = w.gameObject;
												Unit2.GetComponent<Archer>().gameController = myGameController;
												myGameController.faith2 = myGameController.faith2 - 100;
											}
											else
												print ("Not enough faith to create a Archer");
											IdolSelected = false;
												Unit = 0;
											break;
										case 3:
											if (myGameController.faith2 >= 75)
											{
													Transform e = Instantiate (FootSoldier2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), FootSoldier2.transform.rotation) as Transform;
												GameObject Unit3 = e.gameObject;
												Unit3.GetComponent<FootSoldier>().gameController = myGameController;
												myGameController.faith2 = myGameController.faith2 - 75;
											}
											else
												print ("Not enough faith to create a Foot Soldier");
											IdolSelected = false;
												Unit = 0;
											break;
										case 4:
											if (myGameController.faith2 >= 50)
											{
													Transform r = Instantiate (Priest2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Priest2.transform.rotation) as Transform;
												GameObject Unit4 = r.gameObject;
												Unit4.GetComponent<Priest>().gameController = myGameController;
												myGameController.faith2 = myGameController.faith2 - 50;
											}
											else
												print ("Not enough faith to create a Priest");
											IdolSelected = false;
												Unit = 0;
											break;
										case 5:
											if (myGameController.faith2 >= 150)
											{
													Transform t = Instantiate (RoyalGuard2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), RoyalGuard2.transform.rotation) as Transform;
												GameObject Unit5 = t.gameObject;
												Unit5.GetComponent<RoyalGuard>().gameController = myGameController;
												myGameController.faith2 = myGameController.faith2 - 150;
											}
											else
												print ("Not enough faith to create a Royal Guard");
											IdolSelected = false;
												Unit = 0;
											break;
										case 6:
											if (myGameController.faith2 >= 50)
											{
													Transform y = Instantiate (Slinger2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z),Slinger2.transform.rotation) as Transform;
												GameObject Unit6 = y.gameObject;
												Unit6.GetComponent<Slinger>().gameController = myGameController;
												IdolSelected = false;
												myGameController.faith2 = myGameController.faith2 - 50;
											}
											else
												print ("Not enough faith to create a Slinger");
											IdolSelected = false;
												Unit = 0;
											break;
										case 7:
											if (myGameController.faith2 >= 100)
											{
													Transform u = Instantiate (Spearman2, new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z), Spearman2.transform.rotation) as Transform;
												GameObject Unit7 = u.gameObject;
												Unit7.GetComponent<Spearman>().gameController = myGameController;
												IdolSelected = false;
												myGameController.faith2 = myGameController.faith2 - 100;
											}
											else
												print ("Not enough faith to create a Spearman");
											IdolSelected = false;
												Unit = 0;
											break;
										}
										
									}

								}

										IdolSelected = false;
									Unit = 0;

							}
						}
					}
					else
					{					
						
						IdolSelected = false;
							Unit = 0;
					}
					
				}
				
			}
			}
		}

		if(ForceIdolSelected ==true){
			//IdolSelected = true;
			ForceIdolSelected = false;}

		}


}
