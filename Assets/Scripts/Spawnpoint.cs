using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {

    public Transform[] spawnpoint;
    public GameObject enemy;
    public float time = 10f;
    float currentTime;

	// Use this for initialization
	void Start () {
        currentTime = time;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime -= Time.deltaTime;
		if (currentTime <= 0)
        {
            SpawnEnemy();
            currentTime = time;
        }
        
	}

    void SpawnEnemy() {
        Transform randomSpawnpoint = spawnpoint[Random.Range(0, spawnpoint.Length)];
        var baddies = (GameObject)Instantiate(enemy, randomSpawnpoint.position, randomSpawnpoint.rotation);
    }
}
