using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour {

    [SerializeField] bool GameLoss = false;
    [SerializeField] bool GameWin = false;
    [SerializeField] GameObject menu;
    [SerializeField] Text gameResult;

    void Start()
    {
        if (GameLoss)
        {
            gameResult.text = "YOU LOSE";
        }else if(GameWin)
        {
            gameResult.text = "YOU WIN";
        }
    }

	public void ReplayGame()
    {
        menu.SetActive(false);
        SceneManager.LoadScene(1);
    }
	
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
