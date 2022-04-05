using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerSpawnPoints; //The parent of the Spawnpoint
    Transform[] spawnPositions;
    public bool isRespawn = false;
    public bool isRespawnToggle=false;
    int k;

    void Start()
    {
        spawnPositions=playerSpawnPoints.GetComponentsInChildren<Transform>();
       // RandomSpawn();
       // Debug.Log(spawnPositions.Length);
    }

    private void RandomSpawn()
    {
       int i=UnityEngine.Random.Range(1, spawnPositions.Length);
        Debug.Log(spawnPositions[i].transform.position);
        return(i);
        //transform.position = spawnPositions[i].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* if(isRespawnToggle!=isRespawn)
        {
            RandomSpawn();
            isRespawn = false;
        }
        else
        {
            isRespawnToggle = isRespawn;
        }*/
       if(Input.GetKeyDown(KeyCode.Space))
        {
           k= RandomSpawn();
        }
        transform.position = spawnPositions[k].transform.position;
    }
}
