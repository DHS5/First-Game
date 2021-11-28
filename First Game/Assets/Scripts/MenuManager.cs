using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button foxButton;
    public Button dogButton;

    public void dog()
    {
        MainManager.Instance.animal = "Dog";
        SceneManager.LoadScene(1);
    }
    public void fox()
    {
        MainManager.Instance.animal = "Fox";
        SceneManager.LoadScene(1);
    }
}
