using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        Instantiate(BulletBazooka, shootPoint.position, Quaternion.identity);
    }
}
