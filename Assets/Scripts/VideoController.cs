using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    bool Play = false;
    public GameObject PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        // By default make video Pause
        VideoPause();
    }

    // Video Play
    public void VideoPlay()
    {
        videoPlayer.Play();
        PlayButton.SetActive(false);
    }

    // Video Play

    public void VideoPause()
    {
        videoPlayer.Pause();
        PlayButton.SetActive(true);
    }

    // Check video is playing or not. If video is playing, then make it pause, again video is paused, make it play

    public void VideoPlayPause()
    {
        if (Play)
        {
            VideoPause();
            Play = false;
        }
        else
        {
            VideoPlay();
            Play = true;
        }
    }
}
