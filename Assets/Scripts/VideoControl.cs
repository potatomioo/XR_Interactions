using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

public class VideoControl : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private bool isPlaying = true;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Ensure the video starts playing
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    public void TogglePlayPause()
    {
        if (videoPlayer != null)
        {
            if (isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
            isPlaying = !isPlaying;
        }
    }
}
