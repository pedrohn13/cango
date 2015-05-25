using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BalaSpawn : MonoBehaviour {

	public int rateSpanw;	
	public int timer = 0;	
	public GameObject prefab;	
	public List<GameObject> balas; 	
	public int maxBalas;

	void Start () {

	}

	void FixedUpdate() {
		if (timer > rateSpanw) {		
			Atira ();
			timer = 0;
		}
		timer++;
	}

	public void Atira(){

		GameObject tempBalas = Instantiate (prefab, new Vector3 (transform.position.x,
			                                                         transform.position.y, transform.position.z), 
			                                    Quaternion.identity) as GameObject;
			balas.Add (tempBalas);



	}
}
