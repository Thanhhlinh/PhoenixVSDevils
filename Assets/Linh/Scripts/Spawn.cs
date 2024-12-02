
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    private float count = 0;
    public float dame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        if (count <= 0)
        {
            Vector3 possition = new Vector3(Random.Range(-8.8f,8.8f), -4.5f, 0);
            Instantiate(enemy, possition, Quaternion.identity);
            count = 5;
        }
        count = count - Time.deltaTime;
        
    }
   


}
