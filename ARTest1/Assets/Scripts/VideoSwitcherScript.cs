using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSwitcherScript : MonoBehaviour
{
	[SerializeField] private List<string> _urlOfVideos = new List<string>();
	private int _indexOfCurrentURL = 0;

	private void OnEnable()
	{
		SwipeDetectionScript.PlayNextVideo += PlayNextVideo;
		SwipeDetectionScript.PlayPreviousVideo += PlayPreviousVideo;
	}

	public void PlayNextVideo()
	{
		_indexOfCurrentURL++;

		if (_indexOfCurrentURL >= _urlOfVideos.Count)
		{
			_indexOfCurrentURL = 0;
		}

		SetURLAndPlayVideo();
	}

	public void PlayPreviousVideo()
	{
		_indexOfCurrentURL--;

		if (_indexOfCurrentURL < 0)
		{
			_indexOfCurrentURL = _urlOfVideos.Count - 1;
		}

		SetURLAndPlayVideo();
	}

	private void SetURLAndPlayVideo()
	{
		gameObject.GetComponent<VideoPlayer>().url = _urlOfVideos[_indexOfCurrentURL];
		gameObject.GetComponent<VideoPlayer>().Play();
	}
}
