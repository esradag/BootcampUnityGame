using UnityEngine;

public class CameraController : MonoBehaviour
{


	// Update is called once per frame
	void Update()
	{

		if (GameManager.GameIsOver)
		{
			this.enabled = false;
			return;
		}

		
	}
}
