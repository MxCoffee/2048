using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tile : MonoBehaviour {

	public int indRow;
	public int indCol;

	public bool mergedThisTurn = false;

	public int Number
	{
		get
		{
			return number;
		}
		set
		{
			number = value;
			if (number == 0) {
				SetEmpty ();
			} else {
				ApplyStyle (number);
				SetVisible ();
			}
		}
	}


	private int number;

	private Text TileText;
	private Image TileImg;

	void Awake()
	{
		TileText = GetComponentInChildren<Text> ();
		TileImg = transform.Find("NumberCell").GetComponent<Image>();

	}

	void ApplyStyleFromHolder(int index)
	{
		TileText.text = TileStyleHolder.instance.TilesNum [index].Number.ToString();
		TileText.color = TileStyleHolder.instance.TilesNum [index].TextColor;
		TileImg.color = TileStyleHolder.instance.TilesNum [index].TileColor;
	}
	void ApplyStyle(int num)
	{
		switch (num) {
		case 2:
			ApplyStyleFromHolder (0);
			break;
		case 4:
			ApplyStyleFromHolder (1);
			break;
		case 8:
			ApplyStyleFromHolder (2);
			break;
		case 16:
			ApplyStyleFromHolder (3);
			break;
		case 32:
			ApplyStyleFromHolder (4);
			break;
		case 64:
			ApplyStyleFromHolder (5);
			break;
		case 128:
			ApplyStyleFromHolder (6);
			break;
		case 256:
			ApplyStyleFromHolder (7);
			break;
		case 512:
			ApplyStyleFromHolder (8);
			break;
		case 1024:
			ApplyStyleFromHolder (9);
			break;
		case 2048:
			ApplyStyleFromHolder (10);
			break;
		default:
			Debug.LogError ("Check the numbers");
			break;
		}
	}

	private void SetVisible()
	{
		

		TileText.enabled = true;
		TileImg.enabled = true;
	}
	private void SetEmpty()
	{
		
		TileText.enabled = false;
		TileImg.enabled = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
