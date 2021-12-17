using UnityEngine;

public class MouseToWorldPosition : MonoBehaviour
{
	[SerializeField] private Camera _mainCamera;
	[SerializeField] private LayerMask _layer;

	private const float MAX_DISTANCE = 100f;

	private static MouseToWorldPosition _instance;

	private void Awake() => _instance = this;

	public static Vector3 GetWorldPosition()
	{
		var ray = _instance._mainCamera.ScreenPointToRay(Input.mousePosition);
		return Physics.Raycast(ray, out var raycastHit, MAX_DISTANCE, _instance._layer) ? raycastHit.point : default;
	}
}
