using UnityEngine;
using System.Collections;

public class RaycastSelection : MonoBehaviour {
	
	public bool itemSelected;
	public Vector3 itemSelectedPosition;
	public Vector3 target;
	
	// Use this for initialization
	void Start () 
	{
		
		
		
		
	}

	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{					
					if (itemSelected == false)
					{
						itemSelectedPosition = hit.collider.transform.position;
						itemSelected = true;
						print("itemSelected = true");
					}
					else
					{
						hit.collider.transform.position = itemSelectedPosition;
						itemSelected = false;
						print("itemSelected = false");
					}
					
				}
				
				
			}
			else
			{
				itemSelected = false;
				print("itemSelected = false");
			}
		}
		
	}
}
