using UnityEngine;

public class SwipeDetectionScript : MonoBehaviour
{
	public delegate void VideoSwitcherCallBack();
	public static event VideoSwitcherCallBack PlayNextVideo;
	public static event VideoSwitcherCallBack PlayPreviousVideo;

	private float _startTouchPosition;
	private float _endTouchPosition;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			_startTouchPosition = Input.mousePosition.x;
		}
		if (Input.GetMouseButtonUp(0))
		{
			_endTouchPosition = Input.mousePosition.x;

			if (_startTouchPosition > _endTouchPosition)
			{
				PlayNextVideo?.Invoke();
			}
			if (_endTouchPosition > _startTouchPosition)
			{
				PlayPreviousVideo?.Invoke();
			}
		}
	}
}
