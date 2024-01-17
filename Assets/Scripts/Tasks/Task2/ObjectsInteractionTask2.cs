using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
    [SerializeField] private GameObject _prefabLamp;
    [SerializeField] private Transform _lamproot;

    private void Awake()
    {
        Instantiate(_prefabLamp, _lamproot);
    }
}