using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventQuit : MonoBehaviour
{
    public bool preventAppQuit;
    
    void Start()
    {
        Application.wantsToQuit += WantsToQuit;
    }
    
    /// <summary>
    /// Toggle the preventAppQuit bool to prevent the application from quitting.
    /// </summary>
    /// <returns></returns>
    public void TogglePreventQuit()
    {
        preventAppQuit = !preventAppQuit;
    }
    
    /// <summary>
    /// Quit the application.
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
    
    bool WantsToQuit()
    {
        return !preventAppQuit;
    }
}
