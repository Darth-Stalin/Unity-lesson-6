using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public TMP_Text timerText;
    private float currentTime;
    public TMP_Text lapsText;
    private int LapsNumber = 0;
    public TMP_Text lapsTimeText;
    private float currentLapTime;
    public TMP_Text preiosLapTimeText;
    private float previosLapTime;
    bool timerRunning = false;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning == true)
        {
        currentTime += Time.deltaTime;
        timerText.text = Math.Round(currentTime).ToString();
        }
    }

    public void LapsFinishedButtonClick()
    {
        CalclateRaceData();
        DisplayRaceData();
    }
    private void CalclateRaceData()
    {
        previosLapTime = currentLapTime;
        currentLapTime = currentTime;
            LapsNumber = LapsNumber + 1;
    }
    private void DisplayRaceData()
    {
        lapsTimeText.text = Math.Round(currentLapTime).ToString();
        preiosLapTimeText.text = Math.Round(previosLapTime).ToString();
        lapsText.text = LapsNumber.ToString();
    }

    public void ButtonTimer()
    {
        timerRunning = true;
    }

        public void ButtonTimerStop()
    {
        timerRunning = false;
    }

}
