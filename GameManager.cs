using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnTime ;
    float timer ;
    public GameObject GameOverScene ;
    void Start()
    {
        Time.timeScale = 1 ;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime ;
        if ( timer >= spawnTime )
            timer = 0 ;
    }

    public void Gameover() {
        Time.timeScale = 0 ;
        GameOverScene.SetActive( true ) ;
    } // Gameover

    public void Restart() {
        SceneManager.LoadScene( "SampleScene" ) ;
    } // Restart
}
