using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class SceneLoadAutoRequest : MonoBehaviour
{
    [Dropdown(nameof(Names))]
    [SerializeField] private string _sceneName;

    private IEnumerable<string> Names => SceneNames.GetNames();

    private void Start() => SceneLoader.TryLoad(_sceneName);
}