using UnityEngine;
using System.Collections;

[System.Serializable]
public class Tiles
{
	public int Number;
	public Sprite tile;

}


public class TileNumbers : MonoBehaviour {

	public static TileNumbers instance;

	public Tiles[] TilesNum;

	void Awake()
	{
		instance = this;

	}
}
