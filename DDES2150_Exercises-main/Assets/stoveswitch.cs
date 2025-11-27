using UnityEngine;

public class stoveswitch : MonoBehaviour
{
    public firecontroller firecontroller;
    public bool isOff = false;    

    public void OnSwitchClicked()
    {
        if (!isOff)
        {
            transform.Rotate(100, -80, -90);
            isOff = true;

            Debug.Log("Stove ON");
        }
        else
        {
            transform.Rotate(100, -80, -90);

            firecontroller.GasTurnedOff();
            isOff = false;

            Debug.Log("Stove OFF");
        }
    }
}