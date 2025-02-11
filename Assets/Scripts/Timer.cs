using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timer = 120f; 
    public TMP_Text timerText;
    public GameObject gameOverUI;
    public Camera playerCamera;
    
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timer).ToString();
        }
        else
        {
            GameOver();
        }
    }

    void GameOver()
    {
        timer = 0;
        gameOverUI.SetActive(true); 
        playerCamera.gameObject.SetActive(true); 
        Time.timeScale = 0; 
    }
}
