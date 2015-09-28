using UnityEngine;
using System.Collections;

public class KeepOnLoadPlayer1 : MonoBehaviour {
	public Vector3 Position1;
	public Vector3 Position2;
	public Vector3 Position3;
	public Vector3 Position4;
	public Vector3 Position5;
	public Vector3 Position6;
	public Vector3 Position7;
	public Vector3 Position8;
	public Vector3 Position9;
	public Vector3 Position10;
	//static GameObject instance;
	public string Unit1;
	public string Unit2;
	public string Unit3;
	public string Unit4;
	public string Unit5;
	public string Unit6;
	public string Unit7;
	public string Unit8;
	public string Unit9;
	public string Unit10;

	public string Command1;
	public string Command2;
	public string Command3;
	public string Command4;

	// Use this for initialization
	void Start () { 

	
	}
	void Awake() {
		//instance = this;
		DontDestroyOnLoad(gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
