using UnityEngine;
using System.Collections;

public class CameraSelection : MonoBehaviour {
	public GameObject Camera1;
	public GameObject Camera2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1))
		{
			Camera2.camera.active = false;
			Camera1.camera.active = true;
			Camera1.transform.position = new Vector3(-13, 7.5f, -1.9f);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2))
		{
			
			Camera1.camera.active = false;
			Camera2.camera.active = true;
			Camera2.transform.position = new Vector3(13, 7.5f, 1.9f);
			//Matrix4x4 mat = Camera.main.projectionMatrix;
			//mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
			//Camera.main.projectionMatrix = mat;
		}
	}
}
