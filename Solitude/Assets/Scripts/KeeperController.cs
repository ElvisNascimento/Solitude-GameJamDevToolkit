using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperController : MonoBehaviour
{
    public Transform pontoA, pontoB;
    public Transform skin;
    public bool goRight;
    public CapsuleCollider2D keeperCollider = null;

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        goRight = true;
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
            if (Vector2.Distance(transform.position, pontoB.position) < 0.2f)
            {
                goRight = false;
            }
            skin.GetComponent<SpriteRenderer>().flipX = false;
            transform.position = Vector2.MoveTowards(transform.position, pontoB.position, speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position, pontoA.position) > 0.2f)
            {
                goRight = true;
            }
            skin.GetComponent<SpriteRenderer>().flipX = true;
            transform.position = Vector2.MoveTowards(transform.position, pontoA.position, speed * Time.deltaTime);
        }
    }
}
