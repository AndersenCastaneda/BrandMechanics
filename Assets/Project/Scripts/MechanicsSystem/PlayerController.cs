using UnityEngine;

namespace Project.Scripts.MechanicsSystem
{
	using NotifierSystem;

	public class PlayerController : MonoBehaviour
	{
		[SerializeField] private Ability[] _abilities;

		private void OnEnable() => EventManager.OnWPressed += SetAbility;

		private void OnDisable() => EventManager.OnWPressed -= SetAbility;

		private void SetAbility()
		{
			_abilities[1].Prepare();
		}
	}
}
