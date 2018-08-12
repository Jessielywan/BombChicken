using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitFlash : MonoBehaviour {

    public bool getDamage = false;
    public Image bloodImage;
    public float timer = 2f;
    float currentTime;
    public int maxHealth;
    public int currentHealth;
    public SimpleHealthBar healthBar;
    

    // Use this for initialization
    void Start () {
        
        currentTime = timer;
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }

        currentTime -= Time.deltaTime;

        if (getDamage)
        {
            Color Opaque = new Color(1, 0, 0, 1);
            bloodImage.color = Color.Lerp(bloodImage.color, Opaque, 20 * Time.deltaTime);
            if (bloodImage.color.a >= 0.8) //Almost Opaque, close enough
            {
                getDamage = false;

            }
        }
        if (!getDamage)
        {
            Color Transparent = new Color(1, 0, 0, 0);
            bloodImage.color = Color.Lerp(bloodImage.color, Transparent, 20 * Time.deltaTime);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy" && currentTime <= 0) 
        {

            getDamage = true;
            currentHealth--;
            healthBar.UpdateBar(currentHealth, maxHealth);
            currentTime = timer;

        }
    }
}
