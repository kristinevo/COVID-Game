using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button exit;
    public Button play_Game;
    void Start()
    {
        play_Game.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Introduction");
        });

        exit.onClick.AddListener(() =>
        {
            System.Environment.Exit(1);

        });

    }
}
