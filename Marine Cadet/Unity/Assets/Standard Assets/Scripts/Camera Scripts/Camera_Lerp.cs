using UnityEngine;
using System.Collections;

public class Camera_Lerp : MonoBehaviour 
{
	private Vector3 newPosition;
	
	
	
	
	//use this for initialization
	void start () 
	{
		newPosition = transform.position;	
	}
	
	//Update is called once per frame
	void Update () 
	{
		PositionChanging();
	}
	
	void PositionChanging()
	{
		Vector3 positionA = new Vector3(0, 0.8f, -2);
		Vector3 positionB = new Vector3(0, -1.5f, -2);
		
		if(Input.GetKeyDown(KeyCode.Q))
			newPosition = positionA;
		if(Input.GetKeyDown(KeyCode.E))
			newPosition = positionB;
		
		transform.position =  Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
	}
}
