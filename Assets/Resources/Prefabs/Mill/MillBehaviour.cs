using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MillBehaviour : MonoBehaviour {

    private Transform armature;
    private float rot = 0;

	// Use this for initialization
	void Start () {
        armature = GameObject.Find("Mill/MillModel/Armature").transform;
	}
	
	// Update is called once per frame
	void Update () {
        armature.eulerAngles = new Vector3(armature.eulerAngles.x, armature.eulerAngles.y, rot);

        rot += 20f * Time.deltaTime;
        if (rot > 359)
        {
            rot = 0;
        }
	}
}
