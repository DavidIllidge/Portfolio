using UnityEngine;
using System.Collections;

public class forceOnEarth : MonoBehaviour {

	 

	void OnMouseDown() 
	{
		rigidbody.AddForce(Camera.main.transform.forward * 700);

		rigidbody.useGravity = true;

	}

}
