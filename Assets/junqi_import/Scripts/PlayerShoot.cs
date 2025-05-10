using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = .5f;
    private float _currntTime = 0.5f;
    private bool _canshoot = true;

    private void Update()
    {
        TimerMethod();
        Shoot();
    }

    private void TimerMethod()
    {

        _currntTime -= Time.deltaTime;

        if (_currntTime < 0)
        {
            _canshoot = true;
            _currntTime = Timer;
        }
    }


    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canshoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canshoot = false;
        }
    }

}