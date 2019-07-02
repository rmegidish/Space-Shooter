using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour {


    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject Cylinder;  
    public float spawnTime = 15f;
    public Transform[] spawnPoints;
   // public PlayerHealth potionClone;

    private void Awake()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
       // potionClone = player.GetComponent<PlayerHealth>();
       // Cylinder = GameObject.FindGameObjectWithTag("Cylinder");
    }
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        
    }
   
    void Spawn()
    {

        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }
        if (playerHealth.currentHealth > 70f)
        {
            return;
        }
       


        if (playerHealth.isCylinder == false){

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            Instantiate(Cylinder, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            playerHealth.isCylinder = true;
            //  StartCoroutine(Wait(5f));
            //  Cylinder.SetActive(false);
        }
    }
/*   IEnumerator Wait(float duration)
    {
        yield return new WaitForSeconds(duration);

    } */

}
