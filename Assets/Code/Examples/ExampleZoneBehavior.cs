using Assets.Code.ZoneKeeper;
using UnityEngine;

namespace Assets.Code.Examples
{
    public class ExampleZoneBehavior : MonoBehaviour, IZoneFollowerBehavior
    {
        public virtual void AwayFromZone(Vector3 zonePosition, ZoneFollower me)
        {
            me.gameObject.transform.LookAt(zonePosition, Vector3.up);
        }
    }
}