using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Config/BulletConfig/MachineGunBullet")]
public class MachineGunBullet : BulletConfig
{
    public override void Fire(Vector3 posSpawn, Vector3 target, BulletManager bulletManager, string tagName)
    {
        Vector3 direction = (target - posSpawn).normalized;
        GameObject obj = GameObject.Instantiate(bulletPrefab, posSpawn, Quaternion.identity);
        obj.tag = tagName;
        obj.transform.rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 0, 0);
        BulletInfo newBullet = new BulletInfo(obj.transform, direction, speed);
        bulletManager.bulletInfoList.Add(newBullet);
    }
}