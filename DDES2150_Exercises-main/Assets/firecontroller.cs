using UnityEngine;

public class firecontroller : MonoBehaviour
{
    public GameObject successUI;
    public bool gasOff = false;

    public void GasTurnedOff()
    {
        gasOff = true;
    }

    public void FireExtinguished()
    {
        successUI.SetActive(true);
    }
}