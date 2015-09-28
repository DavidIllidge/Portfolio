using UnityEngine;
using System.Collections;

public class ImportPrefabs : MonoBehaviour {
	public Transform Pharaoh;
	public Transform Archer;
	public Transform FootSoldier1;
	public Transform Priest;
	public Transform RoyalGuard;
	public Transform Slinger;
	public Transform Spearman;
	
	public Transform Pharaoh2;
	public Transform Archer2;
	public Transform FootSoldier2;
	public Transform Priest2;
	public Transform RoyalGuard2;
	public Transform Slinger2;
	public Transform Spearman2;
	public KeepOnLoadPlayer1 LoadUnit;

	public MovePiece myGameController;

	Vector3 Zero = new Vector3 (0, 0, 0);
	/*GameObject Unit1;
	GameObject Unit2;
	GameObject Unit3;
	GameObject Unit4;
	GameObject Unit5;
	GameObject Unit6;
	GameObject Unit7;
	GameObject Unit8;
	GameObject Unit9;
	GameObject Unit10;*/
	// Use this for initialization
	void Start () {
		var gos = GameObject.FindGameObjectsWithTag("KeepOnLoad");
		foreach (GameObject go in gos) {
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position1, Pharaoh.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position2, Pharaoh.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position3, Pharaoh.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position4, Pharaoh.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Pharaoh>().gameController = myGameController;}
			}
				if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position5, Pharaoh.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position6, Pharaoh.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
				Unit6.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position7, Pharaoh.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position8, Pharaoh.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position9, Pharaoh.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (Pharaoh, go.GetComponent<KeepOnLoadPlayer1> ().Position10, Pharaoh.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Pharaoh>().gameController = myGameController;}
			}



			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position1, Archer.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position2, Archer.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position3, Archer.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position4, Archer.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position5, Archer.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position6, Archer.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position7, Archer.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position8, Archer.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position9, Archer.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (Archer, go.GetComponent<KeepOnLoadPlayer1> ().Position10, Archer.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Archer>().gameController = myGameController;}
			}


			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position1, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position2, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position3, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position4, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position5, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position6, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position7, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position8, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position9, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (FootSoldier1, go.GetComponent<KeepOnLoadPlayer1> ().Position10, FootSoldier1.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<FootSoldier>().gameController = myGameController;}
			}


			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position1, Priest.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position2, Priest.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
				Unit2.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position3, Priest.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
			Unit3.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position4, Priest.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position5, Priest.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position6, Priest.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position7, Priest.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position8, Priest.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position9, Priest.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (Priest, go.GetComponent<KeepOnLoadPlayer1> ().Position10, Priest.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Priest>().gameController = myGameController;}
			}


			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position1, RoyalGuard.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position2,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position3,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position4,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position5, RoyalGuard.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position6,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position7,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position8,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position9,  RoyalGuard.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (RoyalGuard, go.GetComponent<KeepOnLoadPlayer1> ().Position10, RoyalGuard.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<RoyalGuard>().gameController = myGameController;}
			}


			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position1, Slinger.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position2, Slinger.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position3, Slinger.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position4, Slinger.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position5, Slinger.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position6, Slinger.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position7, Slinger.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position8, Slinger.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position9, Slinger.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (Slinger, go.GetComponent<KeepOnLoadPlayer1> ().Position10, Slinger.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Slinger>().gameController = myGameController;}
			}


			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit1 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position1 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position1, Spearman.transform.rotation) as Transform;
				GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit2 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position2 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position2, Spearman.transform.rotation) as Transform;
				GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit3 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position3 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position3, Spearman.transform.rotation) as Transform;
				GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit4 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position4 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position4, Spearman.transform.rotation) as Transform;
				GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit5 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position5 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position5, Spearman.transform.rotation) as Transform;
				GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit6 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position6 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position6, Spearman.transform.rotation) as Transform;
				GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit7 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position7 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position7, Spearman.transform.rotation) as Transform;
				GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit8 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position8 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position8, Spearman.transform.rotation) as Transform;
				GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit9 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position9 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position9, Spearman.transform.rotation) as Transform;
				GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer1> ().Unit10 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer1> ().Position10 != Zero){
					Transform t = Instantiate (Spearman, go.GetComponent<KeepOnLoadPlayer1> ().Position10, Spearman.transform.rotation) as Transform;
				GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Spearman>().gameController = myGameController;}
			}
		}



		var gos2 = GameObject.FindGameObjectsWithTag("KeepOnLoad2");
		foreach (GameObject go in gos2) {
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position1, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position2, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position7, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position8, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position9, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Pharaoh")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (Pharaoh2, go.GetComponent<KeepOnLoadPlayer2> ().Position10, Pharaoh2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Pharaoh>().gameController = myGameController;}
			}
			
			
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position1, Archer2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position2, Archer2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, Archer2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, Archer2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, Archer2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, Archer2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position7, Archer2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position8, Archer2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position9, Archer2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Archer>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Archer")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (Archer2, go.GetComponent<KeepOnLoadPlayer2> ().Position10, Archer2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Archer>().gameController = myGameController;}
			}
			
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position1, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position2, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position7, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position8, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position9, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Foot Soldier")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (FootSoldier2, go.GetComponent<KeepOnLoadPlayer2> ().Position10, FootSoldier2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<FootSoldier>().gameController = myGameController;}
			}
			
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position1, Priest2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position2, Priest2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, Priest2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, Priest2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, Priest2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, Priest2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position7, Priest2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position8,Priest2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position9, Priest2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Priest>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Priest")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (Priest2, go.GetComponent<KeepOnLoadPlayer2> ().Position10, Priest2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Priest>().gameController = myGameController;}
			}
			
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position1, RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position2,  RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position7,  RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position8,  RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position9,  RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Royal Guard")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (RoyalGuard2, go.GetComponent<KeepOnLoadPlayer2> ().Position10,  RoyalGuard2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<RoyalGuard>().gameController = myGameController;}
			}
			
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position1,  Slinger2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position2, Slinger2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, Slinger2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, Slinger2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, Slinger2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, Slinger2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position7, Slinger2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position8, Slinger2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position9, Slinger2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Slinger>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Slinger")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (Slinger2, go.GetComponent<KeepOnLoadPlayer2> ().Position10, Slinger2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Slinger>().gameController = myGameController;}
			}
			
			
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit1 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position1 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position1, Spearman2.transform.rotation) as Transform;
					GameObject Unit1 = t.gameObject;
					Unit1.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit2 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position2 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position2, Spearman2.transform.rotation) as Transform;
					GameObject Unit2 = t.gameObject;
					Unit2.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit3 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position3 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position3, Spearman2.transform.rotation) as Transform;
					GameObject Unit3 = t.gameObject;
					Unit3.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit4 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position4 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position4, Spearman2.transform.rotation) as Transform;
					GameObject Unit4 = t.gameObject;
					Unit4.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit5 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position5 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position5, Spearman2.transform.rotation) as Transform;
					GameObject Unit5 = t.gameObject;
					Unit5.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit6 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position6 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position6, Spearman2.transform.rotation) as Transform;
					GameObject Unit6 = t.gameObject;
					Unit6.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit7 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position7 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position7, Spearman2.transform.rotation) as Transform;
					GameObject Unit7 = t.gameObject;
					Unit7.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit8 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position8 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position8, Spearman2.transform.rotation) as Transform;
					GameObject Unit8 = t.gameObject;
					Unit8.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit9 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position9 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position9, Spearman2.transform.rotation) as Transform;
					GameObject Unit9 = t.gameObject;
					Unit9.GetComponent<Spearman>().gameController = myGameController;}
			}
			if (go.GetComponent<KeepOnLoadPlayer2> ().Unit10 == "Spearman")
			{
				if (go.GetComponent<KeepOnLoadPlayer2> ().Position10 != Zero){
					Transform t = Instantiate (Spearman2, go.GetComponent<KeepOnLoadPlayer2> ().Position10, Spearman2.transform.rotation) as Transform;
					GameObject Unit10 = t.gameObject;
					Unit10.GetComponent<Spearman>().gameController = myGameController;}
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
