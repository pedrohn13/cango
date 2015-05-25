using UnityEngine;
using System.Collections;

public class BoiControll : MonoBehaviour {
	public float velocity;
	public int HP;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// para depois que ele sair da tela ser destruido
	void OnTriggerEnter2D(Collider2D coll){	
		if (coll.gameObject.tag == "DestroyInimigos") {
			Destroy(gameObject);
		} else if (coll.gameObject.tag == "Bala") {
			HP--;
		} 
		// se o numero de balas que o boi foi atingido e igual ao numero de
		// balas definido que nos queremos que ele morra ,entao ele morre
		if (HP == 0) {
			Destroy(gameObject);
		}

	}

	void FixedUpdate(){
		Vector3 v = new Vector3 (-1,0,0);
		transform.position += v * velocity * Time.deltaTime;
	}
}
