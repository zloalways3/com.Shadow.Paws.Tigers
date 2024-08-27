using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class ChangeSceneButton : ButtonListenerBase
{
    [Dropdown(nameof(Names))]
    [SerializeField] private string _selectedSceneName;

    private IEnumerable<string> Names => SceneNames.GetNames();

    protected override UnityAction Listener => () => SceneLoader.TryLoad(_selectedSceneName);
}