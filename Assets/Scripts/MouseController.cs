using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    Vector3 mousePosition = Vector3.zero;
	// Start is called before the first frame update
	void OnApplicationFocus(bool hasFocus)
	{
		if (hasFocus)
		{
			Cursor.lockState = CursorLockMode.Confined;
			Debug.Log("Application is focussed");
		}
		else
		{
			Debug.Log("Application lost focus");
		}
	}
	void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
		this.transform.position = mousePosition;
    }
}
