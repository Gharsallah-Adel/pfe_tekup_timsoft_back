using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository;
using System;

public class FormationRepository : IFormationRepository
{
    private readonly DataBaseContext dataBase;

    public FormationRepository(DataBaseContext dataBase)
    {
        this.dataBase = dataBase;
    }

    public Formation AddFormation(FormationDTO formation)
    {
        Formation dbFormation = new Formation();
        dbFormation.Description = formation.Description;
        dbFormation.Niveau = formation.Niveau;
        dbFormation.DateDebut = formation.DateDebut;
        dbFormation.DateFin = formation.DateFin;
        dbFormation.NombreParticipant = formation.NombreParticipant;
        dbFormation.Duree = formation.Duree;
        dbFormation.statut = formation.statut;
        dbFormation.EnPresence = formation.EnPresence;
        dataBase.Add(dbFormation);
        dataBase.SaveChanges();
        return dbFormation;
    }

    public int GetFormationsCount()
    {
        return dataBase.Formations.Count();
    }

    public List<Formation> GetAllFormations()
    {
        List<Formation> formations = new List<Formation>();
        formations = dataBase.Formations.ToList();
        return formations;
    }

    public Formation GetFormationtById(int id)
    {
        throw new NotImplementedException();
    }



    public string RemoveFormation(int id)
    {
        Formation fors = dataBase.Formations.Where(f => f.Formation_id == id).FirstOrDefault();
        dataBase.Formations.Remove(fors);
        dataBase.SaveChanges();
        return "formation deleted ";
    }

  

    public Formation UpdateFormation(Formation formation, int idFor)
    {
        Formation updtFor = dataBase.Formations.Where(f => f.Formation_id == idFor).FirstOrDefault();
        updtFor.Description = formation.Description;
        updtFor.Niveau = formation.Niveau;
        updtFor.DateDebut = formation.DateDebut;
        updtFor.DateFin = formation.DateFin;
        updtFor.NombreParticipant = formation.NombreParticipant;
        updtFor.Duree = formation.Duree;
        updtFor.statut = formation.statut;
        updtFor.EnPresence = formation.EnPresence;
        dataBase.Formations.Update(updtFor);
        dataBase.SaveChanges();
        return updtFor;

    }
}


