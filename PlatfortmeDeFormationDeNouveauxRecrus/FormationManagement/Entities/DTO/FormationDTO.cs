namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO
{
    public class FormationDTO
    {
        public string Description { get; set; }
        public string Niveau { get; set; }
        public  string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NombreParticipant { get; set; }
        public int Duree { get; set; }
        public string statut { get; set; }
        public string EnPresence { get; set; }
    }
}
