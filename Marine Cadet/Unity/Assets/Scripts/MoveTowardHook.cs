using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveTowardHook : MonoBehaviour {
	public GameObject FishHookObject1;
	public GameObject FishHookObject2;
	public Game2Raycast GameScript;
	public int FishHookNumber = 0;
	public GUIText GUIScore;
	private Vector3 newPosition;
	private Vector3 passivePosition;
	public bool attracted = false;
	public bool restartCoroutine = false;

	private Quaternion fishRotation;
	private Vector3 newDirection;

	bool previousFaceLeft = false;
	bool previousFaceRight = true;
	bool faceLeft = false;
	bool faceRight = true;
	public bool rotate = false;
	private Vector3 currentPosition;

	Vector3 startRot = new Vector3(0, 0, 0);
	Vector3 endRot = new Vector3(0, 180, 0);
	float duration = 1.0f;
	float timer = 0.0f;
	void Start () 

	{
		newPosition = transform.position;
		currentPosition = transform.position;
		StartCoroutine("WaitMethod");
	}

	void Update ()
	{

		if (restartCoroutine == true)
		{
			restartCoroutine = false;
			attracted = false;
			FishHookNumber = 0;
			StartCoroutine("WaitMethod");
		}
		if (attracted == true) 
		{
			if (FishHookNumber == 1)
			{
				newPosition = FishHookObject1.transform.position;
				previousFaceLeft = faceLeft;
				previousFaceRight = faceRight;
				if (rotate == true)
				{
					timer = 0;
					rotate = false;
				}
			}
			if (FishHookNumber == 2)
			{
				newPosition = FishHookObject2.transform.position;
				previousFaceLeft = faceLeft;
				previousFaceRight = faceRight;
				if (rotate == true)
				{
					timer = 0;
					rotate = false;

				}
			}
		}



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

		if ((faceLeft == true) && (previousFaceRight == true))
		{	
			timer += Time.deltaTime;
			transform.eulerAngles = Vector3.Lerp (startRot,endRot,timer/duration);
		}
		if ((faceRight == true)&&(previousFaceLeft == true))
		{			
			timer += Time.deltaTime;
			transform.eulerAngles = Vector3.Lerp (endRot,startRot,timer/duration);
			
		}

		transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime*1.5f);


		if (FishHookNumber == 1) 
		{
			if (transform.position == FishHookObject1.transform.position) 
			{
			FishHookObject1.GetComponent<MoveHook>().extendHook = false;
				if (FishHookObject1.transform.position.y == -0.98f)
				{
					Destroy (this.gameObject);
					GameScript.Score = GameScript.Score - 1;
					GUIScore.text = GameScript.Score.ToString();
				}
			}
		}
		if (FishHookNumber == 2) 
		{
			if (transform.position == FishHookObject2.transform.position) 
			{
				FishHookObject2.GetComponent<MoveHook2>().extendHook = false;
				if (FishHookObject2.transform.position.y == -0.9f)
				{
					Destroy (this.gameObject);
					GameScript.Score = GameScript.Score - 1;
					GUIScore.text = GameScript.Score.ToString();
				}
			}
		}



	}
	IEnumerator WaitMethod()
	{
		int passiveValue;
		do {
			passivePosition = new Vector3(Random.Range(-6.5f, 6.5f), Random.Range(-2.0f, -5.0f), Random.Range(4.3f, 4.7f));
			newPosition = passivePosition;
			timer = 0;
			previousFaceLeft = faceLeft;
			previousFaceRight = faceRight;
			yield return new WaitForSeconds(3);
		}
		while (attracted == false);
	}

}
