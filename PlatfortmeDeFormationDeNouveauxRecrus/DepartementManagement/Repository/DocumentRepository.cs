using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using static PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository.DocumentRepository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class DocumentRepository : IDocumentRepository
    {

        private readonly DataBaseContext dataBase;

        public DocumentRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Document AddDocument(DocumentDTO document)
        {
            Document dbDocument = new Document();
            dbDocument.Description = document.Description;
            dbDocument.PieceJointe = document.PieceJointe;
            dataBase.Add(dbDocument);
            dataBase.SaveChanges();
            return dbDocument;
        }

     
     

        public string RemoveDocument(int id)
        {
            Document doc = dataBase.Documents.Where(d => d.Document_id == id).FirstOrDefault();
            dataBase.Documents.Remove(doc);
            dataBase.SaveChanges();
            return "Document deleted ";
        }
        public Document UpdateDocument(Document document, int docId)
        {

            Document updtdoc = dataBase.Documents.Where(doc => doc.Document_id == docId).FirstOrDefault();
            updtdoc.Description = document.Description;
            updtdoc.PieceJointe = document.PieceJointe;
            dataBase.Documents.Update(updtdoc);
            dataBase.SaveChanges();
            return updtdoc;
        }
        public List<Document> GetDocuments()
        {
            List<Document> documents = new List<Document>();
            documents = dataBase.Documents.ToList();
            return documents;
        }


    }

}
