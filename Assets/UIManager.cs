using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public GameObject gameOver;
    public TextMeshProUGUI ScoreText;
    public int score = 0;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        gameOver.SetActive(false);
        ScoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        // This is Thanh Linh
        // test lai
        // conflict master
        // conflict master
    }

    void UpdateScore()
    {
        ScoreText.text = score.ToString();
    }
}
