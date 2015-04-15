using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {
	public int IdAsteroid;
	public string Nombre;
	public string Descripcion;
	public string Composicion;
	public float Gravedad;
	public float Masa;
	public float PuntoAterrizaje;
	public int Misiones;

	public Asteroid(){
	}

	public Asteroid(int IdAsteroid, string Nombre, string Descripcion, string Composicion, float Gravedad,
	                float Masa, float PuntoAterrizaje, int Misiones){
		this.IdAsteroid = IdAsteroid;
		this.Nombre = Nombre;
		this.Descripcion = Descripcion;
		this.Composicion = Composicion;
		this.Gravedad = Gravedad;
		this.Masa = Masa;
		this.PuntoAterrizaje = PuntoAterrizaje;
		this.Misiones = Misiones;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
