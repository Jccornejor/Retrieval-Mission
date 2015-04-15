using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Debug = UnityEngine.Debug;

/// <summary>
/// Clase que se encargara de manejar las notificaciones
/// </summary>
public class NotificationCenter : MonoBehaviour
{
    private static NotificationCenter _defaultCenter;

    // Our hashtable containing all the notifications.  
    // Each notification in the hash table is an ArrayList 
    // that contains all the observers for that notification.
    private readonly Hashtable _notifications = new Hashtable();

    private string data;

    /// <summary>
    /// Singleton donde se crea el objeto que sera el encargado de recibir las notificaciones
    /// </summary>
    public static NotificationCenter DefNotCenter
    {
        get
        {
            if (!_defaultCenter)
            {
                var notificationObject = new GameObject("NCenter");

                _defaultCenter = notificationObject.AddComponent<NotificationCenter>();
            }

            return _defaultCenter;
        }
    }

    // AddObserver includes a version where the observer can request to only receive notifications from a specific object. 
    // We haven't implemented that yet, so the sender value is ignored for now.
    /// <summary>
    /// Metodo con el cual se agrega un observador de eventos con un nombre especifico
    /// </summary>
    /// <param name="observer">quien es el objeto que observa</param>
    /// <param name="observerName">es el nombre del observador</param>
    public void AddObserver(Component observer, string observerName)
    {
        AddObserver(observer, observerName, null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="observer">Quien es el objeto que observa</param>
    /// <param name="observerName">nombdre del observador</param>
    /// <param name="sender">quien envia la notificacion</param>
    public void AddObserver(Component observer, string observerName, Component sender)
    {
        // If the observerName isn't good, then throw an error and return.
        if (string.IsNullOrEmpty(observerName))
        {
            Debug.Log("Null observerName specified for notification in AddObserver.");
            return;
        }
        // If this specific notification doesn't exist yet, then create it.
        if (_notifications[observerName] == null)
        {
            _notifications[observerName] = new List<Component>();
        }

        var notifyList = _notifications[observerName] as List<Component>;

        // If the list of observers doesn't already contain the one that's registering, the add it.
        if (notifyList != null && !notifyList.Contains(observer))
        {
            notifyList.Add(observer);
        }
    }

    /// <summary>
    /// Quita el observador
    /// </summary>
    /// <param name="observer">objeto del observador a quitar</param>
    /// <param name="observerName">nombre del observadir a quitar</param>
    public void RemoveObserver(Component observer, string observerName)
    {
        var notifyList = (List<Component>)_notifications[observerName];

        // Assuming that this is a valid notification Type, remove the observer from the list.
        // If the list of observers is now empty, then remove that notification Type from the notifications hash.
        // This is for housekeeping purposes.
        if (notifyList != null)
        {
            if (notifyList.Contains(observer))
            {
                notifyList.Remove(observer);
            }
            if (notifyList.Count == 0)
            {
                _notifications.Remove(observerName);
            }
        }
    }

    // PostNotification sends a notification object to all objects that have requested to receive this Type of notification.
    // A notification can either be posted with a notification object or by just sending the individual components.
    /// <summary>
    /// Metodo para enviar una notificacion
    /// </summary>
    /// <param name="aSender">quien envia</param>
    /// <param name="aName">nombre de que notifica</param>
    public void PostNotification(Component aSender, string aName)
    {
        PostNotification(new Notification(aSender, aName));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="aSender"></param>
    /// <param name="aName"></param>
    /// <param name="data"></param>
    public void PostNotification(Component aSender, string aName, string data)
    {
        PostNotification(new Notification(aSender, aName,data));
    }

    public void PostNotification(Component aSender, string aName, Component cData)
    {
        PostNotification(new Notification(aSender, aName, cData));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="aSender"></param>
    /// <param name="aName"></param>
    /// <param name="aData"></param>
    public void PostNotification(Component aSender, string aName, Hashtable aData)
    {
        PostNotification(new Notification(aSender, aName, aData));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="aNotification"></param>
    public void PostNotification(Notification aNotification)
    {
        // First make sure that the observerName of the notification is valid.
        //Debug.Log("sender: " + aNotification.observerName);
        if (string.IsNullOrEmpty(aNotification.Name))
        {
            Debug.Log("Null observerName sent to PostNotification.");
            return;
        }
        // Obtain the notification list, and make sure that it is valid as well
        var notifyList = (List<Component>)_notifications[aNotification.Name];
        if (notifyList == null)
        {
            Debug.Log("Notify list not found in PostNotification: " + aNotification.Name);
            return;
        }

        // Create an array to keep track of invalid observers that we need to remove
        var observersToRemove = new List<Component>();

        // Itterate through all the objects that have signed up to be notified by this Type of notification.
        foreach (Component observer in notifyList)
        {
            // If the observer isn't valid, then keep track of it so we can remove it later.
            // We can't remove it right now, or it will mess the for loop up.
            if (!observer)
            {
                observersToRemove.Add(observer);
            }
            else
            {
                // If the observer is valid, then send it the notification. The message that's sent is the observerName of the notification.
                observer.SendMessage(aNotification.Name, aNotification, SendMessageOptions.DontRequireReceiver);
            }
        }

        // Remove all the invalid observers
        foreach (Component observer in observersToRemove)
        {
            notifyList.Remove(observer);
        }
    }
}

