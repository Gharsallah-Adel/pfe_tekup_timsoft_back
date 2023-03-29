using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise
{
    public interface IPlanFormationService
    {
        public PlanFormation AddPlanFormation(PlanFormationDTO planFormation);
        public string RemovePlanFormation(int id);
        public PlanFormation updatePlanFormationById(PlanFormation planFormation, int idPF);
    }
}
