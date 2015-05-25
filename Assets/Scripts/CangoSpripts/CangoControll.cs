using UnityEngine;
using System.Collections;

public class CangoControll : MonoBehaviour {

	public float maxSpeed;
	private Rigidbody2D body;
	public float jumpForce;
	public float gravityDownScale;
	public LayerMask groundLayer;
	public GameObject groundCheck;
	private bool grounded;
	private float defaultGravity;
	private Animator animator;



	// Use this for initialization
	void Start () {
		this.body = this.GetComponent<Rigidbody2D> ();
		this.defaultGravity = this.body.gravityScale;
		this.animator = this.GetComponent<Animator> ();
	}

	void FixedUpdate() {
		this.body.velocity = new Vector2 (this.maxSpeed, this.body.velocity.y);
		this.animator.SetFloat("vSpeed",this.body.velocity.y);
	}
	
	// Update is called once per frame
	void Update () {

		this.grounded = Physics2D.OverlapCircle (new Vector2 (this.groundCheck.transform.position.x, this.groundCheck.transform.position.y), 0.2f,this.groundLayer);
		this.animator.SetBool ("grounded", this.grounded);
		
		if (this.grounded && Input.GetButtonDown ("Jump")) {
			this.body.AddForce (new Vector2 (0, this.jumpForce));
		}
		if (!this.grounded && Input.GetButtonUp ("Jump")) {
			this.body.gravityScale = this.gravityDownScale;
		}
		if (this.grounded) {
			this.body.gravityScale = this.defaultGravity;
		}
	}
}
