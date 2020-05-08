using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Market_Scene : MonoBehaviour
{
    public void onStartGame()
    {
        SceneManager.LoadScene("Market");
    }
}
