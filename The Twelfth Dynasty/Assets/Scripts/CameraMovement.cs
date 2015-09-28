using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public bool invert;
	/*bool switch1 = true;
	bool switch2 = false;
	bool switch3 = false;*/
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.I))
		{
			switch1 = true;
			switch2 = false;
			switch3 = false;
		}
		if (Input.GetKeyDown (KeyCode.P))
		{
			switch1 = false;
			switch2 = true;
			switch3 = false;
		}
			
		if (Input.GetKeyDown (KeyCode.O))
		{
			switch1 = false;
			switch2 = false;
			switch3 = true;
		}

		if (switch1 == true)
			transform.position = Vector3.Lerp (transform.position, new Vector3 (-102, -73.5f, 0), Time.deltaTime);

		if (switch2 == true)
			transform.position = Vector3.Lerp (transform.position, new Vector3 (-102, 44.5f, 0), Time.deltaTime);

		if (switch3 == true)
			transform.position = Vector3.Lerp (transform.position, new Vector3 (-9.5f, 6.5f, 0), Time.deltaTime*0.3f);
*/
		if (this.camera.active == true)
		{
			if (invert == false)
		transform.position = new Vector3 (transform.position.x + Input.GetAxis ("Vertical"), transform.position.y + Input.GetAxis("Mouse ScrollWheel"), transform.position.z + Input.GetAxis ("Horizontal"));
			else
		transform.position = new Vector3 (transform.position.x - Input.GetAxis ("Vertical"), transform.position.y + Input.GetAxis("Mouse ScrollWheel"), transform.position.z - Input.GetAxis ("Horizontal"));

		if (transform.position.x > 30)
			transform.position = new Vector3 (30, transform.position.y + Input.GetAxis("Mouse ScrollWheel"), transform.position.z + Input.GetAxis ("Horizontal"));
		if (transform.position.x < -30)
			transform.position = new Vector3 (-30, transform.position.y + Input.GetAxis("Mouse ScrollWheel"), transform.position.z + Input.GetAxis ("Horizontal"));
		if (transform.position.z > 30)
			transform.position = new Vector3 (transform.position.x + Input.GetAxis ("Vertical"), transform.position.y + Input.GetAxis("Mouse ScrollWheel"), 30);
		if (transform.position.z < -30)
			transform.position = new Vector3 (transform.position.x + Input.GetAxis ("Vertical"), transform.position.y + Input.GetAxis("Mouse ScrollWheel"), -30);
		if (transform.position.y < 3)
			transform.position = new Vector3 (transform.position.x + Input.GetAxis ("Vertical"), 3, transform.position.z + Input.GetAxis ("Horizontal"));
		if (transform.position.y > 30)
			transform.position = new Vector3 (transform.position.x + Input.GetAxis ("Vertical"), 20, transform.position.z + Input.GetAxis ("Horizontal"));
		
		}


		}
	}

