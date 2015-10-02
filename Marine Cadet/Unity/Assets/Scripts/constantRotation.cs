using UnityEngine;
using System.Collections;

public class constantRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


		transform.Rotate (0,40*Time.deltaTime,0); //rotates 50 degrees per second around z axis

	}
}
