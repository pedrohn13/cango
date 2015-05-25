using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public float velocity;
	public int power;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = new Vector3 (1,0,0);
		transform.position += v * velocity * Time.deltaTime;
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		string otherTag = coll.gameObject.tag;
		Debug.Log (otherTag);
		if (otherTag == "SpawnCheck" || otherTag == "Inimigos") {
			Destroy(gameObject);
		} 
		

		
	}
}
