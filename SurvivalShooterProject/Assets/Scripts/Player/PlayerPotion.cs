using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPotion : MonoBehaviour {

  
    public int extraHealth = 40;


   
    GameObject player;
    PlayerHealth playerHealth;
    GameObject Cylinder;
    bool playerInRange;
   // public PlayerHealth potionClone2;
  
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        Cylinder = GameObject.FindGameObjectWithTag("Cylinder");
       // potionClone2 = player.GetComponent<PlayerHealth>();

    }

  /*void Update()
    {/*
        if (playerHealth.currentHealth >=100){
            Cylinder.SetActive(false);
        } 
} */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
           
            playerInRange = true;
            playerHealth.currentHealth += extraHealth;
            if (playerHealth.currentHealth > 100)
            {
                playerHealth.currentHealth = 100;
            }
            playerHealth.healthSlider.value = playerHealth.currentHealth;
            Cylinder.SetActive(false);
            playerHealth.isCylinder = false;
        }
      
    }
   /* private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player){
            playerInRange = false;
            Cylinder.SetActive(false);
        }
    }
*/



}
