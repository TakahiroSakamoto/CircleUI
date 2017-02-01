using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCanvas : MonoBehaviour {

	public GameObject controllerRight;
	public GameObject[] panels;

	RaycastHit hit;

	Animator[] anim = new Animator[3];

	Image[] panelImage = new Image[3];




	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < panels.Length; i++) {
			anim [i] = panels [i].GetComponent<Animator> ();
			panelImage [i] = panels [i].GetComponent<Image> ();
		}
	}

	// Update is called once per frame
	void Update()
	{
		Ray ray = new Ray(controllerRight.transform.position, controllerRight.transform.forward);

		if (Physics.Raycast(ray, out hit))
		{
			
			if (Physics.Raycast(ray, out hit)) {
				if(hit.collider.gameObject.tag == "Panel1")
				{
					print ("PPPPPP");
					anim[1].SetBool("isUnder", false);
					anim[2].SetBool("isLeft", false);
					anim[0].SetBool("isRight", true);
					anim[0].Play("LeftPositionScale");
					panelImage[0].color = Color.red;
					panelImage[1].color = Color.blue;
					panelImage[2].color = Color.blue;
					//gameObject.GetComponent<Renderer>().material.color = Color.green;
				} else if (hit.collider.gameObject.tag == "Panel2")
				{
					anim[0].SetBool("isRight", false);
					anim[2].SetBool("isLeft", false);
					anim[1].SetBool("isUnder", true);
					anim[1].Play("RightPositionScale");
					panelImage[0].color = Color.blue;
					panelImage[1].color = Color.green;
					panelImage[2].color = Color.blue;
					//gameObject.GetComponent<Renderer>().material.color = Color.green;
				} else if (hit.collider.gameObject.tag == "Panel3")
				{
					anim[0].SetBool("isRight", false);
					anim[1].SetBool("isUnder", false);
					anim[2].SetBool("isLeft", true);
					anim[2].Play("UnderPositionScale");
					panelImage[0].color = Color.blue;
					panelImage[1].color = Color.blue;
					panelImage[2].color = Color.black;
					// gameObject.GetComponent<Renderer>().material.color = Color.green;
				}
		}
	}
}
}