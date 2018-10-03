using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

	void Update () 
    {
        transform.Rotate(0, 45 * Time.deltaTime, 0);
	}
}
