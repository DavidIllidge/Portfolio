using UnityEngine;
using System.Collections;

public class TileMaterial : MonoBehaviour {
	public Texture StandardTile;
	public Texture BlueTile;
	public bool changeToBlue = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (changeToBlue == true)
			renderer.material.mainTexture = BlueTile;
		else
			renderer.material.mainTexture = StandardTile;
	}
}
