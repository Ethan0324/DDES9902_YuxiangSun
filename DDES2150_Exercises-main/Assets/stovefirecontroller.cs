using UnityEngine;
using System.Collections;

public class stovefirecontroller : MonoBehaviour
{
    public GameObject successUI;            // 成功 UI
    public GameObject stoveFireFX;          // 火焰特效对象
    public stoveswitch stoveSwitch;         // 灶台按钮脚本（判断是否关闭）

    private bool smokeTouch = false;        // 是否接触到烟雾
    private float smokeTimer = 0f;          // 计时器
    private float requiredTime = 3f;        // 需要接触 3 秒才灭火

    private void OnTriggerStay(Collider other)
    {
        // 必须是烟雾粒子对象
        if (!other.CompareTag("smoke")) return;

        smokeTouch = true;
        smokeTimer += Time.deltaTime;

        // 只有烟雾接触 + 灶台开关已关闭 才灭火
        if (smokeTimer >= requiredTime && stoveSwitch.isOff == false)
        {
            ExtinguishFire();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("smoke"))
        {
            smokeTouch = false;
            smokeTimer = 0f; // 离开时重置计时
        }
    }

    void ExtinguishFire()
    {
        stoveFireFX.SetActive(false);
        successUI.SetActive(true);

        Debug.Log("Stove Fire Extinguished.");
    }
}