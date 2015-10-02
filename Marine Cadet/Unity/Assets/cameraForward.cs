using UnityEngine;
using System.Collections;

public class cameraForward : MonoBehaviour {
	public float zIncrement = 0;
	public bool pauseCamera = false;
	// Use this for initialization
	void Start () {
		zIncrement = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		zIncrement += 0.000031f;
		if (pauseCamera == false)
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + zIncrement);
	}
}
