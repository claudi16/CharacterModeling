using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDisplay : MonoBehaviour {
	
	public Character character;

	void Start () {
		character.Print();
	}
	
}
