using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScrollBehaviour : MonoBehaviour 
{
    private DisplacementBehaviour _displacement;

	void Start () 
    {
        _displacement = Camera.main.GetComponent<DisplacementBehaviour>();
	}
	
	void Update () 
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Scroll(-1, GetScrollAmount());
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Scroll(1, GetScrollAmount());
        }
	}

    private float GetScrollAmount() 
    {
        return 1f * Time.deltaTime;
    }

    /// <summary>
    /// Scrolls into the specific direction
    /// </summary>
    /// <param name="dir">The direction of scrolling. -1 = left, 1 = right</param>
    private void Scroll(int dir, float amount) 
    {
        transform.Translate(new Vector3(amount * dir, 0, 0));
        _displacement._scrollOffset += amount * 0.1f * dir;
    }
}
