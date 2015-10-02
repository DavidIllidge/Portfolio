using UnityEngine;
using System.Collections;

public class moveFisherman2 : MonoBehaviour {
	private Vector3 newPosition;
	private Vector3 currentPosition;
	private Vector3 scale;
	public GameObject FishHookObject;
	public GameObject Fisherman;
	public bool extended = true;
	public bool newHook = false;
	public bool faceLeft = true;
	public bool faceRight = false;
	public bool move = false;
	private bool previousFaceLeft = true;
	private bool previousFaceRight = false;
	Vector3 startRot = new Vector3(0, 0, 0);
	Vector3 endRot = new Vector3(0, 180, 0);
	float duration = 2.0f;
	float timer = 0.0f;
	// Use this for initialization
	void Start () 
	{
		currentPosition = transform.position;
		//newPosition = transform.position;
		StartCoroutine("InitialHook");
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentPosition = transform.position;
		getNewPosition();
	}
	IEnumerator InitialHook()
	{
		yield return new WaitForSeconds(6);
		newHook = true;
		
		
	}
	void getNewPosition()
	{
		if (FishHookObject.transform.position.y == -0.9f)
		{
			if (newHook == true)
			{
				WaitAfterHooked();
				newHook = false;
				timer = 0;
				newPosition = new Vector3((Random.Range(-6.0f, 6.0f)), 0.33f, transform.position.z);
				extended = false;
				previousFaceLeft = faceLeft;
				previousFaceRight = faceRight;
				if (newPosition.x < currentPosition.x)
				{
					faceLeft = true;
					faceRight = false;
				}
				else
				{
					faceLeft = false;
					faceRight = true;		
				}
				
			}
			
			
		}	
		
		
		if (extended == false)
		{
			if ((faceLeft == true) && (previousFaceRight == true))
			{
				
				timer += Time.deltaTime;
				transform.eulerAngles = Vector3.Lerp (endRot,startRot,timer/duration);
				
				if (timer/duration > 1)
				{
					move = true;
				}
			}
			if ((faceRight == true)&&(previousFaceLeft == true))
			{
				
				timer += Time.deltaTime;
				transform.eulerAngles = Vector3.Lerp (startRot,endRot,timer/duration);
				
				if (timer/duration > 1)
				{
					move = true;
				}
			}			
			if (((faceRight == true)&&(previousFaceRight == true))	||	((faceLeft == true) && (previousFaceLeft == true)))
			{
				move = true;
			}
			
			if (currentPosition == newPosition)
			{
				move = false;
				extended = true;
				//call extendedHook
				FishHookObject.GetComponent<MoveHook2>().extendHook = true;
				FishHookObject.GetComponent<MoveHook2>().getNewHookPosition = true;
				newHook = true;
				
			}
			else
			{
				if (move == true)
				{
					transform.position = Vector3.MoveTowards(currentPosition, newPosition, Time.smoothDeltaTime*1.4f);
				}
			}
		}
	}
	IEnumerator WaitAfterHooked()
	{
		yield return new WaitForSeconds(0.5f);
	}
}
