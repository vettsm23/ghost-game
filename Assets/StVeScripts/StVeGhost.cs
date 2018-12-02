using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StVeGhost : MonoBehaviour
{

    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;




    public GameObject effect;

    public GameObject gameOver;


    private void OnTriggerEnter2D(Collider2D collision) { 
 
        if (collision.gameObject.tag == "Enemy")
        {
            gameOver.SetActive(true);
        }
    }


    void FixedUpdate ()

    {


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }

        else if (Input.GetKeyUp(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
            
    }

}
