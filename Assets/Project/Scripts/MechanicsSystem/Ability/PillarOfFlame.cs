using UnityEngine;

public class PillarOfFlame : Ability
{
	[SerializeField] private GameObject _areaSpell;
	private Transform _transform;

	private void Awake() => _transform = _areaSpell.transform;

	public override void Prepare()
	{
		_areaSpell.SetActive(true);
	}

	public override void Execute()
	{
	}

	private void Update()
	{
		_transform.position = MouseToWorldPosition.GetWorldPosition();
	}
}
