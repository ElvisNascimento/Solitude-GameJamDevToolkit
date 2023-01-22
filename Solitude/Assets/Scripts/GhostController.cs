using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{

    public Transform pontoA, pontoB;
    public CircleCollider2D ghostController;
    public Transform skin;
    public bool goRight;
    public int damage;

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WalkForSides();
    }
    void WalkForSides()
    {
        if (goRight == true)
        {
            ghostController.offset = new Vector2(0.05f, 0.12f);
            if (Vector2.Distance(transform.position, pontoB.position) < 0.2f)
            {
                //goRight = false;
                transform.position = pontoA.position;
            }
            skin.GetComponent<SpriteRenderer>().flipX = false;
            transform.position = Vector2.MoveTowards(transform.position, pontoB.position, speed * Time.deltaTime);
        }
        else
        {
            ghostController.offset = new Vector2(-0.05f, 0.12f);
            if (Vector2.Distance(transform.position, pontoA.position) < 0.2f)
            {
                transform.position = pontoB.position;
            }
            skin.GetComponent<SpriteRenderer>().flipX = true;
            transform.position = Vector2.MoveTowards(transform.position, pontoA.position, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            print("colidiu");
            //collision.GetComponent<Character>().PlayerDamage(damage);
        }
    }
}
