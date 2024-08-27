using UnityEngine;
using UnityEngine.Events;

public class SFXToggle : ToggleListenerBase
{
    protected override UnityAction<bool> BoolListener => Toggle;

    private void Init() => base.Toggle.isOn =
        PlayerPrefs.GetInt(GlobalSFXInfo.SaveKey, 1) == 1;

    private void Toggle(bool value)
    {
        if (value) GlobalSFXInfo.Enable();
        else GlobalSFXInfo.Disable();
    }
}