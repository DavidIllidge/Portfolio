using UnityEngine;
using System.Collections;

public class Pharaoh : MonoBehaviour {

    public int Health;
	public int MaxHealth;
    public int Damage;
    public int MovementDistance;
	public MovePiece gameController;
    public bool Attacked;
    public bool Moved;
	public bool Ankh;
	public bool KnotOfIsis;
	public bool Charge;
	public bool ChargeApplied;
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
	    Health = 600;
		MaxHealth = 600;
        Damage = 400;
        AttackRange = 1;
        MovementDistance = 4;
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
