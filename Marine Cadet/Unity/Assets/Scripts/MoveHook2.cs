using UnityEngine;
using System.Collections;

public class MoveHook2 : MonoBehaviour {
	Vector3 hookPosition;
	Vector3 moveUp;
	Vector3 moveDown;
	bool HookFish = true;
	public bool extendHook = false;
	public GameObject Fisherman;
	public GameObject closest = null;
	public bool FishRemaining2 = true;
	public bool getNewHookPosition = true;
	// Use this for initialization
	void Start () {
		hookPosition = transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	void Move()
	{
		
		
		if (Fisherman.GetComponent<moveFisherman2>().faceLeft == true)
		{
			moveUp = new Vector3(Fisherman.transform.position.x - 0.7f, Fisherman.transform.position.y - 1.23f, Fisherman.transform.position.z-0.205f);
			moveDown = new Vector3(Fisherman.transform.position.x - 0.7f, Fisherman.transform.position.y - 3.23f, Fisherman.transform.position.z-0.205f);
		}
		if (Fisherman.GetComponent<moveFisherman2>().faceRight == true)
		{
			moveUp = new Vector3(Fisherman.transform.position.x + 0.7f, Fisherman.transform.position.y - 1.23f, Fisherman.transform.position.z+0.205f);
			moveDown = new Vector3(Fisherman.transform.position.x + 0.7f, Fisherman.transform.position.y - 3.23f, Fisherman.transform.position.z+0.205f);
		}
		
		/*if (getNewHookPosition == true)
		{
			getNewHookPosition = false;
			moveUp = transform.localPosition;
			moveDown = new Vector3 (transform.localPosition.x, transform.localPosition.y - 2, transform.localPosition.z);
		}*/
		if (extendHook == true) 
		{
			hookPosition = moveDown;
		} 
		else 
		{
			hookPosition = moveUp;
			HookFish = true;
		}
		
		
		if (hookPosition == moveDown)
		{
			if (HookFish == true)
			{
				
				Invoke("FindClosestFish", 0.1f);
				if (FindClosestFish() == null)
					FishRemaining2 = false;
				else
				{
					HookFish = false;
					FindClosestFish().gameObject.GetComponent<MoveTowardHook>().FishHookNumber = 2;
					FindClosestFish().gameObject.GetComponent<MoveTowardHook>().attracted = true;
					FindClosestFish().gameObject.GetComponent<MoveTowardHook>().rotate = true;
					//print("attracted = true");
					FishRemaining2 = true;
				}
			}
		}
		
		
		transform.position = Vector3.MoveTowards(transform.position, hookPosition, Time.deltaTime*1.5f);
	}
	
	GameObject FindClosestFish() {
		var gos = GameObject.FindGameObjectsWithTag("fish");
		var distance = Mathf.Infinity;
		closest = null;
		foreach (GameObject go in gos) 
		{
			if(go.gameObject.GetComponent<MoveTowardHook>().attracted == false)
			{
				Vector3 diff = go.transform.position - transform.position;
				float curDistance = diff.sqrMagnitude;
				if (curDistance < distance) {
					closest = go;
					distance = curDistance;
				}
			}
		}
		
		return closest;
	}
}
