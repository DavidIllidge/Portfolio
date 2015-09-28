using UnityEngine;
using System.Collections;

public class Archer : MonoBehaviour {
	public MovePiece gameController;
	public int Health;
	public int MaxHealth;
	public int Damage;
	public int MovementDistance;
	public bool Attacked;
	public bool Moved;
	public bool Ankh;
	public bool KnotOfIsis;
	public bool Charge = false;
	public bool ChargeApplied = false;
	public bool PowerOfApep;
	public Vector3 Position;
	public Vector3 TargetPosition;
	public int AttackRange;
	public int PlayerNumber;
	public bool NextTurn = false;
	
	// Use this for initialization

	void Start () 
	{
		Ankh = false;
		Health = 100;
		MaxHealth = 100;
		Damage = 100;
		AttackRange = 6;
		MovementDistance = 3;
		Attacked = false;
		Moved = false;
		Position = this.transform.position;
		TargetPosition = Position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ChargeApplied == false)
		{
			if (Charge == true)
			{
				MovementDistance = MovementDistance * 2;
				ChargeApplied = true;
			}
		}
		if (NextTurn == true)
		{
			
			if (PowerOfApep == true)
			{
				Health = Health - 50;
				
			}
			NextTurn = false;
		}
		if (Health <= 0)
		{
			if (Ankh == true)
			{
				if (PlayerNumber == 1)
					gameController.Ankh1 = false;
				if(PlayerNumber == 2)
					gameController.Ankh1 = false;
			}
			if (KnotOfIsis == true)
			{
				if (PlayerNumber == 1)
					gameController.KnotOfIsis1 = false;
				if(PlayerNumber == 2)
					gameController.KnotOfIsis2 = false;
			}
			Destroy(this.gameObject);
			
			
		}
	}
}
