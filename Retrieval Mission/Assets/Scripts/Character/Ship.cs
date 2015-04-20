using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{

    public int IdShip;
    public string Nombre;
    public float Velocidad;
    public float VelocidadInicial;
    public float VelocidadFinal;

    public int SaludInicial;
    public float AltitudInicial;
    private float Altitud;
    private bool isLanded;
    private int Salud;
    private bool isControllable;
    public Ship()
    {

    }

    public Ship(int IdShip, string Nombre, float Velocidad, float VelocidadInicial, float VelocidadFinal,
                 int SaludInicial, float AltitudInicial)
    {
        this.IdShip = IdShip;
        this.Nombre = Nombre;
        this.Velocidad = Velocidad;
        this.VelocidadInicial = VelocidadInicial;
        this.VelocidadFinal = VelocidadFinal;
        this.Salud = SaludInicial;
        this.SaludInicial = SaludInicial;
        this.AltitudInicial = AltitudInicial;
        this.Altitud = AltitudInicial;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CambioVelocidad()
    {

    }

    public void CambioSalud()
    {

    }

    public void CambioAltitud()
    {

    }
}

