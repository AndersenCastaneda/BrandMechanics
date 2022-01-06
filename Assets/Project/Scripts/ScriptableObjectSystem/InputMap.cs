using UnityEngine;

namespace Project.Scripts.ScriptableSystem
{
	[CreateAssetMenu(menuName = "ScriptableObject/InputAbility")]
	public class InputMap : ScriptableObject
	{
		public KeyCode FirstAbility;
		public KeyCode SecondAbility;
		public KeyCode ThirdAbility;
		public KeyCode FourthAbility;

		public KeyCode CancelAbility;
		public KeyCode OpenStore;
	}
}