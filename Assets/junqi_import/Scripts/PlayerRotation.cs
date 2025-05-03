using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera _Camera;

    private string CameraName = "Game_Camera";

    private Vector3 _PositionMouse;

    private void Start()
    {
        _Camera = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        _PositionMouse = _Camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = _PositionMouse - transform.position;

        float rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }
}
    

