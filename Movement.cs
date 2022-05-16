using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed ;
    public float startPosition ;
    public float endPostion ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2( transform.position.x - movementSpeed * Time.deltaTime, transform.position.y ) ;
        // 使地板移動
        if ( transform.position.x <= endPostion ) {
            if ( gameObject.tag == "Cactus" )
            {
                Destroy( gameObject ) ;
                transform.parent.GetComponent<CactusManager>().SpawnCactus() ;
            } // if
            else if ( gameObject.tag == "Cloud" )
            {
                Destroy( gameObject ) ;
                transform.parent.GetComponent<CloudManager>().SpawnCloud() ;
            } // else if clound
            else
                transform.position = new Vector2( startPosition, transform.position.y ) ;
        } // if 移動到盡頭就改回原點

    }
}
