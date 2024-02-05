using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider timeSlider;

    public TextMeshProUGUI txt;

    private void Update()
    {
        int minutes = Mathf.FloorToInt(audioSource.time / 60);
        int seconds = Mathf.FloorToInt(audioSource.time - minutes * 60);

        string textTime = string.Format("{00:00}", seconds);

        txt.text = textTime + " / " + audioSource.clip.length.ToString("f0");

        if (audioSource.isPlaying)
        {
            timeSlider.maxValue = audioSource.clip.length;
        }
    }

    public void OnSliderValueChanged()
    {
        audioSource.time = timeSlider.value;
    }

    private void FixedUpdate()
    {
        timeSlider.value = audioSource.time;
    }

    public void PlayBtn()
    {
        audioSource.Play();
    }

    public void PauseBtn()
    {
        audioSource.Pause();
    }

    public void StopBtn()
    {
        audioSource.Stop();
    }
}
