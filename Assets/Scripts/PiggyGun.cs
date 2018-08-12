using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyGun : MonoBehaviour {

    public GameObject Piggy;
    public Transform Chicken;
    public AudioClip angryChicken;
    public AudioSource speaker;
    public float speed;
    public float time;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }   
	}
    
    void Fire()
    {
        var piggy = (GameObject)Instantiate(
            Piggy,
            Chicken.position,
            Chicken.rotation);

        piggy.GetComponent<Rigidbody>().velocity = piggy.transform.forward * speed;

        speaker.PlayOneShot(angryChicken, 0.1F);

        Destroy(piggy, time);
    }
}
