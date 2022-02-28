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
    StartMenuCanvas = GameObject.Find("StartMenuCanvas");
    StartMenuCanvas.SetActive(true);
    GameObject button = GameObject.Find("button_start");
    button.GetComponent<Button>().onClick.AddListener(Clicked);
  }

  public void Clicked()
  {
    Debug.Log("clicked") ;
    SceneManager.LoadScene("Game");
  }

  // Update is called once per frame
  void Update()
  {
  }
}
