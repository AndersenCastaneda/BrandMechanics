using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    [SerializeField] private GameObject _areaSpell;
    private Transform _transform;

    protected virtual void Awake() => _transform = _areaSpell.transform;

    public void Prepare() => _areaSpell.SetActive(true);

    public void ShowAbility()
    {
        var position = MousePosition.GetWorldPosition();
        position.y = 0.01f;
        _transform.position = position;
    }

    public void Cancel() => _areaSpell.SetActive(false);

    public abstract void Execute();
}