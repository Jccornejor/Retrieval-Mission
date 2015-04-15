using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Clase que maneja el Score de un jugador especificado
/// </summary>
public class ScoreManager : MonoBehaviour
{
    private static int _score; // The player's Score.
    private static string _player; // The player's name
    private static string _message; // The Score message
    private static Text _text; // Reference to the Text component.
 

    void Start()
    {
        NotificationCenter.DefNotCenter.AddObserver(this,"OnCollect");
        // Set up the reference.
        _text = GetComponent<Text>();
       // Debug.Log(_text);
        // Reset the Score.
        _score = 0;
        _player = "";
        _message = "";
        _text.text = "0";
    }

    /// <summary>
    /// Metodo para actualizar el Score unico
    /// </summary>
    /// <param name="score">valor del Score</param>
    public void OnCollect()
    {
        _score ++;
        if (_score==11)
        {
            NotificationCenter.DefNotCenter.PostNotification(this,"OnWin");
        }
        //var m = s.PadLeft(10,'0');
        _text.text = _score.ToString();
   

    }

    /// <summary>
    /// Metodo para actualizar el Score de un jugador
    /// </summary>
    /// <param name="player">nombdre del jugador a actualizar el Score</param>
    /// <param name="score">valor del Score</param>
    public void UpdateScore(string player, int score)
    {
        if (_text.name.Equals(player))
        {
            _score += score;
            _text.text = "Score: " + _score;
        }
        else
        {
            _text.text = player + _score;
        }
    }
    /// <summary>
    /// Metodo para actualizar el Score de un jugador con un mensaje personalizado
    /// </summary>
    /// <param name="player">nombdre del jugador a actualizar el Score</param>
    /// <param name="message">mensaje personalizado</param>
    /// /// <param name="score">valor del Score</param>
    public void UpdateScore(string player, string message, int score)
    {
        if (_text.name.Equals(player))
        {
            _text.text = message + score;
        }
    }
}
