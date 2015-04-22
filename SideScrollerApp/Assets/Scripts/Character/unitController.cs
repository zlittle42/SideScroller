using UnityEngine;
using System.Collections;

public class unitController : MonoBehaviour {
	public float moveSpeed = 1f;
	public string unitTag;
	public Rigidbody rb;
	public Vector3 move;

	// Use this for initialization

	void Start () {
		rb = GetComponent<Rigidbody> ();
		unitTag = gameObject.tag;
		Debug.Log(unitTag);
		if(unitTag == "myUnit")
		{
			//moveSpeed = 2f;
		}
		else if (unitTag == "enemyUnit")
		{
			moveSpeed = -moveSpeed;
		}
	}
	
	// Update is called once per frame
	void Update () {
		move = new Vector3(moveSpeed,0,0);
	}
	void FixedUpdate () {
		transform.rotation = Quaternion.Euler (transform.rotation.eulerAngles.x,0,0);
		transform.position = new Vector3 (transform.position.x, 2.3f, 0);
		rb.MovePosition (transform.position + move * Time.deltaTime);
	}
}
