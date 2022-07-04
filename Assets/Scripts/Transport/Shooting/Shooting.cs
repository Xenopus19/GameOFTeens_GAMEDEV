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

    [SerializeField] private bool IsPlayer;

    private float PassedCooldown = 0;
    private bool IsEndGame;

    private void Start()
    {
        IsEndGame = false;
        Level.OnLevelFinished += EndShooting;
    }


    private void Update()
    {
        CheckShooting();
    }

    private void CheckShooting()
    {
        PassedCooldown += Time.deltaTime;

        if(PassedCooldown >= Cooldown && IsPlayer && !IsEndGame)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        PassedCooldown = 0;

        TurretShootingSound.Play();
        TurretAnimation.Play();
        Bullet bullet = Instantiate(Bullet, ShootingPoint.position,
                                    Quaternion.Inverse(ShootingPoint.rotation)).GetComponent<Bullet>();
        if (!IsPlayer)
            bullet.Speed *= 2;
        bullet.Shooter = gameObject;
    }

    private void EndShooting()
    {
        IsEndGame = true;
    }

    private void OnDestroy()
    {
        Level.OnLevelFinished -= EndShooting;
    }
}
