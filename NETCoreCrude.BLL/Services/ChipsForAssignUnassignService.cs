using FleetControl.DAL.Models.Chip;
using FleetControl.DAL.Repositories;
using System.Collections.Generic;

namespace FleetControl.BLL.Services
{
    public class ChipsForAssignUnassignService
    {
        private IChipsForAssignUnassignRepository _ChipsForAssignUnassignRepository;

        public ChipsForAssignUnassignService(IChipsForAssignUnassignRepository ChipsForAssignUnassignRepository)
        {
            _ChipsForAssignUnassignRepository = ChipsForAssignUnassignRepository;
        }

        public IEnumerable<GetChipsAssignViewModel> GetChipsAssigned(int clientID)
        {
            return _ChipsForAssignUnassignRepository.GetChipsAssigned(clientID);
        }

        public bool Unassign(string ChipId)
        {
            return _ChipsForAssignUnassignRepository.Unassign(ChipId);
        }

        public IEnumerable<GetChipsUnassignedViewModel> GetChipsUnAssigned()
        {
            return _ChipsForAssignUnassignRepository.GetChipsUnAssigned();
        }

        public bool GoBackAssignChip(int ClienteID, string ChipID)
        {
            return _ChipsForAssignUnassignRepository.GoBackAssignChip(ClienteID, ChipID);
        }

        public IEnumerable<GetChipsUnassignedViewModel> GetSearchforChipsUnAssigned(string ChipID)
        {
            return _ChipsForAssignUnassignRepository.GetSearchforChipsUnAssigned(ChipID);
        }
    }
}