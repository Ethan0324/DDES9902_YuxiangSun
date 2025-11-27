using UnityEngine;

public class gasswitch : MonoBehaviour
{
    public firecontroller firecontroller;
    private bool isOff = false;   

    public void OnSwitchClicked()
    {

        if (!isOff)
        {
            transform.Rotate(100, -80, -90);
            isOff = true;

            Debug.Log("Gas ON");
        }
        else
        {

            transform.Rotate(100, -80, -90);

            firecontroller.GasTurnedOff();
            isOff = false;

            Debug.Log("Gas OFF");
        }
    }
}