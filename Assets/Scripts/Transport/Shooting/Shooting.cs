using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Animation TurretAnimation;
    [SerializeField] private AudioSource TurretShootingSound;

    [SerializeField] Transform ShootingPoint;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Cooldown;

    private float PassedCooldown = 0;

    private void Update()
    {
        CheckShooting();
    }

    private void CheckShooting()
    {
        PassedCooldown += Time.deltaTime;

        if(PassedCooldown >= Cooldown && Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        PassedCooldown = 0;

        TurretShootingSound.Play();
        TurretAnimation.Play();
        Instantiate(Bullet, ShootingPoint.position, Quaternion.Inverse(ShootingPoint.rotation));
    }
}
