using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mySpawner : MonoBehaviour {
	public Transform spawn;
	public GameObject[] characters;
	//public int[] spawnQueue = new int[8];
	public List<int> spawnQueue;
	float timeCount;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if (timeCount >= 3) 
		{
			if(spawnQueue[0] >= 0)
			{
				Instantiate (characters [spawnQueue[0]], spawn.position, spawn.rotation);
				spawnQueue.RemoveAt(0);
				spawnQueue.Add(-1);
			}
			timeCount = 0;
		}
	}
	public void spawnChar(int charToSpawn)
	{
		for (int i = 0; i < spawnQueue.Count; i ++) 
		{
			if(spawnQueue[i] == -1)
			{
				spawnQueue[i] = charToSpawn;
				break;

			}
		}
	}
}
