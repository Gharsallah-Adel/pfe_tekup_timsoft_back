using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository
{
    public class PlanFormationRepository : IPlanFormationRepository
    {
        private readonly DataBaseContext dataBase;

        public PlanFormationRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public PlanFormation AddPlanFormation(PlanFormationDTO planFormation)
        {
            PlanFormation dbPlanFormation = new PlanFormation();
            dbPlanFormation.Module = planFormation.Module;
            dbPlanFormation.Debut = planFormation.Debut;
            dbPlanFormation.Fin = planFormation.Fin;
            dbPlanFormation.Chapitre = planFormation.Chapitre;

            dataBase.Add(dbPlanFormation);
            dataBase.SaveChanges();
            return dbPlanFormation;
        }

        public PlanFormation GetPlanFormationById(int id)
        {
            throw new NotImplementedException();
        }

     
        public string RemovePlanFormation(int id)
        {
            PlanFormation fors = dataBase.PlanFormations.Where(f => f.PlanFormation_id == id).FirstOrDefault();
            dataBase.PlanFormations.Remove(fors);
            dataBase.SaveChanges();
            return "Plan formation deleted ";
        }



        public PlanFormation UpdatePlanFormation(PlanFormation planFormation, int idPFor)
        {
            PlanFormation updtPFor = dataBase.PlanFormations.Where(f => f.PlanFormation_id == idPFor).FirstOrDefault();
            updtPFor.Module = planFormation.Module;
            updtPFor.Debut = planFormation.Debut;
            updtPFor.Fin = planFormation.Fin;
            updtPFor.Chapitre = planFormation.Chapitre;

            dataBase.PlanFormations.Update(updtPFor);
            dataBase.SaveChanges();
            return updtPFor;

        }
    }
}

