using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class SoundAction_L : MonoBehaviour
{
    public GameObject VButton;
    public AudioClip aClip;
    public AudioSource audioSource;
    private float timer = 0.0f;
    private bool isTimerValid = false;
    void Start()
    {
        VButton = GameObject.Find("SoundButton_L");
        VButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        VButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
     
        StartTimer(2.0f);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        InvalidateTimer();
    }

    
    void Update()
    {
         if (isTimerValid)
        {
            timer -= Time.deltaTime;
            
            if (timer <= 0.0f)
            {
                TimeIsUp();
                InvalidateTimer();
            }
        }
        
    }
    private void StartTimer(float seconds)
    {
        timer = seconds;
        isTimerValid = true;
    }

    private void InvalidateTimer()
    {
        timer = 0.0f;
        isTimerValid = false;
    }

    private void TimeIsUp()
    {
        audioSource.transform.position = transform.position;
        audioSource.PlayOneShot(aClip);
    }

}
