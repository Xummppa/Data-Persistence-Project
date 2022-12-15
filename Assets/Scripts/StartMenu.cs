using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.UI;
#endif

public class StartMenu : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        Saver.Instance.PlayerName = PlayerNameInput.text;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
