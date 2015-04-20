using UnityEngine;
using System.Collections;

public class Mission : MonoBehaviour {
	public int IdMission;
	public string Nombre;
	public int Orden;
	public string Tipo;

	public Collectible Collectibles;

	public Mission(){

	}

	public Mission(int IdMission, string Nombre, int Orden, string Tipo, Collectible Collectibles){
		this.IdMission = IdMission;
		this.Nombre = Nombre;
		this.Orden = Orden;
		this.Tipo = Tipo;
		this.Collectibles = Collectibles;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
