using UnityEngine;
using UnityEngine.Video;

public class StopPlayScreenButtonScript : MonoBehaviour
{
	[SerializeField] private VideoPlayer _videoPlayer = null;

	public void PausePlayVideo()
	{
		if (_videoPlayer.isPaused)
		{
			_videoPlayer.Play();
		}
		else
		{
			_videoPlayer.Pause();
		}
	}
}
