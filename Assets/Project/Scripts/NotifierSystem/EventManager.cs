using System;
using UnityEngine;

namespace Project.Scripts.NotifierSystem
{
	public static class EventManager
	{
		public static event Action<KeyCode> OnAbilityPressed;

		public static void AbilityPressed(KeyCode abilityPressed) => OnAbilityPressed?.Invoke(abilityPressed);
	}
}