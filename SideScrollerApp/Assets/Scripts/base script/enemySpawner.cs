using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
	public Transform spawn; 
	public GameObject baseEnemy;
	public float timeCount = 0;
	// Use this for initialization
	void Start () {
		spawn = transform.FindChild("spawnPoint");
		Instantiate(baseEnemy,spawn.position,spawn.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if (timeCount >= 3) 
		{
			Instantiate(baseEnemy,spawn.position,spawn.rotation);
			timeCount = 0;
		}
	}
}
