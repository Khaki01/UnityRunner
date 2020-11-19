using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {

    [SerializeField] private GameObject line;
    private Vector2 mousePosition;

	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(line, mousePosition, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        }
    }
}
