using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StVeEnemy : MonoBehaviour { 

    public float speed;

    public GameObject effect;

    public GameObject popSound;


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("StVeGhost"))
        {
            Instantiate(popSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);

            Destroy(gameObject);
            }
        }
    }
