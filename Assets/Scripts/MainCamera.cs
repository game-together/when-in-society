using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
  GameObject StartMenuCanvas;
  GameObject GameIndexCanvas;

  // Start is called before the first frame update
  void Start()
  {
    StartMenuCanvas = GameObject.Find("StartMenuCanvas");
    GameIndexCanvas = GameObject.Find("GameIndexCanvas");
    StartMenuCanvas.SetActive(true);
    GameIndexCanvas.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
  }
}
