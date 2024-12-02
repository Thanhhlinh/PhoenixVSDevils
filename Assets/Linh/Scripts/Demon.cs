using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demon : MonoBehaviour
{
    public int heal;
    public Speared speared;
    public Slider slider;
    private float count = 0;
    private float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = heal;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = heal/maxHealth;
        Shooted();
        Die();
    }

    private void Shooted()
    {
        if (count <= 0)
        {
            Instantiate(speared, transform.position, Quaternion.identity);
            count = Random.Range(4f, 7f);
            
        }
        count = count - Time.deltaTime;
        
    }

    private void Die()
    {
        if (heal <= 0)
        {
            Destroy(gameObject);
            UIManager.Instance.score += 10;

        }
    }
}
