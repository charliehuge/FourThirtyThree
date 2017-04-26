using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public UnityEngine.UI.Image progressBar;
	public UnityEngine.UI.Text text;

	private const float _totalTime = 4 * 60 + 33;
	private float _timeRemaining = _totalTime;

	private void Update()
	{
		System.TimeSpan t = System.TimeSpan.FromSeconds(_timeRemaining);

		text.text = string.Format("{0:D2}\'{1:D2}\"", 
			t.Minutes, 
			t.Seconds);

		progressBar.fillAmount = 1.0f - _timeRemaining / _totalTime;

		_timeRemaining -= Time.deltaTime;

		if (_timeRemaining < 0.0f)
		{
			_timeRemaining = 0.0f;
		}
	}
}
