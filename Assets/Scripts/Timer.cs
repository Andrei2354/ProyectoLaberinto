using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Timer : MonoBehaviour{
    private float timer = 160f;
    public TMP_Text timerText;
    public Camera playerCamera;

    void Start(){

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
        playerCamera.gameObject.SetActive(true);
        Time.timeScale = 0;
        SceneManager.LoadScene("all_");
    }

    public void AñadirTiempo(float tiempo)
{
    timer += tiempo;
}

}
