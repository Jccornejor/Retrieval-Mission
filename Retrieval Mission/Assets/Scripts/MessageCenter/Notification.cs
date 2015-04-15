using System.Collections;
using UnityEngine;

/// <summary>
/// Clase que actuara como notificacion al ocurrir algun evento
///The Notification class is the object that is send to receiving objects of a notification Type.
/// This class contains the sending GameObject, the observerName of the notification, 
/// and optionally a hashtable containing data.
/// </summary>
public class Notification
{

    public Hashtable Data;
    public string Name;
    public string SData;
    public Component Sender;
    public Component CData;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="aSender">Quien lo manda</param>
    /// <param name="aName">Quien lo observa</param>
    public Notification(Component aSender, string aName)
    {
        Sender = aSender;
        Name = aName;
        Data = null;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="aSender">Quien lo manda</param>
    /// <param name="aName">Quien lo observa</param>
    /// <param name="aData">datos a enviar</param>
    public Notification(Component aSender, string aName, Hashtable aData)
    {
        Sender = aSender;
        Name = aName;
        Data = aData;
    }

    public Notification(Component aSender, string aName, Component cData)
    {
        Sender = aSender;
        Name = aName;
        CData = cData;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="aSender">Quien lo manda</param>
    /// <param name="aName">Quien lo observa</param>
    /// <param name="aData">datos a enviar</param>
    public Notification(Component aSender, string aName, string aData)
    {
        Sender = aSender;
        Name = aName;
        SData = aData;
    }
}