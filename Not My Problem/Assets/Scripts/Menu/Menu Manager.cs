using UnityEngine;

public class MenuManager : MonoBehaviour
{

    [SerializeField] GameObject targetCanvas;


    //To Show Canvas through signal emitter, there is no need to an update or start
    public void ShowCanvas()
    {
        if (targetCanvas != null)
        {
            targetCanvas.SetActive(true);
        }
    }
 
    //To Hide Canvas through signal emitter, there is no need to an update or start
    public void HideCanvas()
    {

        if (targetCanvas != null)
        {
            targetCanvas.SetActive(false);
        }
    }
}
