using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    GameObject StartMenuCanvas;
    GameObject GameIndexCanvas;

        // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("button_start").GetComponent<Button>().onClick.AddListener(StartGame);
        GameObject.Find("button_memory").GetComponent<Button>().onClick.AddListener(OpenMemory);
        GameObject.Find("button_setting").GetComponent<Button>().onClick.AddListener(OpenSetting);
        GameObject.Find("button_about").GetComponent<Button>().onClick.AddListener(OpenAbout);
        GameObject.Find("button_exit").GetComponent<Button>().onClick.AddListener(ExitMenu);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenMemory()
    {
        Debug.Log("should open memory");
    }

    public void OpenSetting() 
    {
    }

    public void OpenAbout()
    {

    }

    public void ExitMenu()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
