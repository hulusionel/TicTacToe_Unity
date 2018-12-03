using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {


	void Update ()
    {
        transform.position = Input.mousePosition;
	}
}
