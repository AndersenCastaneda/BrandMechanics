using UnityEngine;

namespace Project.Scripts.MechanicsSystem
{
	using NotifierSystem;
	using ScriptableSystem;

	public class AbilityManager : MonoBehaviour
	{
		[SerializeField] private InputMap _input;
		[SerializeField] private Ability[] _abilities;

		private int? _abilityIndex;

		private void OnEnable() => EventManager.OnAbilityPressed += SetAbility;

		private void OnDisable() => EventManager.OnAbilityPressed -= SetAbility;

		private void SetAbility(KeyCode abilityPressed)
		{
			if (abilityPressed == _input.SecondAbility)
				_abilityIndex = 1;

			if (_abilityIndex.HasValue)
				_abilities[_abilityIndex.Value].Prepare();
		}

		private void Update()
		{
			if (Input.GetKeyDown(_input.CancelAbility))
				CancelAbilities();

			if (_abilityIndex.HasValue)
				_abilities[_abilityIndex.Value].ShowAbility();
		}

		private void CancelAbilities()
		{
			_abilityIndex = null;

			for (int i = 0, length = _abilities.Length; i < length; ++i)
				_abilities[i].Cancel();
		}
	}
}