using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaScript : MonoBehaviour {

	public float velocidade;

	//interface com animator
	Animator animator;
	SpriteRenderer spriteRender;


	// Use this for initialization
	void Start () {

		//Interface para o componente animator
		animator = GetComponent<Animator> ();
		spriteRender = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Mover o personagem
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		//Orientacao do sprite (direita ou esquerda)
		//O zero não mexe pq ele tem q manter parado no ultimo lado
		if(mover_x > 0.0f) {
			spriteRender.flipX = false;
		} else if (mover_x < 0.0f) {
			spriteRender.flipX = true;
		}



		//Reproduz animacao
		animator.SetFloat("pMover", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
	}
}
