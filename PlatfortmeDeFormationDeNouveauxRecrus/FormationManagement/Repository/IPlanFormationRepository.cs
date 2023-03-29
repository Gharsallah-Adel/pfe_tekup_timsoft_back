using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository
{
    public interface IPlanFormationRepository
    {
        public PlanFormation AddPlanFormation(PlanFormationDTO planFormation);
        public PlanFormation UpdatePlanFormation(PlanFormation planFormation, int idPFor);
        public PlanFormation GetPlanFormationById(int id);
        public string RemovePlanFormation(int id);
    }
}
