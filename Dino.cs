using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Dino : MonoBehaviour
{
    Rigidbody2D rd ;
    public float jump ;
    bool isJumping ;
    bool isDowning ;
    public GameManager gm ;
    [SerializeField] Text scoreText ;
    int score ;
    float scoreTime ;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>() ;
        isJumping = false ;
        isDowning = false ;
        score = 0 ;
        scoreTime = 0 ;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Space ) && isJumping == false && isDowning == false )
        {
            rd.velocity = new Vector2( 0, jump ) ;
            isJumping = true ;
            GetComponent<Animator>().SetBool( "jump", true ) ;
            rd.gameObject.GetComponent<AudioSource>().Play() ;
        } // if
        else if ( Input.GetKey( KeyCode.DownArrow ) && isDowning == false )
        {
            isDowning = true ;
            GetComponent<Animator>().SetBool( "down", true ) ;
        } // else if
        else if ( Input.GetKeyUp( KeyCode.DownArrow ) && isDowning == true )
        {
            isDowning = false ;
            GetComponent<Animator>().SetBool( "down", false ) ;
        } // if

        UpdateScore() ;
    } // 玩家操控小恐龍

    private void OnCollisionEnter2D( Collision2D collision )
    {
        isJumping = false ;

        if ( collision.gameObject.tag == "Ground" ) {
            GetComponent<Animator>().SetBool( "jump", false ) ;
        } // if

        if ( collision.gameObject.tag == "Cactus" ) {
            gm.Gameover() ;
        } // if
    } // 控制當小恐龍碰到仙人掌即失敗以及碰到地板即從跳躍動畫轉回走路動畫

    void UpdateScore()
    { // 利用生存的時間來計算得分
        scoreTime += Time.deltaTime ;
        if ( scoreTime > 0.5f )
        {
        score++ ;
        scoreTime = 0f ;
        scoreText.text = score.ToString() ;

        while ( scoreText.text.Length < 5 )
        {
            scoreText.text = "0" + scoreText.text ;
        } // while
        } // if

    } // UpdateScore
}
