using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class Phoenix : MonoBehaviour
{
    public float speed;
    public Fired fire;
    public float heal;
    private float maxHealth;
    public Slider slider;
    private float countDown = 0;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = heal;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = heal/maxHealth;
        Die();
        PhoenixMove();
        PhoenixFire();
    }

    void PhoenixMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

    void PhoenixFire()
    {
        countDown-= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (countDown <= 0)
            {
                Instantiate(fire, transform.position, Quaternion.identity);
                countDown = 1;
            } 
        }
    }
    private void Die()
    {
        if(heal<=0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            UIManager.Instance.gameOver.SetActive(true);
        }
        
    }    

}
