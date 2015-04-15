using UnityEngine;

public class Player : MonoBehaviour
{
    public int IdPlayer;

    public string Nombre;
    public Robot Robot;
    public Ship Ship;

    public Player()
    {
    }

    public Player(int idPlayer, string nombre, Robot robot)
    {
        IdPlayer = idPlayer;
        this.Nombre = nombre;
        this.Robot = robot;
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}