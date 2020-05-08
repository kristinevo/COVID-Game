using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fridge_Selection : MonoBehaviour
{
    public void onStartGame()
    {
        SceneManager.LoadScene("Fridge");
    }
}
