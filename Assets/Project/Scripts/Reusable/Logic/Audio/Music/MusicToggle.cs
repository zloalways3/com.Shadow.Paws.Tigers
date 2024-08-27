using UnityEngine;
using UnityEngine.Events;

public class MusicToggle : ToggleListenerBase
{
    protected override UnityAction<bool> BoolListener => Toggle;

    private void Init() => base.Toggle.isOn =
        PlayerPrefs.GetInt(GlobalMusicInfo.SaveKey, 1) == 1;

    private void Toggle(bool value)
    {
        if (value) GlobalMusicInfo.Enable();
        else GlobalMusicInfo.Disable();
    }
}