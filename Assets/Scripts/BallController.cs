using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallController : MonoBehaviour
{
	Vector3 worldPosMin = Vector3.zero;
	Vector3 worldPosMax = Vector3.zero;
    // Start is called before the first frame update
    void Start()
	{
		worldPosMin = Camera.main.ScreenToWorldPoint(Vector3.zero);
		worldPosMax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
	}

    // Update is called once per frame
    void Update()
    {
		
    }
	private void OnMouseOver()
	{
        Debug.Log("Mouse Over");
		this.transform.SetPositionAndRotation(new Vector3(Random.Range(worldPosMin.x, worldPosMax.x), Random.Range(worldPosMin.y, worldPosMax.y), 1), Quaternion.identity);
	}
}
