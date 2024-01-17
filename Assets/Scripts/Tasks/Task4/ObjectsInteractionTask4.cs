using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    
    [SerializeField] private Toaster _toaster;
    [SerializeField] private Transform _waffleRoot;
    [SerializeField] private GameObject _waffle;

    private void Awake()
    {
        _toaster.TimerIsUp += CreateWaffle;
    }

    private void CreateWaffle()
    {
        Instantiate(_waffle, _waffleRoot);
    }
}