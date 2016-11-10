using UnityEngine;
using System.Collections;

public class mainScript : MonoBehaviour {

	private ItemGame[,] itemsSprites = new ItemGame[4,4];
	private Random random;
	void Start () {
		
		int k = getRandInt(3)+ 1;
		while (k != 0) {
			int w = getRandInt(3);
			int h = getRandInt(3);
			if (itemsSprites[w, h] == null){
				ItemGame itemGame = new ItemGame();
				itemGame.count = 2;
				itemGame.sprite = new Sprite();

				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load()
			}
		}
		Debug.Log("ASDASDASDASDASDASDAD");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private int getRandInt(int sequence) { 
		Random.InitState(sequence);
		return (int)Random.value;
	}

	private class ItemGame  {
	
		public Sprite sprite = null;
		public int count = 0;

	
	}
}
