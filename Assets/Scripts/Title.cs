using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.anyKey)
            {
                SceneManager.LoadScene(1);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            StartCoroutine(Restart());
       
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
