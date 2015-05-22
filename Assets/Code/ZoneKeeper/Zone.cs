using System.Collections.Generic;
using Assets.Code.Clickable;
using Assets.Soldiers;
using UnityEngine;

namespace Assets.Code.ZoneKeeper
{
    public class Zone : MonoBehaviour, IClickable
    {
        public string MasterName = "soldierMaster";
        public List<Zone> Neighbors;
        public List<ZoneFollower> Guards;
        public int MaxOccupants = 1;

        public int Capacity
        {
            get { return MaxOccupants - Guards.Count; }
        }

        private GameObject _master;
        private SoldierMaster _soldierMaster;


        // Use this for initialization
        public void Start () {
            _master = GameObject.Find(MasterName);
            _soldierMaster = _master.GetComponent<SoldierMaster>();
        }
	
        // Update is called once per frame
        public void Update () {
	
        }

        public Vector3? JoinZone(ZoneFollower immigrant)
        {
            if (Guards.Count < MaxOccupants)
            {
                Guards.Add(immigrant);

                //TODO: make this a derived location instead
                return this.gameObject.transform.position;
            }
            return null;
        }

        public void HoverReaction()
        {
        }

        public void ClickReaction()
        {
            _soldierMaster.ReportClick(this);
            Debug.Log("Zone Clicked!");
        }

        public void LeaveZone(ZoneFollower zoneFollower)
        {
            Guards.Remove(zoneFollower);
        }
    }
}
