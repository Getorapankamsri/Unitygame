using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {
    
	void Update () {
        Vector3 rotate = new Vector3(0, 0, 5);
        transform.Rotate(rotate);
	}

    
}
