using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    public GameObject[] myObjects;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            //spawn the objects
            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

            // Quaternion.identity this means no rotation 
            //need to press space bar for object to spawn

        }


    }
}
