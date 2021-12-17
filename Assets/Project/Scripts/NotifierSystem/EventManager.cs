using System;

namespace Project.Scripts.NotifierSystem
{
	public static class EventManager
	{
		public static event Action OnQPressed;
		public static event Action OnWPressed;
		public static event Action OnEPressed;
		public static event Action OnRPressed;

		public static void QPressed() => OnQPressed?.Invoke();
		public static void WPressed() => OnWPressed?.Invoke();
		public static void EPressed() => OnEPressed?.Invoke();
		public static void RPressed() => OnRPressed?.Invoke();
	}
}
