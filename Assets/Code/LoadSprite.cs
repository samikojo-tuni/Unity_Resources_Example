using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSprite : MonoBehaviour
{
	[SerializeField] private SpriteRenderer spriteRenderer;
	public void LoadOne()
	{
		// Loads a sprite from Assets/Resources/1.png
		spriteRenderer.sprite = Resources.Load<Sprite>("1");
	}

	public void LoadRandom()
	{
		Sprite[] sprites = Resources.LoadAll<Sprite>("");
		spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
	}
}
