using UnityEngine;
using System.Collections;

public class ScoreMaster : MonoBehaviour {
	public int score2 = 0;
	public GUIText GUIScore;
	public bool click = true;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		score2 = 0;
		GUIScore.text = score2.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		GUIScore.text = score2.ToString();
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{	
					if (click == true)
					{
						if (hit.collider.tag == "orb")
						{
							score2 = score2 + 10;
							Destroy(hit.collider.gameObject);
						}
					}
				}
			}
		}
	}
}
