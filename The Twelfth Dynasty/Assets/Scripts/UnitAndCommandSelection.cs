using UnityEngine;
using System.Collections;

public class UnitAndCommandSelection : MonoBehaviour {
	
	public GameObject Unit1;
	public GameObject Unit2;
	public GameObject Unit3;
	public GameObject Unit4;
	public GameObject Unit5;
	public GameObject Unit6;
	public GameObject Unit7;
	public GameObject Unit8;
	public GameObject Unit9;
	public GameObject Unit10;
	public GameObject Command1;
	public GameObject Command2;
	public GameObject Command3;
	public GameObject Command4;
	public GUIText Unit1Text;
	public GUIText Unit2Text;
	public GUIText Unit3Text;
	public GUIText Unit4Text;
	public GUIText Unit5Text;
	public GUIText Unit6Text;
	public GUIText Unit7Text;
	public GUIText Unit8Text;
	public GUIText Unit9Text;
	public GUIText Unit10Text;
	public GUIText Command1Text;
	public GUIText Command2Text;
	public GUIText Command3Text;
	public GUIText Command4Text;
	
	private bool selected = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{					
					if (hit.collider.gameObject == Unit1)
					{
						Unit1Text.text = "Ray collided";
						print ("Unit1 hit");
					}
				}
				
				
			}
		}
		
		
		
		
		
	}
}
