using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;

public class Test1 : MonoBehaviour
{

  Camera mainCamera;

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("ok");
    GameObject myGO;
    GameObject myText;
    GameObject myButton;
    Canvas myCanvas;
    Text text;
    RectTransform rectTransform;

    mainCamera = Camera.main;

    // Canvas
    myGO = new GameObject();
    myGO.name = "TestCanvas";
    myGO.AddComponent<Canvas>();
    myGO.transform.SetParent(mainCamera.transform);

    myCanvas = myGO.GetComponent<Canvas>();
    myCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
    myGO.AddComponent<CanvasScaler>();
    myGO.AddComponent<GraphicRaycaster>();

    // Text
    myText = new GameObject();
    myText.transform.parent = myGO.transform;
    myText.name = "wibble";

    text = myText.AddComponent<Text>();
    text.font = (Font)Resources.Load("MyFont");
    text.text = "wobble";
    text.fontSize = 100;

    // Text position
    rectTransform = text.GetComponent<RectTransform>();
    rectTransform.localPosition = new Vector3(0, 0, 0);
    rectTransform.sizeDelta = new Vector2(400, 200);

    // Button
    myButton = new GameObject();
    myButton.transform.parent = myGO.transform;
  }

  // Update is called once per frame
  void Update()
  {
  }

  public void MyButtonEvent()
  {
    Debug.Log("MyButtonEvent");
  }

}
