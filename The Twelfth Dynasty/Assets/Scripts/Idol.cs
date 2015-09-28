using UnityEngine;
using System.Collections;

public class Idol : MonoBehaviour {
	public int Health;
	public Vector3 Position;
	public int PlayerNumber;
	// Use this for initialization
	void Start () {
		Health = 2000;
		Position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
