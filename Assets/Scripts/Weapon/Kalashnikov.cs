using UnityEngine;

public class Kalashnikov : Weapon
{
    public override void Shoot()
    {
        Instantiate(Bullet, FirePosition.position, Quaternion.identity);
    }
}
