using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject menuPanel;

    void Start(){
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(SceneManager.GetActiveScene().name == "Menu"){
                exitPanel.SetActive(true);
            }
            else{
                AdmobScript.instance.showInterstitialAd();
                menuPanel.SetActive(true);
            }
        }
    }
    public void CancelBtn(){
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("Menu");
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void ResetBtn()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void oneP()
    {
        GameControl.nofPlayers = 1;
        SceneManager.LoadScene("Main");
    }

    public void twoP()
    {
        GameControl.nofPlayers = 2;
        SceneManager.LoadScene("Main");
    }

    public void threeP()
    {
        GameControl.nofPlayers = 3;
        SceneManager.LoadScene("Main");
    }

    public void fourP()
    {
        GameControl.nofPlayers = 4;
        SceneManager.LoadScene("Main");
    }

    public void OpenUrl(){
        Application.OpenURL("http://raviikmr.github.io/privacy-snakeladder.html");

    }

}
