using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject {

	public string name;
	public int health;

	public string recoveryAbility;
	public string element;

	public void Print(){
		Debug.Log("Her name is: " + name + " Health: " + health + " Her recovery ability is: "+ recoveryAbility
		+ " Her current element is: " + element);
	}
}
