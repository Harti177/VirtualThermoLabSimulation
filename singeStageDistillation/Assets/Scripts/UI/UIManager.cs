﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Manager manager; 

    public PlayPauseResumeButton playPauseResumeButton;
    public UIObject stopButton;
    public UIObject restartButton;
    public UIObject skipButton;
    public UIObject parametersButton;

    public ProgressSlider progressSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPlayPauseResumeButtonPressed()
    {
        if (!Manager.GetStartedStatus()) //Play
        {
            playPauseResumeButton.SwitchPlayPauseIcon();
            stopButton.Show();
            skipButton.Show();
            parametersButton.Hide();
        }
        else if (Manager.GetStartedStatus() & Manager.GetPlayingStatus()) //Pause
        {
            playPauseResumeButton.SwitchPlayPauseIcon();
        }
        else if (Manager.GetStartedStatus() & !Manager.GetPlayingStatus()) //Resume 
        {
            playPauseResumeButton.SwitchPlayPauseIcon();
        }
    }

    public void onStopButtonPressed()
    {
        playPauseResumeButton.SwitchToPlayIcon();
        stopButton.Hide();
        skipButton.Hide();
        parametersButton.Show();

        SetProgressSliderFromDataProgress(0);
        progressSlider.Hide(); 
    }

    public void onSkipButtonPressed()
    {
        skipButton.Hide();
        progressSlider.Show();
    }

    public void onRestartButtonPressed()
    {
        restartButton.Hide(); 
        skipButton.Hide();
        parametersButton.Hide();
    }

    //Progress Slider 
    public void SetDataProgressFromProgressSlider(float value)
    {
        manager.dataManager.SetIndexFromSlider(value);
    }

    public void SetProgressSliderFromDataProgress(float value)
    {
        progressSlider.GetComponentInChildren<Slider>().value = value; 
    }

    public void SetMaxOfProgressSlider(float value)
    {
        progressSlider.GetComponentInChildren<Slider>().maxValue = value;
    }
}
