using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    [Header("Текстура рендера камеры")]
    public RawImage mainCam;

    [Header("Индекс работающей камеры")]
    public int currentCamIndex;

    WebCamTexture tex;

    private void Start()
    {
        //WebCamTexture webCam = new WebCamTexture();

        //if (!webCam.isPlaying)
        //{        
        //    webCam.Play();
        //}

        //mainCam.texture = webCam;
        StartStopCam_Clicked();
    }

    public void SwapCam_Clicked()
    {
        if (WebCamTexture.devices.Length > 0)
        {

            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;

            // if tex is not null:
            // stop the web cam
            // start the web cam

            if (tex != null)
            {
                StopWebCam();
                StartStopCam_Clicked();
            }
        }
    }

    public void StartStopCam_Clicked()
    {
        if (tex != null) // Stop the camera
        {
            StopWebCam();
        }
        else // Start the camera
        {
            WebCamDevice device = WebCamTexture.devices[1];
            tex = new WebCamTexture(device.name);
            mainCam.texture = tex;

            tex.Play();
        }
    }

    //ОСТАНОВИТЬ РАБОТУ КАМЕРЫ
    private void StopWebCam()
    {
        mainCam.texture = null;
        tex.Stop();
        tex = null;

    }
}
