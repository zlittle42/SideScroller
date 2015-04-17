using UnityEngine;
using System.Collections;

public class mySpawner : MonoBehaviour {
	public Transform spawn;
	public GameObject[] characters;
	public int[] spawnQueue = new int[8];
	float timeCount;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if (timeCount >= 3) 
		{
			Instantiate (characters [spawnQueue[0]], spawn.position, spawn.rotation);
			timeCount = 0;
		}
	}
	public void spawnChar(int charToSpawn)
	{
		for (int i = 0; i < spawnQueue.Length; i ++) 
		{
			if(spawnQueue[i] == 0)
			{
				spawnQueue[i] = charToSpawn;
				break;

			}
		}
	}
}
