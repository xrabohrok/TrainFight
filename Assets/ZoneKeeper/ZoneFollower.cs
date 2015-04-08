using Assets.HotSpot;
using UnityEngine;

namespace Assets.ZoneKeeper
{
    [RequireComponent(typeof(Clickable))]
    public class ZoneFollower : MonoBehaviour
    {

        public GameObject CurrentZone;
        public float DistanceVariations = 1f;

        private Zone _attachedZone;
        private Clickable _clickable;

        // Use this for initialization
        public void Start ()
        {
            if(CurrentZone != null)
            {
                _attachedZone = CurrentZone.GetComponent<Zone>();
                if (_attachedZone == null)
                    CurrentZone = null;
            }
            _clickable = GetComponent<Clickable>();
        }
	
        // Update is called once per frame
        public void Update ()
        {
            var here = this.gameObject.transform.position;
            var position = _attachedZone.gameObject.transform.position;
            var distance = Vector3.Distance(here, position);
            if (distance > DistanceVariations)
            {
                var lookAtPost = new Vector3(position.x, here.y, position.z);
                this.gameObject.transform.LookAt(lookAtPost,Vector3.up);
            }
        }
    }
}
