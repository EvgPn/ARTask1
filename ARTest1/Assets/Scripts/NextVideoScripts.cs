using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NextVideoScripts : MonoBehaviour
{
	[SerializeField] private List<string> _urlOfVideos = new List<string>();
	private int _indexOfCurrentURL = 0;

	public void PlayNextVideo()
	{
		_indexOfCurrentURL++;

		if (_indexOfCurrentURL >= _urlOfVideos.Count)
		{
			_indexOfCurrentURL = 0;
		}

		gameObject.GetComponent<VideoPlayer>().url = _urlOfVideos[_indexOfCurrentURL];
		gameObject.GetComponent<VideoPlayer>().Play();
	}
}
