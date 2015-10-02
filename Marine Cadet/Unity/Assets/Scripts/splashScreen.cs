using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {
	//private Vector3 startPosition;
	private Vector3 endPosition;
	// Use this for initialization
	void Start () {
		//startPosition = new Vector3 (-34, -5, 25);
		endPosition = new Vector3 (34, -5, 25);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, endPosition, Time.deltaTime * 0.25f);

		if(transform.position.x > 22)
			Application.LoadLevel("MainMenu_Scene");
	}
}
