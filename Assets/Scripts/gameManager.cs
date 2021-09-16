using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject balloon;
    public GameObject panel;
    public Text scoreText;
    public Text timeText;
    // Start is called before the first frame update

    public static gameManager i;

    int totalScore = 0;
    float time = 0;
    void Awake() 
    {
        i = this;
    }

    void Start()
    {
        InvokeRepeating("makeObstacle", 0.0f, 0.5f);   
        initGame();
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        time = 0;
        totalScore = 0;
    }

    void makeObstacle() 
    {
        Instantiate(obstacle);
    }

    public void endGame()
    {
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }

    public void addScore(int score) 
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }

    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
