using UnityEngine;

namespace Project.Scripts.UpdateSystem
{
	using NotifierSystem;
	using ScriptableSystem;

	public class PlayerInput : MonoBehaviour
	{
		[SerializeField] private InputMap _input;

		private void Update()
		{
			if (Input.GetKeyDown(_input.FirstAbility)) EventManager.AbilityPressed(_input.FirstAbility);
			if (Input.GetKeyDown(_input.SecondAbility)) EventManager.AbilityPressed(_input.SecondAbility);
			if (Input.GetKeyDown(_input.ThirdAbility)) EventManager.AbilityPressed(_input.ThirdAbility);
			if (Input.GetKeyDown(_input.FourthAbility)) EventManager.AbilityPressed(_input.FourthAbility);
		}
	}
}