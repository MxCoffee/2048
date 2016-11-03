using UnityEngine;
using System.Collections;

[System.Serializable]
public class Tiles
{
	public int Number;
	public Color32 TileColor;
	public Color32 TextColor;

}


public class TileStyleHolder : MonoBehaviour {

	public static TileStyleHolder instance;

	public Tiles[] TilesNum;

	void Awake()
	{
		instance = this;

	}
}
