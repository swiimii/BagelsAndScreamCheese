using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    // Menu accessible by static functions.
    public static GameObject menu;

    private void Start()
    {
        // Attached menu is accessible by static functions.
        menu = gameObject;
        gameObject.SetActive(false);
    }


    public static void ToggleMenu()
    {
        if (menu.activeInHierarchy)
            menu.SetActive(false);
        else
            menu.SetActive(true);
    }

    public static void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
