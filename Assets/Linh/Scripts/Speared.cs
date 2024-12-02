using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speared : MonoBehaviour
{
    public int speed;
    public int dame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpearMove();
        if(transform.position.y >= 6)
        {
            Destroy(gameObject);
        }
    }

    void SpearMove()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Phoenix")
        {
            collision.gameObject.GetComponent<Phoenix>().heal = collision.gameObject.GetComponent<Phoenix>().heal - dame;
            Destroy(gameObject);
        }
    }
}
