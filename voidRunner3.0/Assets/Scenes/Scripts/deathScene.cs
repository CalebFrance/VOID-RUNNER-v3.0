using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restartScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Game Restarted");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
