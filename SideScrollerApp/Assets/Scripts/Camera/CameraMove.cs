using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	float speed = 10.0f;
	float leftBound = -10f;
	float rightBound = 10f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		transform.position += move * speed * Time.deltaTime;

		if(transform.position.x >= rightBound)
		{
			transform.position = new Vector3(rightBound,transform.position.y,transform.position.z);
			Debug.Log ("bounded");
		}
		else if(transform.position.x <= leftBound)
		{
			transform.position = new Vector3(leftBound,transform.position.y,transform.position.z);
			Debug.Log ("bounded");
		}
	}
}
