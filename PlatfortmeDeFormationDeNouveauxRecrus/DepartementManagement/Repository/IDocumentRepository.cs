using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IDocumentRepository
    {
        public Document AddDocument(DocumentDTO documentForm);
        public Document UpdateDocument(Document document , int docId);
       // public Document GetDocumentById(int id);
        public string RemoveDocument(int id);
        public List<Document> GetDocuments();

    }
}
