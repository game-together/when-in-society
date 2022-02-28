using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MissionMenu : MonoBehaviour
{
    public static bool showMission = false;
    public GameObject missionMenuUI;
    public GameObject missionMenuUI2;
    public int missionID;
    public Text Intro;
    GameObject missionSelected;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (showMission)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }

    public void Open()
    {
        missionMenuUI.SetActive(true);
        showMission = true;
    }

    public void Close()
    {
        missionMenuUI.SetActive(false);
        showMission = false;
    }

    public void Select(int MID)
    {
        missionID = MID;
        missionSelected = GameObject.Find("Mission"+MID);
        switch (MID)
        {
            case 1:
                Intro.text = Intro.GetComponent<Introduction>().intro[0];
                return;
            case 2:
                Intro.text = Intro.GetComponent<Introduction>().intro[1];
                return;
            case 3:
                Intro.text = Intro.GetComponent<Introduction>().intro[2];
                return;
            case 4:
                Intro.text = Intro.GetComponent<Introduction>().intro[3];
                return;
            default:
                return;
        }
    }

    public void Confirm()
    {
        Debug.Log(missionSelected);

    }

}
