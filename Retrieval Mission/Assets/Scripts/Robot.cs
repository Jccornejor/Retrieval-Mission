using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {
	public int IdRobot;
	public float Velocidad;

	public int EnergiaInicial;
    private int Energia;
    private bool isControllable;
	// Use this for initialization

	public Robot(){
	}

	public Robot(int IdRobot, float Velocidad, int EnergiaInicial){
		this.IdRobot=IdRobot;
		this.Velocidad=Velocidad;
	    EnergiaInicial = EnergiaInicial;
	    Energia = EnergiaInicial;
	}


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void Landing(){

	}

	public void Move(){

	}

	public void Rotate(){

	}

	public void Grab(){

	}

	public void TurnLightOn(){

	}

	public void GrabCollectibles(){

	}

	public void Recharge(){

	}
}
