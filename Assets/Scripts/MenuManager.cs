using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{

    [SerializeField]  private TMP_InputField _InputField;
    [SerializeField]  private GameObject _startButton;
    [SerializeField]  private GameObject _quitButton;
    

    public void StartGame()
    {


        if (_InputField.text.Length > 0)
        {
            GameManager.Instance.PlayerName = _InputField.text;
            //GameManager.Instance.SaveHighScore(new GameManager.Player{Name = _InputField.text, HightScore = 0, CurrentPlayer = true});
           // GameManager.Instance.PlayerList.Add();
            SceneManager.LoadScene(1);

        }
        else
        {
            Debug.LogError("Need to enter your name");
        }
        
    }

    public void ExitGame()
    {
       #if UNITY_EDITOR
       EditorApplication.ExitPlaymode();
       #else
       Application.Quit();
       #endif
    }
}
