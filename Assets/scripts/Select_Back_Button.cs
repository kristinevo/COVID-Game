using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_Back_Button : MonoBehaviour
{
    public void onStartGame()
    {
        SceneManager.LoadScene("main");
    }

}
