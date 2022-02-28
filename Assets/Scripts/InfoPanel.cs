using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenEventList()
    {
        GameObject.Find("panel").SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
