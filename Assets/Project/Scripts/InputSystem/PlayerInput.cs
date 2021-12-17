using UnityEngine;

namespace Project.Scripts.UpdateSystem
{
	using NotifierSystem;

	public class PlayerInput : MonoBehaviour
	{
		[SerializeField] private KeyCode _q;
		[SerializeField] private KeyCode _w;
		[SerializeField] private KeyCode _e;
		[SerializeField] private KeyCode _r;

		private void Update()
		{
			if (Input.GetKeyDown(_q)) EventManager.QPressed();
			if (Input.GetKeyDown(_w)) EventManager.WPressed();
			if (Input.GetKeyDown(_e)) EventManager.EPressed();
			if (Input.GetKeyDown(_r)) EventManager.RPressed();
		}
	}
}
