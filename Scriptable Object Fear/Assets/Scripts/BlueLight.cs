using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLight : MonoBehaviour {

	public Light blueLight;
	void Start () {
		blueLight = GetComponent<Light>();
		blueLight.color -= Color.blue;
	}
	
}
