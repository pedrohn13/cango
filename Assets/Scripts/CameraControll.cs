using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

	public Transform target;
	private float distance;
	private float height;
	public float xOffset;
	public float damping = 5.0f;
	public bool smoothRotation = true;

	// Use this for initialization
	void Start () {
		this.distance = this.transform.position.z;
		this.height = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
//		Vector3 wantedPosition = target.TransformPoint(0, height, distance);
		transform.position = Vector3.Lerp (transform.position, new Vector3(target.transform.position.x + xOffset,height,distance), Time.deltaTime * damping);
		
		if (smoothRotation) {
			Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
			transform.rotation = Quaternion.Slerp (transform.rotation, wantedRotation, 0);
		}
		
		else transform.LookAt (target, target.up);
	}
}
