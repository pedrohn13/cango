using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoiSpanwn : MonoBehaviour {



	private float currentRateSpanw;

	public GameObject prefab;

	public List<GameObject> boi; 




	//essa variavel serve para que nao crie mais de uma vez os bois
	// pq as vezes quando pulava e ele batia denovo
	// criava mais bois, e dava problemas
	private bool houveCollision = true;


	// Use this for initialization
	void Start () {
 		

	}

	void OnTriggerEnter2D(Collider2D other) {
		// se houver uma colisao com o SpawnCheck ele cria uma certa quantidade de bois
		// definida na ferramenta 
		if(other.CompareTag("SpawnCheck")){
			if(houveCollision){
			
					GameObject tempBoi = Instantiate (prefab, new Vector3 (transform.position.x,
				                                                       transform.position.y, transform.position.z), 
					                                  						Quaternion.identity) as GameObject;
					boi.Add (tempBoi);
			

				houveCollision = false;
			}
		}
	}
	
	
	void Update () {
	
	}

}
