using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusManager : MonoBehaviour
{
    [SerializeField] GameObject[] cactusPrefads ;

    public void SpawnCactus()
    {
        int r = Random.Range( 0, cactusPrefads.Length ) ;
        GameObject cactus = Instantiate(cactusPrefads[r], transform) ;
        cactus.transform.position = new Vector3( Random.Range(35f, 40f), -10f, 0f ) ;
    } // SpawnCactus
}
