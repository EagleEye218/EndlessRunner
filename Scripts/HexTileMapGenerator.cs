using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileMapGenerator : MonoBehaviour 
{

	public GameObject hextilePrefab;

	public int mapWidth = 25;
	public int mapHeight = 12;

	float tileXOffset = 1.8f;
	float tileZOffset = 1.565f;

	void Start () 
	{
		CreateHexTileMap ();
	}

	void CreateHexTileMap () 
	{
		for(int x = 0; x <= mapWidth; x++)
		{
			for(int z = 0; z <= mapHeight; z++)
			{
				GameObject TempGO = Instantiate (hextilePrefab);

				if (z % 2 == 0) 
				{
					TempGO.transform.position = new Vector3 (x * tileXOffset, 0, z * tileZOffset);
				} 
				else 
				{
					TempGO.transform.position = new Vector3 (x * tileXOffset + tileXOffset / 2, 0, z * tileZOffset);
				}

				SetTileInfo (TempGO, x, z);
			}
		}
	}

	void SetTileInfo(GameObject GO, int x, int z)
	{
		GO.transform.parent = transform;
		GO.name = x.ToString() + ", " + z.ToString();
	}
}
