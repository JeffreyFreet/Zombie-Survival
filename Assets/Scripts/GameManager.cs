using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public playerController player;
    public Text healthText;
    public Text ammoText;

	// Use this for initialization
	void Start () {
        healthText.text = "Health: " + player.health.ToString();
        ammoText.text = "Ammo: " + player.ammo + "/7";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateHealth()
    {
        healthText.text = "Health: " + player.health.ToString();
    }

    public void updateAmmo()
    {
        ammoText.text = ammoText.text = "Ammo: " + player.ammo + "/7";
    }
}
