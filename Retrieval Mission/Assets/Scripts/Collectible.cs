using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {
	public int IdCollectible;
	public string Nombre;
	public string Descripcion;
	public string Tipo;

	public Collectible(){

	}

	public Collectible(int IdCollectible, string Nombre, string Descripcion, string Tipo){
		this.IdCollectible = IdCollectible;
		this.Nombre = Nombre;
		this.Descripcion = Descripcion;
		this.Tipo = Tipo;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollected(){

	}

	public void OnCreated(){

	}
}
