using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise
{
    public class PlanFormationService : IPlanFormationService
    {

        private readonly IPlanFormationRepository _planFormationRepository;
        public PlanFormationService(IPlanFormationRepository planRepository)
        {
            _planFormationRepository = planRepository;
        }
        public PlanFormation AddPlanFormation(PlanFormationDTO planFormation)
        {
            return _planFormationRepository.AddPlanFormation(planFormation);
        }
        public string RemovePlanFormation(int id)
        {
            return _planFormationRepository.RemovePlanFormation(id);
        }

        public PlanFormation updatePlanFormationById(PlanFormation planFormation, int idPF)
        {
            return _planFormationRepository.UpdatePlanFormation(planFormation, idPF);
        }

      
    }
}
