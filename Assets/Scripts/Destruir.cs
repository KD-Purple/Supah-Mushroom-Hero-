using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrehab;
    public GameObject luckyPrehab;
    private GameObject miPlataforma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name.StartsWith("Common Platform"))
        {

            if (Random.Range(1, 7) == 1)
            {

                Destroy(collision.gameObject);
                Instantiate(luckyPrehab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);


            } else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }

        } else if(collision.gameObject.name.StartsWith("Lucky Platform"))
        {

            if (Random.Range(1, 7) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }
            else
            {

                Destroy(collision.gameObject);
                Instantiate(platformPrehab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);


            }

        }

    }




}
