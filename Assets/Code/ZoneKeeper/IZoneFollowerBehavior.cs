using UnityEngine;

namespace Assets.Code.ZoneKeeper
{
    interface IZoneFollowerBehavior
    {
        void AwayFromZone(Vector3 zonePosition, ZoneFollower me);
    }
}