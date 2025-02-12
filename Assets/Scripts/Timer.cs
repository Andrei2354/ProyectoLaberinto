using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour{
    private float timer = 10f;
    public TMP_Text timerText;
    public GameObject gameOverUI;
    public GameObject panelUI; 
    public Camera playerCamera;

    void Start(){
        gameOverUI.SetActive(false);
        panelUI.SetActive(false); 
    }

    void Update(){
        if (timer > 0){
            timer -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timer).ToString();
        }
        else{
            GameOver();
        }
    }

    void GameOver(){
        timer = 0;
        gameOverUI.SetActive(true);
        panelUI.SetActive(true);
        playerCamera.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
