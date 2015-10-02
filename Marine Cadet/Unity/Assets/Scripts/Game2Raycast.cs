using UnityEngine;
using System.Collections;

public class Game2Raycast : MonoBehaviour {

	public GameObject Hook1;
	public GameObject Hook2;
	public GameObject GameCamera;
	public GameObject endGame;
	public int Score = 12;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{					
					if (hit.collider.tag == "Hook1")
					{
						hit.collider.gameObject.GetComponent<MoveHook>().extendHook = false;
						FindClosestFish1();
						//print("extendHook = false");
					}
					if (hit.collider.tag == "Hook2")
					{
						hit.collider.gameObject.GetComponent<MoveHook2>().extendHook = false;
						FindClosestFish2();
						//print("extendHook = false");
					}
				}
			}
		}
		/*if ((Hook1.GetComponent<MoveHook> ().FishRemaining == false) && (Hook2.GetComponent<MoveHook2> ().FishRemaining2 == false)) 
		{
			print("Game Over here");
		}*/
		if (FishRemaining() == null)
		{
			if (GameCamera.GetComponent<CameraLerp>().play == true)
			{
				GameCamera.GetComponent<CameraLerp>().play = false;
				endGame.GetComponent<EndGame>().endGame = true;
			}
		}
	}
	void FindClosestFish1() {
		var gos = GameObject.FindGameObjectsWithTag("fish");
		GameObject closest = null;
		foreach (GameObject go in gos) 
		{
			if(go.gameObject.GetComponent<MoveTowardHook>().attracted == true)
			{
				if(go.gameObject.GetComponent<MoveTowardHook>().FishHookNumber == 1)
				{
					go.gameObject.GetComponent<MoveTowardHook>().FishHookNumber = 0;
					go.gameObject.GetComponent<MoveTowardHook>().restartCoroutine = true;
					Hook1.GetComponent<MoveHook> ().FishRemaining = true;
					Hook2.GetComponent<MoveHook2> ().FishRemaining2 = true;
				}
			}
		}
	}
	void FindClosestFish2() {
		var gos = GameObject.FindGameObjectsWithTag("fish");
		GameObject closest = null;
		foreach (GameObject go in gos) 
		{
			if(go.gameObject.GetComponent<MoveTowardHook>().attracted == true)
			{
				if(go.gameObject.GetComponent<MoveTowardHook>().FishHookNumber == 2)
				{
					go.gameObject.GetComponent<MoveTowardHook>().FishHookNumber = 0;
					go.gameObject.GetComponent<MoveTowardHook>().restartCoroutine = true;
					Hook1.GetComponent<MoveHook> ().FishRemaining = true;
					Hook2.GetComponent<MoveHook2> ().FishRemaining2 = true;
				}
			}
		}
	}
	GameObject FishRemaining() {
		var gos = GameObject.FindGameObjectsWithTag("fish");
		var distance = Mathf.Infinity;
		GameObject fishRemaining = null;
		foreach (GameObject go in gos) 
		{
			fishRemaining = go;
		
		}
		
		return fishRemaining;
	}

}
