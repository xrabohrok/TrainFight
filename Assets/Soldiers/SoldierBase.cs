using Assets.Code.Clickable;
using Assets.Code.ZoneKeeper;
using UnityEngine;

namespace Assets.Soldiers
{
    [RequireComponent(typeof(ZoneFollower))]
    public class SoldierBase : MonoBehaviour, IClickable {
        public string MasterName = "soldierMaster";

        private GameObject _master;
        private SoldierMaster _soldierMaster;

        private ZoneFollower _zoner;

        public void Start()
        {
            FindMaster();
        }

        private void FindMaster()
        {
            _master = GameObject.Find(MasterName);
            _soldierMaster = _master.GetComponent<SoldierMaster>();
            _zoner = GetComponent<ZoneFollower>();
        }
	
        // Update is called once per frame
        public void Update () {
            
        }

        public void HoverReaction()
        {
        }

        public void ClickReaction()
        {
            _soldierMaster.ReportClick(this);
        }

        public virtual void MoveOrders(Zone newZone)
        {
            _zoner.SetHome(newZone);
        }
    }
}
