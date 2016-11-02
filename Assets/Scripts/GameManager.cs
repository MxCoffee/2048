using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	//public static GameManager instance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Move(MoveDirection md)
	{
		Debug.Log (md.ToString() + " move.");
	}

}
