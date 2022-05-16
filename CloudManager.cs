using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
    [SerializeField] GameObject cloudPrefads ;

    public void SpawnCloud()
    {
        GameObject cloud = Instantiate(cloudPrefads, transform) ;
        cloud.transform.position = new Vector3( Random.Range(30f, 40f), Random.Range(-2f, 5f), 0f ) ;
    } // SpawnClound
}
