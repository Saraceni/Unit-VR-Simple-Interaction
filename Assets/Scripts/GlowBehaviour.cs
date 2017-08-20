using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBehaviour : MonoBehaviour {

	public Material HighlightMaterial; 

	private Material m_NormalMaterial;
	private Renderer m_Renderer;

	// Use this for initialization
	void Start () {
		m_Renderer = GetComponent<Renderer> ();
		m_NormalMaterial = m_Renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Glow() {
		m_Renderer.material = HighlightMaterial;
	}

	public void Normal() {
		m_Renderer.material = m_NormalMaterial;
	}
}
