using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Animation TurretAnimation;

    [SerializeField] Transform ShootingPoint;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Cooldown;

    [SerializeField] private bool IsPlayer;

    private float PassedCooldown = 0;

    private void Update()
    {
        CheckShooting();
    }

    private void CheckShooting()
    {
        PassedCooldown += Time.deltaTime;

        if(PassedCooldown >= Cooldown && Input.GetKeyDown(KeyCode.Space) && IsPlayer)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        PassedCooldown = 0;

        TurretAnimation.Play();
        Bullet bullet = Instantiate(Bullet, ShootingPoint.position,
                                    Quaternion.Inverse(ShootingPoint.rotation)).GetComponent<Bullet>();
        if (!IsPlayer)
            bullet.Speed *= 2;
        bullet.Shooter = gameObject;
    }
}
