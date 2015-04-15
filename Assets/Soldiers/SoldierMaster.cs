using System.Collections.Generic;
using Assets.Code.Clickable;
using Assets.Code.ZoneKeeper;
using UnityEngine;

namespace Assets.Soldiers
{
    [RequireComponent(typeof(ClickEventDelegator))]
    public class SoldierMaster : MonoBehaviour {
        private ClickEventDelegator _slaveDriver;

        private List<SoldierBase> _selectedSoldiers; 

        public void Start () {

            _slaveDriver = this.gameObject.GetComponent<ClickEventDelegator>();
            if (_slaveDriver == null)
                throw new System.NullReferenceException();

            _selectedSoldiers = new List<SoldierBase>();

        }
	
        public void Update () {
            //give soldiers a way to report progress
	        _slaveDriver.Update();

        }

        public void ReportClick(SoldierBase soldierBase)
        {
            if (!_selectedSoldiers.Contains(soldierBase))
            {
                _selectedSoldiers.Add(soldierBase);
            }
        }

        public void ReportClick(Zone clickedZone)
        {
            foreach (var selectedSoldier in _selectedSoldiers)
            {
                selectedSoldier.goToZone(clickedZone.WhereAmI(selectedSoldier.));
            }
        }
    }
}
