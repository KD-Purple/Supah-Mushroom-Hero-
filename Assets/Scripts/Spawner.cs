using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject platform;
    float respawnTime = 1f;
    Vector2 screenB;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(platformWave());
    }

    // Update is called once per frame
    void Update()
    {
        screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Spawn(){
        GameObject platform2 = Instantiate(platform) as GameObject;
        platform2.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), screenB.y * 1.1f, 0);
    }

    IEnumerator platformWave(){
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn();
        }
    }
}
