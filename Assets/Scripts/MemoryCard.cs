using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {
	[SerializeField] private GameObject cardBack;

	[SerializeField] private SceneController Controller; // will use public methods from SceneController later

	private int _id;


	public void OnMouseDown() {
		if (cardBack.activeSelf && Controller.canReveal) {
			cardBack.SetActive (false);
			Controller.CardRevealed (this);
		}
	}

	public void Unreveal() {
		cardBack.SetActive(true);
	}


	public int id {
		get { return _id; }
	}

	public void SetCard(int id, Sprite image) {
		_id = id;
		GetComponent<SpriteRenderer>().sprite = image;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
