using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MoneyInputer;

    private void Update()
    {
        if(MoneyInputer.activeSelf == true && Input.GetKeyDown(KeyCode.Escape))
        {
            MoneyInputer.SetActive(false);
        }
    }
    public void OnClickStart()
    {
        MoneyInputer.SetActive(true);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void GameStarter()
    {
        SceneManager.LoadScene(1);
    }
}
