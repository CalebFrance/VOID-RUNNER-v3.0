using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    public float pos;
    public float fallheight;
    public GameObject player;
    public float deathDelay = 10f;
    public static Transform playerTransform;
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void GameOver()
    {
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("You died");
            Destroy(gameObject);
            SceneManager.LoadSceneAsync(3);
        }


    }

    

    public void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Death"))
        {
            Debug.Log("You hit an obstacle died");
            Destroy(gameObject);
           

            SceneManager.LoadSceneAsync(3);
            

        }

        if (other.gameObject.CompareTag("Boss Enemies"))
        {
            Debug.Log("The enemy got you, you're dead");

            Destroy(gameObject);
           
            SceneManager.LoadSceneAsync(3);
            


        }
    }

    // Update is called once per frame
    void Update()
    {
        pos = player.transform.position.y;

        if (pos <= -10f)
        {
            GameOver();
            Debug.Log("You fell too far");
        }
    }
}
