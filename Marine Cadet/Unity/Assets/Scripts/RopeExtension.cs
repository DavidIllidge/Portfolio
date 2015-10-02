using UnityEngine;
using System.Collections;

public class RopeExtension : MonoBehaviour {
	private Vector3 ropeScale;
	float movement;

	// Use this for initialization
	void Start () {
		ropeScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		Extend ();
	}

	void Extend()
	{
		Vector3 scaleExtend = new Vector3(0.03f, 2, 0.03f);
		Vector3 scaleShrink = new Vector3(0.03f, 1, 0.03f);
		if(Input.GetMouseButtonDown(1)){

			ropeScale = scaleExtend;
		}
		if(Input.GetMouseButtonDown(0)){
			
			ropeScale = scaleShrink;
		}
		this.transform.localScale = Vector3.Lerp(transform.localScale, ropeScale, Time.deltaTime);
	}

}
