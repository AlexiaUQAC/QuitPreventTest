using TMPro;
using UnityEngine;

public class PreventQuit : MonoBehaviour
{
    public bool canQuit;
    public TextMeshProUGUI text;
    
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
        canQuit = !canQuit;
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
        if (!canQuit)
        {
            Invoke("ForceQuit", 5f);
            text.text = "L'app va quitter dans 5s !";
        }
        return canQuit;
    }

    private void ForceQuit()
    {
        canQuit = true;
        Quit();
    }
}
