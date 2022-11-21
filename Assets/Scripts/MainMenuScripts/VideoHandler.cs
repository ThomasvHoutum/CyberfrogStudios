using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VideoHandler : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] GameObject videoPlayerObject;

    [SerializeField] float fadeSpeed;

    [SerializeField] RawImage videoHolder;
    [SerializeField] GameObject cfsPlaceholder;
    void Update()
    {
        if(videoPlayer.isPlaying == true)
        {
            cfsPlaceholder.SetActive(false);
            videoPlayerObject.SetActive(true);
        }
        else
        {
            StartCoroutine("FadeAndDissable");
        }
    }
    IEnumerator FadeAndDissable()
    {
        yield return new WaitForSeconds(0.5f);
        videoHolder.color = new Color(videoHolder.color.r, videoHolder.color.g, videoHolder.color.b, videoHolder.color.a - (fadeSpeed * Time.deltaTime));
        if (videoHolder.color.a <= 0)
        {
            SceneManager.LoadScene(1);  
        }
    }
}
