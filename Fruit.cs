using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{

    [SerializeField] GameObject[] fruitPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FruitSpawn());
    }

    IEnumerator FruitSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras ,maxTras);
            var position = new Vector3(wanted, transform.position.y);

            //spawn the game objects
            GameObject gameObject = Instantiate(fruitPrefab[Random.Range(0, fruitPrefab.Length)], 
                position, Quaternion.identity);
            gameObject.transform.parent = transform; //copy the object for spawning

            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);


        }
    }  
}
