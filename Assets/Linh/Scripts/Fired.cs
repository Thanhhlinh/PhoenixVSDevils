using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fired : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int dame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireMove();

    }

    private void FireMove()
    {
        transform.Translate(Vector3.down * speed*Time.deltaTime);
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Demon>().heal = collision.gameObject.GetComponent<Demon>().heal - dame;
            Destroy(gameObject);
        }
    }
}
